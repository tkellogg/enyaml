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

Bool
	: 'true' | 'false'
	;
	
null_expr
	: NULL
	;
	
NULL : 'null';

integer
	: Integer -> ^(INTEGER Integer)
	;
	
Integer
	: '-'? DecDigit+
	| ('0' 'x' HexDigit+)
	;
	
LI
	: '-'
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
	| UnQuotedString -> ^(UNQUOTED_STRING UnQuotedString)
	;

QuotedString
	: '"' UnQuotedStringChars* '"'
	;
		
UnQuotedString
	: ~(DecDigit | ':' | '[' | '{' | '}' | ']' | LI | NEWLINE | ' ' | '\t' | ',') 
			FreeChars 
	;
				
flow_map
@init {
	flowLvl++;
	BlockLevel++;
}
	: '{' fskip* map_pair fskip* (',' fskip* map_pair fskip* )* '}'
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
	: string_expr fskip* ':' fskip* value
		-> ^(':' string_expr value)
	;
		
list
	: {!IsInFlow}?=> block_list
	| flow_list
	;
	
// tokens to skip while in flow style
fskip
	: NEWLINE | INDENTATION | INDENT | DEDENT
	;
	
flow_list 
@init {
	flowLvl++;
	BlockLevel++;
}
	: '[' fskip* value fskip* (',' fskip* value fskip*)* ']'
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
	: {$block_list_item::lvl == BlockLevel}? LI value NEWLINE
		-> value
	;
	
NEWLINE
	: '\r\n' | '\n' | '\r'
	;
	
fragment UnQuotedStringChars 
	: (EscapeSequence | ~('\u0000'..'\u001f' | '\\' | '\"' ) )
	;
	
fragment FreeChars
	: (EscapeSequence | ~('\u0000'..'\u001f' | '\\' | '\"' | NEWLINE | LI | ':' | ',' | '{' | '[' | ']' | '}'))*
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
	
