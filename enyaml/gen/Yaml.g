grammar Yaml;

options {
	language = 'CSharp2';
	output=AST;
}

tokens {
	QUOTED_STRING; UNQUOTED_STRING; INTEGER; FLOAT; BOOL;
	DOUBLE_QUOTE; SINGLE_QUOTE; MAP;
}

@namespace { enyaml.parser }

value
	: boolean
	| integer 
	| float_expr
	| string_expr
	| map
	| list
	;

integer
	: Integer -> ^(INTEGER Integer)
	;
	
Integer
	: '-'? DecDigit+
	| ('0' 'x' HexDigit+)
	;
	
float_expr
	: Float -> ^(FLOAT Float)
	;
	
Float
	: '-'? DecDigit+ '.' DecDigit* Exponent?
	;
	
fragment Exponent
	: ('e' | 'E') ('-' | '+')? DecDigit+
	;

string_expr	
	: QuotedString -> ^(QUOTED_STRING QuotedString) 
//	| UnQuotedString -> ^(UNQUOTED_STRING UnQuotedString)
	;

QuotedString
	: '"' UnQuotedStringChars* '"'
	;
	
//UnQuotedString
//	: UnQuotedStringChars*
//	;

boolean 
	: Bool -> ^(BOOL Bool)
	;

Bool
	: 'true' | 'false'
	;
				
map
	: '{' map_pair (',' map_pair)* '}'
		-> '{' map_pair+ '}'
	;
	
map_pair
	: string_expr ':' value
		-> ^(':' string_expr value)
	;
	
list 
	: '[' value (',' value)* ']'
		-> '[' value+ ']'
	;
	
fragment UnQuotedStringChars
	: (EscapeSequence | ~('\u0000'..'\u001f' | '\\' | '\"' ) )
	;
	
fragment EscapeSequence
	: '\\' (UnicodeEscape | 'b'|'t'|'n'|'f'|'r'|'\"'|'\''|'\\')
	;
	
fragment UnicodeEscape
	: 'u' HexDigit HexDigit HexDigit HexDigit
	;

fragment DecDigit
	: '0'..'9'
	;	

fragment HexDigit
	: DecDigit | 'A'..'F' | 'a'..'f'
	;
// this is good, but I don't need it yet
//newline : ( '\r\n' | '\n' | '\r' );
	
