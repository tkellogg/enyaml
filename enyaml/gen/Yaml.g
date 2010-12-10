grammar Yaml;

options {
	language = 'CSharp2';
	output=AST;
}

tokens {
	QUOTED_STRING;
	DOUBLE_QUOTE; SINGLE_QUOTE; TRUE; FALSE; NULL;
}

@namespace { enyaml.parser }

quoted_string	: QuotedString
	-> ^(QUOTED_STRING QuotedString);

QuotedString	
	: '"' (EscapeSequence | ~('\u0000'..'\u001f' | '\\' | '\"' ) )* '"'
	;
	
fragment EscapeSequence
	: '\\' (UnicodeEscape | 'b'|'t'|'n'|'f'|'r'|'\"'|'\''|'\\')
	;
	
fragment UnicodeEscape
	: 'u' HexDigit HexDigit HexDigit HexDigit
	;
	
fragment HexDigit
	: '0'..'9' | 'A'..'F' | 'a'..'f'
	;
// this is good, but I don't need it yet
//newline : ( '\r\n' | '\n' | '\r' );
	
