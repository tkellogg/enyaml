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
	: s=string_expr { $result = s; }
	;
	
string_expr returns [string result] 
	: ^(QUOTED_STRING QuotedString)
	{ $result = ExtractString($QuotedString); }
	;
	
	