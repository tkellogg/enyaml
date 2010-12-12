grammar Yaml;

options {
	language = 'CSharp2';
	output=AST;
}

tokens {
	QUOTED_STRING; UNQUOTED_STRING; INTEGER; FLOAT;
	DOUBLE_QUOTE; SINGLE_QUOTE; TRUE; FALSE; NULL;
}

@namespace { enyaml.parser }

value
	: integer 
	| float_expr
	| string_expr;

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
	: '-'? DecDigit+ '.' DecDigit*
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
	
