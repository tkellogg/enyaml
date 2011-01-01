grammar Yaml;

options {
	language = 'CSharp2';
	output=AST;
}

tokens {
	QUOTED_STRING; UNQUOTED_STRING; INTEGER; FLOAT; BOOL;
	DOUBLE_QUOTE; SINGLE_QUOTE; MAP; LIST;
	
	// block-related tokens
	INDENT; DEDENT; DENT;
}

@parser::namespace { enyaml.parser }
@lexer::namespace { enyaml.parser }

// Top level is considered a block as well, and as such the lexer needs
// to emit the correct symbols for the parser to recognize it as such.
@lexer::before {
	Emit(INDENT);
}
@lexer::after {
	Emit(DEDENT);
}

// This rule generates INDENT & DEDENT tokens for the parser
INDENTATION
		// Only run rule if beginning of line
	: {CharPositionInLine == 0}?=> 
		' '+
		{ EmitIndentationTokens($text); }
	;
	
// list item	
LI : '-' ;
// map item
MI : ':' ;
NULL : 'null';
Bool : 'true' | 'false'	;
NEWLINE
	: '\r\n' | '\n' | '\r'
	;
WS
	: ' ' | '\t'
	;
COMMA
	:	',' ;
QUOT
	:	'"' ;
LBRACKET 
	:	'[' ;
RBRACKET 
	:	']' ;
LBRACE
	:	'{' ;
RBRACE
	:	'}' ;
Integer
	: '-'? DecDigit+
	| ('0' 'x' HexDigit+)
	;
		
Float
	: '-'? DecDigit+ '.' DecDigit* Exponent?
	;
		
UnQuotedString
	: ~(DecDigit | MI | LBRACKET | LBRACE | RBRACE | RBRACKET | LI | NEWLINE | WS | COMMA | QUOT) 
			FreeChars 
	;

value
	: null_expr
	| boolean
	| integer 
	| float_expr
	| string_expr
	| map
	| list
	;
	
boolean 
	: Bool -> ^(BOOL Bool)
	;
	
null_expr
	: NULL
	;

integer
	: Integer -> ^(INTEGER Integer)
	;
	
	
float_expr
	: Float -> ^(FLOAT Float)
	;

string_expr	
	: QUOT QuotedStringChar* QUOT
		-> ^(QUOTED_STRING QuotedStringChar*) 
	| QUOT UnQuotedString QUOT
		-> ^(QUOTED_STRING UnQuotedString) 
	| QUOT Integer QUOT
		-> ^(QUOTED_STRING Integer) 
	| UnQuotedString -> ^(UNQUOTED_STRING UnQuotedString)
	;
				
flow_map
@init {
	flowLvl++;
	BlockLevel++;
}
	: LBRACE fskip* map_pair fskip* (COMMA fskip* map_pair fskip* )* RBRACE
		-> ^(MAP map_pair+)
	;
finally {
	flowLvl--;
	BlockLevel--;
}
	
block_map
@init {
	BlockLevel++;
}
	: INDENT DENT map_pair (NEWLINE DENT map_pair)* DEDENT
		-> ^(MAP map_pair+)
	;
finally {
	BlockLevel--;
}
		
map
	: {!IsInFlow}?=> block_map
	| flow_map
	;
	
map_pair
	: string_expr fskip* MI fskip* value
		-> ^(MI string_expr value)
	;
		
list
	: {!IsInFlow}?=> block_list
	| flow_list
	;
	
// tokens to skip while in flow style
fskip
	: NEWLINE | INDENTATION | INDENT | DEDENT | WS
	;
	
flow_list 
@init {
	flowLvl++;
	BlockLevel++;
}
	: LBRACKET fskip* value fskip* (COMMA fskip* value fskip*)* RBRACKET
		-> ^(LIST value+ )
	;
finally {
	flowLvl--;
	BlockLevel--;
}
	
block_list
@init {
	BlockLevel++;
}
	: INDENTATION INDENT block_list_item+ INDENTATION DEDENT
		-> ^(LIST block_list_item+)
	| {flowLvl == 0}? block_list_item+
		-> ^(LIST block_list_item+)
	;
finally {
	BlockLevel--;
}
	
block_list_item
scope {
	int lvl;
}
@init {
	$block_list_item::lvl = BlockLevel;
}
	: {$block_list_item::lvl == BlockLevel}? LI WS* value NEWLINE
		-> value
	;
		
fragment Exponent
	: ('e' | 'E') ('-' | '+')? DecDigit+
	;
	
fragment QuotedStringChar
	: (EscapeSequence | ~('\u0000'..'\u001f' | '\\' | '\"' ) )
	;
	
fragment FreeChars
	: (EscapeSequence | ~('\u0000'..'\u001f' | '\\' | QUOT | NEWLINE | LI | MI | COMMA | LBRACE | LBRACKET | RBRACKET | RBRACE))*
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
	
