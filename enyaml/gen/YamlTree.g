tree grammar YamlTree;

options {
	language = 'CSharp2';
	tokenVocab=Yaml;
	ASTLabelType=CommonTree;
}

@header {
using System.Text;
using System.Text.RegularExpressions;
}

@namespace { enyaml.parser }

@members {
	private string ExtractString(CommonTree token) {
            var text = token.Text;
            if (text.StartsWith("\""))
                text = text.Substring(1, text.Length - 2);
            return Regex.Replace(text, "\\\\([btnfr'\"\\\\])", x => {
                switch (x.Groups[1].Value) {
                    case "b": return "\b";
                    case "t": return "\t";
                    case "n": return "\n";
                    case "f": return "\f";
                    case "r": return "\r";
                    case "'": return "'";
                    case "\"": return "\"";
                    case "\\": return "\\";
                    default: throw new InvalidOperationException("Can't ever get here");
                }
            });
	}
}

value returns [object result]
	: i=integer { $result = i; }
	| f=float_expr { $result = f; }
	| s=string_expr { $result = s; }
	;
	
integer returns [int result]
	: ^(INTEGER Integer)
		{ $result = int.Parse($Integer.Text); }
	;
	
float_expr returns [double result]
	: ^(FLOAT Float)
		{ $result = double.Parse($Float.Text); }
	;
	
string_expr returns [string result] 
	: ^(QUOTED_STRING QuotedString)
		{ $result = ExtractString($QuotedString); }
//	| ^(UNQUOTED_STRING UnQuotedString)
//		{ $result = ExtractString($UnQuotedString); }
	;
	
	