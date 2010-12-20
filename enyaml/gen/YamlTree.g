tree grammar YamlTree;

options {
	language = 'CSharp2';
	tokenVocab=Yaml;
	ASTLabelType=CommonTree;
}

@header {
using System.Collections.Generic;
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
	: b=boolean { $result = $b.result; }
	| i=integer { $result = $i.result; }
	| f=float_expr { $result = $f.result; }
	| s=string_expr { $result = $s.result; }
	| m=map { $result = $m.result; }
	| l=list { $result = $l.result; }
	;
	
boolean returns [bool result]
	: ^(BOOL Bool)
		{ $result = bool.Parse($Bool.Text); }
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
	
map returns [SortedDictionary<string, object> result]
	scope {
		SortedDictionary<string, object> dict;
	}
	@init {
		$map::dict = new SortedDictionary<string, object>();
	}
	@after {
		result = $map::dict;
	}
	: '{' map_pair+ '}'
	;
	
map_pair 
	: ^(':' key=string_expr val=value)
		{ $map::dict.Add($key.result, $val.result); }
	;
	
list returns [List<object> result]
	@init {
		$result = new List<object>();
	}
	: '[' (value { $result.Add($value.result); })+ ']'
	;
	
	