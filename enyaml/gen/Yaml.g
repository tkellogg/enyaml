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

@namespace { enyaml.parser }
@lexer::namespace { enyaml.parser }

@lexer::members {
	
	///<summary>Tracks the current indentation level<summary>
	protected int Indentation { get; set; }

	/// <summary>Tracks how many spaces an indent is</summary>
	internal int indentSize = 0;
	
	///<summary>Gets the indentation level represented by spaces</summary>
	internal int GetIndentationSize(string spaces) {
		int ret = 0;
		if (indentSize == 0 && spaces.Length > 0) {
			// This is the first time we're looking for indents
			indentSize = spaces.Length;
			ret = 1;
		} else if (indentSize > 0) {
			if (spaces.Length % indentSize != 0)
				throw new Exception("Bad indentation");
			ret = spaces.Length / indentSize;
		}
		return ret;
	}
}

@members {
	protected int flowLvl = 0;
	protected bool IsInFlow{ get { return flowLvl > 0; } }
}

// Top level is considered a block as well, and as such the lexer needs
// to emit the correct symbols for the parser to recognize it as such.
@lexer::before {
	Emit(INDENT);
}
@lexer::after {
	Emit(DEDENT);
}

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
				
flow_map
@before {
	flowLvl++;
}
@after {
	flowLvl--;
}
	: '{' map_pair (',' map_pair)* '}'
		-> ^(MAP map_pair+)
	;
	
block_map
	: INDENT DENT map_pair (NEWLINE DENT map_pair)* DEDENT
		-> ^(MAP map_pair+)
	;
		
map
	: {!IsInFlow}?=> block_map
	| flow_map
	;
	
map_pair
	: string_expr ':' value
		-> ^(':' string_expr value)
	;
		
list
	: {!IsInFlow}?=> block_list
	| flow_list
	;
	
flow_list 
@before {
	flowLvl++;
}
@after {
	flowLvl--;
}
	: '[' value (',' value)* ']'
		-> ^(LIST value+ )
	;
	
block_list
	: INDENT block_list_item+ DEDENT
		-> ^(LIST block_list_item+)
	;
	
block_list_item
	: LI value NEWLINE
		-> value
	;
	
// This rule generates INDENT & DEDENT tokens for the parser
INDENTATION
		// Only run rule if beginning of line
	: {CharPositionInLine == 0}?=> 
		' '+
		{ 
			int size = GetIndentationSize($text);
			if (size == Indentation + 1) {
				Emit(new CommonToken(INDENT));
				Emit(new CommonToken(DENT));
			}
//			else if (size == Indentation)
//				Emit (new CommonToken(DENT));
			else if (size < Indentation)
				Emit (new CommonToken(DEDENT));
//			else
//				throw new Exception("Too much indentation");
		}
	;
	
NEWLINE
	: '\r\n' | '\n' | '\r'
	;
	
fragment UnQuotedStringChars
	: (EscapeSequence | ~('\u0000'..'\u001f' | '\\' | '\"' ) )
	;
	
fragment NonColonChars
	: (EscapeSequence | ~(':'))*
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
	
