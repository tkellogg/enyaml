// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g 2011-01-02 20:27:46

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


namespace  enyaml.parser 
{
public partial class YamlLexer : Lexer {
    public const int INTEGER = 6;
    public const int Bool = 20;
    public const int RBRACE = 28;
    public const int FreeChars = 34;
    public const int DOUBLE_QUOTE = 9;
    public const int NULL = 19;
    public const int LBRACE = 27;
    public const int QUOT = 24;
    public const int BOOL = 8;
    public const int QuotedStringChar = 36;
    public const int Exponent = 32;
    public const int UnQuotedString = 35;
    public const int FLOAT = 7;
    public const int DEDENT = 14;
    public const int MI = 18;
    public const int EOF = -1;
    public const int LIST = 12;
    public const int HexDigit = 30;
    public const int DecDigit = 29;
    public const int INDENT = 13;
    public const int LBRACKET = 25;
    public const int Float = 33;
    public const int SINGLE_QUOTE = 10;
    public const int WS = 22;
    public const int NEWLINE = 21;
    public const int DENT = 15;
    public const int COMMA = 23;
    public const int UnicodeEscape = 38;
    public const int MAP = 11;
    public const int QUOTED_STRING = 4;
    public const int RBRACKET = 26;
    public const int LI = 17;
    public const int UNQUOTED_STRING = 5;
    public const int EscapeSequence = 37;
    public const int Integer = 31;
    public const int INDENTATION = 16;

    // delegates
    // delegators

    public YamlLexer() 
    {
		InitializeCyclicDFAs();
    }
    public YamlLexer(ICharStream input)
		: this(input, null) {
    }
    public YamlLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g";} 
    }

    // $ANTLR start "INDENTATION"
    public void mINDENTATION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INDENTATION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:31:2: ({...}? => ( ' ' )+ )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:31:4: {...}? => ( ' ' )+
            {
            	if ( !((CharPositionInLine == 0)) ) 
            	{
            	    throw new FailedPredicateException(input, "INDENTATION", "CharPositionInLine == 0");
            	}
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:32:3: ( ' ' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == ' ') )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:32:3: ' '
            			    {
            			    	Match(' '); 

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	 EmitIndentationTokens(Text); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INDENTATION"

    // $ANTLR start "LI"
    public void mLI() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LI;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:37:4: ( '-' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:37:6: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LI"

    // $ANTLR start "MI"
    public void mMI() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MI;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:39:4: ( ':' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:39:6: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MI"

    // $ANTLR start "NULL"
    public void mNULL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NULL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:40:6: ( 'null' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:40:8: 'null'
            {
            	Match("null"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NULL"

    // $ANTLR start "Bool"
    public void mBool() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Bool;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:42:2: ( 'true' | 'false' )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == 't') )
            {
                alt2 = 1;
            }
            else if ( (LA2_0 == 'f') )
            {
                alt2 = 2;
            }
            else 
            {
                NoViableAltException nvae_d2s0 =
                    new NoViableAltException("", 2, 0, input);

                throw nvae_d2s0;
            }
            switch (alt2) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:42:4: 'true'
                    {
                    	Match("true"); 


                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:42:13: 'false'
                    {
                    	Match("false"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Bool"

    // $ANTLR start "NEWLINE"
    public void mNEWLINE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEWLINE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:45:2: ( '\\r\\n' | '\\n' | '\\r' )
            int alt3 = 3;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == '\r') )
            {
                int LA3_1 = input.LA(2);

                if ( (LA3_1 == '\n') )
                {
                    alt3 = 1;
                }
                else 
                {
                    alt3 = 3;}
            }
            else if ( (LA3_0 == '\n') )
            {
                alt3 = 2;
            }
            else 
            {
                NoViableAltException nvae_d3s0 =
                    new NoViableAltException("", 3, 0, input);

                throw nvae_d3s0;
            }
            switch (alt3) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:45:4: '\\r\\n'
                    {
                    	Match("\r\n"); 


                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:45:13: '\\n'
                    {
                    	Match('\n'); 

                    }
                    break;
                case 3 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:45:20: '\\r'
                    {
                    	Match('\r'); 

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEWLINE"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:48:2: ( ' ' | '\\t' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:
            {
            	if ( input.LA(1) == '\t' || input.LA(1) == ' ' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "COMMA"
    public void mCOMMA() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMA;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:51:2: ( ',' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:51:4: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMA"

    // $ANTLR start "QUOT"
    public void mQUOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = QUOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:53:2: ( '\"' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:53:4: '\"'
            {
            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "QUOT"

    // $ANTLR start "LBRACKET"
    public void mLBRACKET() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LBRACKET;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:55:2: ( '[' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:55:4: '['
            {
            	Match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LBRACKET"

    // $ANTLR start "RBRACKET"
    public void mRBRACKET() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RBRACKET;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:57:2: ( ']' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:57:4: ']'
            {
            	Match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RBRACKET"

    // $ANTLR start "LBRACE"
    public void mLBRACE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LBRACE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:59:2: ( '{' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:59:4: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LBRACE"

    // $ANTLR start "RBRACE"
    public void mRBRACE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RBRACE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:61:2: ( '}' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:61:4: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RBRACE"

    // $ANTLR start "Integer"
    public void mInteger() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Integer;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:63:2: ( ( '-' )? ( DecDigit )+ | ( '0' 'x' ( HexDigit )+ ) )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0 == '-' || (LA7_0 >= '1' && LA7_0 <= '9')) )
            {
                alt7 = 1;
            }
            else if ( (LA7_0 == '0') )
            {
                int LA7_2 = input.LA(2);

                if ( (LA7_2 == 'x') )
                {
                    alt7 = 2;
                }
                else 
                {
                    alt7 = 1;}
            }
            else 
            {
                NoViableAltException nvae_d7s0 =
                    new NoViableAltException("", 7, 0, input);

                throw nvae_d7s0;
            }
            switch (alt7) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:63:4: ( '-' )? ( DecDigit )+
                    {
                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:63:4: ( '-' )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == '-') )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:63:4: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:63:9: ( DecDigit )+
                    	int cnt5 = 0;
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( ((LA5_0 >= '0' && LA5_0 <= '9')) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:63:9: DecDigit
                    			    {
                    			    	mDecDigit(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt5 >= 1 ) goto loop5;
                    		            EarlyExitException eee5 =
                    		                new EarlyExitException(5, input);
                    		            throw eee5;
                    	    }
                    	    cnt5++;
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whining that label 'loop5' has no statements


                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:64:4: ( '0' 'x' ( HexDigit )+ )
                    {
                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:64:4: ( '0' 'x' ( HexDigit )+ )
                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:64:5: '0' 'x' ( HexDigit )+
                    	{
                    		Match('0'); 
                    		Match('x'); 
                    		// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:64:13: ( HexDigit )+
                    		int cnt6 = 0;
                    		do 
                    		{
                    		    int alt6 = 2;
                    		    int LA6_0 = input.LA(1);

                    		    if ( ((LA6_0 >= '0' && LA6_0 <= '9') || (LA6_0 >= 'A' && LA6_0 <= 'F') || (LA6_0 >= 'a' && LA6_0 <= 'f')) )
                    		    {
                    		        alt6 = 1;
                    		    }


                    		    switch (alt6) 
                    			{
                    				case 1 :
                    				    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:64:13: HexDigit
                    				    {
                    				    	mHexDigit(); 

                    				    }
                    				    break;

                    				default:
                    				    if ( cnt6 >= 1 ) goto loop6;
                    			            EarlyExitException eee6 =
                    			                new EarlyExitException(6, input);
                    			            throw eee6;
                    		    }
                    		    cnt6++;
                    		} while (true);

                    		loop6:
                    			;	// Stops C# compiler whining that label 'loop6' has no statements


                    	}


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Integer"

    // $ANTLR start "Float"
    public void mFloat() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Float;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:68:2: ( ( '-' )? ( DecDigit )+ '.' ( DecDigit )* ( Exponent )? )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:68:4: ( '-' )? ( DecDigit )+ '.' ( DecDigit )* ( Exponent )?
            {
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:68:4: ( '-' )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == '-') )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:68:4: '-'
            	        {
            	        	Match('-'); 

            	        }
            	        break;

            	}

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:68:9: ( DecDigit )+
            	int cnt9 = 0;
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= '0' && LA9_0 <= '9')) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:68:9: DecDigit
            			    {
            			    	mDecDigit(); 

            			    }
            			    break;

            			default:
            			    if ( cnt9 >= 1 ) goto loop9;
            		            EarlyExitException eee9 =
            		                new EarlyExitException(9, input);
            		            throw eee9;
            	    }
            	    cnt9++;
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	Match('.'); 
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:68:23: ( DecDigit )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= '0' && LA10_0 <= '9')) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:68:23: DecDigit
            			    {
            			    	mDecDigit(); 

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:68:33: ( Exponent )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == 'E' || LA11_0 == 'e') )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:68:33: Exponent
            	        {
            	        	mExponent(); 

            	        }
            	        break;

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Float"

    // $ANTLR start "UnQuotedString"
    public void mUnQuotedString() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UnQuotedString;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:72:2: (~ ( DecDigit | MI | LBRACKET | LBRACE | RBRACE | RBRACKET | LI | NEWLINE | WS | COMMA | QUOT ) FreeChars )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:72:4: ~ ( DecDigit | MI | LBRACKET | LBRACE | RBRACE | RBRACKET | LI | NEWLINE | WS | COMMA | QUOT ) FreeChars
            {
            	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\b') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\u001F') || input.LA(1) == '!' || (input.LA(1) >= '#' && input.LA(1) <= '+') || (input.LA(1) >= '.' && input.LA(1) <= '/') || (input.LA(1) >= ';' && input.LA(1) <= 'Z') || input.LA(1) == '\\' || (input.LA(1) >= '^' && input.LA(1) <= 'z') || input.LA(1) == '|' || (input.LA(1) >= '~' && input.LA(1) <= '\uFFFF') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	mFreeChars(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UnQuotedString"

    // $ANTLR start "Exponent"
    public void mExponent() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:206:2: ( ( 'e' | 'E' ) ( '-' | '+' )? ( DecDigit )+ )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:206:4: ( 'e' | 'E' ) ( '-' | '+' )? ( DecDigit )+
            {
            	if ( input.LA(1) == 'E' || input.LA(1) == 'e' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:206:16: ( '-' | '+' )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == '+' || LA12_0 == '-') )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:
            	        {
            	        	if ( input.LA(1) == '+' || input.LA(1) == '-' ) 
            	        	{
            	        	    input.Consume();

            	        	}
            	        	else 
            	        	{
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    Recover(mse);
            	        	    throw mse;}


            	        }
            	        break;

            	}

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:206:29: ( DecDigit )+
            	int cnt13 = 0;
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( ((LA13_0 >= '0' && LA13_0 <= '9')) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:206:29: DecDigit
            			    {
            			    	mDecDigit(); 

            			    }
            			    break;

            			default:
            			    if ( cnt13 >= 1 ) goto loop13;
            		            EarlyExitException eee13 =
            		                new EarlyExitException(13, input);
            		            throw eee13;
            	    }
            	    cnt13++;
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Exponent"

    // $ANTLR start "QuotedStringChar"
    public void mQuotedStringChar() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:210:2: ( ( EscapeSequence | ~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\\"' ) ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:210:4: ( EscapeSequence | ~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\\"' ) )
            {
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:210:4: ( EscapeSequence | ~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\\"' ) )
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == '\\') )
            	{
            	    alt14 = 1;
            	}
            	else if ( ((LA14_0 >= ' ' && LA14_0 <= '!') || (LA14_0 >= '#' && LA14_0 <= '[') || (LA14_0 >= ']' && LA14_0 <= '\uFFFF')) )
            	{
            	    alt14 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d14s0 =
            	        new NoViableAltException("", 14, 0, input);

            	    throw nvae_d14s0;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:210:5: EscapeSequence
            	        {
            	        	mEscapeSequence(); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:210:22: ~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\\"' )
            	        {
            	        	if ( (input.LA(1) >= ' ' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFF') ) 
            	        	{
            	        	    input.Consume();

            	        	}
            	        	else 
            	        	{
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    Recover(mse);
            	        	    throw mse;}


            	        }
            	        break;

            	}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "QuotedStringChar"

    // $ANTLR start "FreeChars"
    public void mFreeChars() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:214:2: ( ( EscapeSequence | ~ ( '\\u0000' .. '\\u001f' | '\\\\' | QUOT | NEWLINE | LI | MI | COMMA | LBRACE | LBRACKET | RBRACKET | RBRACE ) )* )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:214:4: ( EscapeSequence | ~ ( '\\u0000' .. '\\u001f' | '\\\\' | QUOT | NEWLINE | LI | MI | COMMA | LBRACE | LBRACKET | RBRACKET | RBRACE ) )*
            {
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:214:4: ( EscapeSequence | ~ ( '\\u0000' .. '\\u001f' | '\\\\' | QUOT | NEWLINE | LI | MI | COMMA | LBRACE | LBRACKET | RBRACKET | RBRACE ) )*
            	do 
            	{
            	    int alt15 = 3;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0 == '\\') )
            	    {
            	        alt15 = 1;
            	    }
            	    else if ( ((LA15_0 >= ' ' && LA15_0 <= '!') || (LA15_0 >= '#' && LA15_0 <= '+') || (LA15_0 >= '.' && LA15_0 <= '9') || (LA15_0 >= ';' && LA15_0 <= 'Z') || (LA15_0 >= '^' && LA15_0 <= 'z') || LA15_0 == '|' || (LA15_0 >= '~' && LA15_0 <= '\uFFFF')) )
            	    {
            	        alt15 = 2;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:214:5: EscapeSequence
            			    {
            			    	mEscapeSequence(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:214:22: ~ ( '\\u0000' .. '\\u001f' | '\\\\' | QUOT | NEWLINE | LI | MI | COMMA | LBRACE | LBRACKET | RBRACKET | RBRACE )
            			    {
            			    	if ( (input.LA(1) >= ' ' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '+') || (input.LA(1) >= '.' && input.LA(1) <= '9') || (input.LA(1) >= ';' && input.LA(1) <= 'Z') || (input.LA(1) >= '^' && input.LA(1) <= 'z') || input.LA(1) == '|' || (input.LA(1) >= '~' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "FreeChars"

    // $ANTLR start "EscapeSequence"
    public void mEscapeSequence() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:218:2: ( '\\\\' ( UnicodeEscape | 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:218:4: '\\\\' ( UnicodeEscape | 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
            {
            	Match('\\'); 
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:218:9: ( UnicodeEscape | 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
            	int alt16 = 9;
            	switch ( input.LA(1) ) 
            	{
            	case 'u':
            		{
            	    alt16 = 1;
            	    }
            	    break;
            	case 'b':
            		{
            	    alt16 = 2;
            	    }
            	    break;
            	case 't':
            		{
            	    alt16 = 3;
            	    }
            	    break;
            	case 'n':
            		{
            	    alt16 = 4;
            	    }
            	    break;
            	case 'f':
            		{
            	    alt16 = 5;
            	    }
            	    break;
            	case 'r':
            		{
            	    alt16 = 6;
            	    }
            	    break;
            	case '\"':
            		{
            	    alt16 = 7;
            	    }
            	    break;
            	case '\'':
            		{
            	    alt16 = 8;
            	    }
            	    break;
            	case '\\':
            		{
            	    alt16 = 9;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d16s0 =
            		        new NoViableAltException("", 16, 0, input);

            		    throw nvae_d16s0;
            	}

            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:218:10: UnicodeEscape
            	        {
            	        	mUnicodeEscape(); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:218:26: 'b'
            	        {
            	        	Match('b'); 

            	        }
            	        break;
            	    case 3 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:218:30: 't'
            	        {
            	        	Match('t'); 

            	        }
            	        break;
            	    case 4 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:218:34: 'n'
            	        {
            	        	Match('n'); 

            	        }
            	        break;
            	    case 5 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:218:38: 'f'
            	        {
            	        	Match('f'); 

            	        }
            	        break;
            	    case 6 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:218:42: 'r'
            	        {
            	        	Match('r'); 

            	        }
            	        break;
            	    case 7 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:218:46: '\\\"'
            	        {
            	        	Match('\"'); 

            	        }
            	        break;
            	    case 8 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:218:51: '\\''
            	        {
            	        	Match('\''); 

            	        }
            	        break;
            	    case 9 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:218:56: '\\\\'
            	        {
            	        	Match('\\'); 

            	        }
            	        break;

            	}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "EscapeSequence"

    // $ANTLR start "UnicodeEscape"
    public void mUnicodeEscape() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:222:2: ( 'u' HexDigit HexDigit HexDigit HexDigit )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:222:4: 'u' HexDigit HexDigit HexDigit HexDigit
            {
            	Match('u'); 
            	mHexDigit(); 
            	mHexDigit(); 
            	mHexDigit(); 
            	mHexDigit(); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "UnicodeEscape"

    // $ANTLR start "DecDigit"
    public void mDecDigit() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:226:2: ( '0' .. '9' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:226:4: '0' .. '9'
            {
            	MatchRange('0','9'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "DecDigit"

    // $ANTLR start "HexDigit"
    public void mHexDigit() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:230:2: ( DecDigit | 'A' .. 'F' | 'a' .. 'f' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:
            {
            	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'F') || (input.LA(1) >= 'a' && input.LA(1) <= 'f') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "HexDigit"

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:8: ( INDENTATION | LI | MI | NULL | Bool | NEWLINE | WS | COMMA | QUOT | LBRACKET | RBRACKET | LBRACE | RBRACE | Integer | Float | UnQuotedString )
        int alt17 = 16;
        alt17 = dfa17.Predict(input);
        switch (alt17) 
        {
            case 1 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:10: INDENTATION
                {
                	mINDENTATION(); 

                }
                break;
            case 2 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:22: LI
                {
                	mLI(); 

                }
                break;
            case 3 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:25: MI
                {
                	mMI(); 

                }
                break;
            case 4 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:28: NULL
                {
                	mNULL(); 

                }
                break;
            case 5 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:33: Bool
                {
                	mBool(); 

                }
                break;
            case 6 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:38: NEWLINE
                {
                	mNEWLINE(); 

                }
                break;
            case 7 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:46: WS
                {
                	mWS(); 

                }
                break;
            case 8 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:49: COMMA
                {
                	mCOMMA(); 

                }
                break;
            case 9 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:55: QUOT
                {
                	mQUOT(); 

                }
                break;
            case 10 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:60: LBRACKET
                {
                	mLBRACKET(); 

                }
                break;
            case 11 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:69: RBRACKET
                {
                	mRBRACKET(); 

                }
                break;
            case 12 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:78: LBRACE
                {
                	mLBRACE(); 

                }
                break;
            case 13 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:85: RBRACE
                {
                	mRBRACE(); 

                }
                break;
            case 14 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:92: Integer
                {
                	mInteger(); 

                }
                break;
            case 15 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:100: Float
                {
                	mFloat(); 

                }
                break;
            case 16 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:106: UnQuotedString
                {
                	mUnQuotedString(); 

                }
                break;

        }

    }


    protected DFA17 dfa17;
	private void InitializeCyclicDFAs()
	{
	    this.dfa17 = new DFA17(this);
	    this.dfa17.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA17_SpecialStateTransition);
	}

    const string DFA17_eotS =
        "\x01\uffff\x01\x12\x01\x14\x01\uffff\x03\x11\x08\uffff\x02\x18"+
        "\x04\uffff\x03\x11\x02\uffff\x03\x11\x01\x20\x01\x21\x01\x11\x02"+
        "\uffff\x01\x21";
    const string DFA17_eofS =
        "\x23\uffff";
    const string DFA17_minS =
        "\x01\x00\x01\x20\x01\x30\x01\uffff\x01\x75\x01\x72\x01\x61\x08"+
        "\uffff\x02\x2e\x01\uffff\x01\x00\x02\uffff\x01\x6c\x01\x75\x01\x6c"+
        "\x02\uffff\x01\x6c\x01\x65\x01\x73\x02\x20\x01\x65\x02\uffff\x01"+
        "\x20";
    const string DFA17_maxS =
        "\x01\uffff\x01\x20\x01\x39\x01\uffff\x01\x75\x01\x72\x01\x61\x08"+
        "\uffff\x02\x39\x01\uffff\x01\x00\x02\uffff\x01\x6c\x01\x75\x01\x6c"+
        "\x02\uffff\x01\x6c\x01\x65\x01\x73\x02\uffff\x01\x65\x02\uffff\x01"+
        "\uffff";
    const string DFA17_acceptS =
        "\x03\uffff\x01\x03\x03\uffff\x01\x06\x01\x07\x01\x08\x01\x09\x01"+
        "\x0a\x01\x0b\x01\x0c\x01\x0d\x02\uffff\x01\x10\x01\uffff\x01\x01"+
        "\x01\x02\x03\uffff\x01\x0e\x01\x0f\x06\uffff\x01\x04\x01\x05\x01"+
        "\uffff";
    const string DFA17_specialS =
        "\x01\x00\x01\x01\x10\uffff\x01\x02\x10\uffff}>";
    static readonly string[] DFA17_transitionS = {
            "\x09\x11\x01\x08\x01\x07\x02\x11\x01\x07\x12\x11\x01\x01\x01"+
            "\x11\x01\x0a\x09\x11\x01\x09\x01\x02\x02\x11\x01\x0f\x09\x10"+
            "\x01\x03\x20\x11\x01\x0b\x01\x11\x01\x0c\x08\x11\x01\x06\x07"+
            "\x11\x01\x04\x05\x11\x01\x05\x06\x11\x01\x0d\x01\x11\x01\x0e"+
            "\uff82\x11",
            "\x01\x13",
            "\x0a\x10",
            "",
            "\x01\x15",
            "\x01\x16",
            "\x01\x17",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x19\x01\uffff\x0a\x10",
            "\x01\x19\x01\uffff\x0a\x10",
            "",
            "\x01\uffff",
            "",
            "",
            "\x01\x1a",
            "\x01\x1b",
            "\x01\x1c",
            "",
            "",
            "\x01\x1d",
            "\x01\x1e",
            "\x01\x1f",
            "\x02\x11\x01\uffff\x09\x11\x02\uffff\x0c\x11\x01\uffff\x20"+
            "\x11\x01\uffff\x01\x11\x01\uffff\x1d\x11\x01\uffff\x01\x11\x01"+
            "\uffff\uff82\x11",
            "\x02\x11\x01\uffff\x09\x11\x02\uffff\x0c\x11\x01\uffff\x20"+
            "\x11\x01\uffff\x01\x11\x01\uffff\x1d\x11\x01\uffff\x01\x11\x01"+
            "\uffff\uff82\x11",
            "\x01\x22",
            "",
            "",
            "\x02\x11\x01\uffff\x09\x11\x02\uffff\x0c\x11\x01\uffff\x20"+
            "\x11\x01\uffff\x01\x11\x01\uffff\x1d\x11\x01\uffff\x01\x11\x01"+
            "\uffff\uff82\x11"
    };

    static readonly short[] DFA17_eot = DFA.UnpackEncodedString(DFA17_eotS);
    static readonly short[] DFA17_eof = DFA.UnpackEncodedString(DFA17_eofS);
    static readonly char[] DFA17_min = DFA.UnpackEncodedStringToUnsignedChars(DFA17_minS);
    static readonly char[] DFA17_max = DFA.UnpackEncodedStringToUnsignedChars(DFA17_maxS);
    static readonly short[] DFA17_accept = DFA.UnpackEncodedString(DFA17_acceptS);
    static readonly short[] DFA17_special = DFA.UnpackEncodedString(DFA17_specialS);
    static readonly short[][] DFA17_transition = DFA.UnpackEncodedStringArray(DFA17_transitionS);

    protected class DFA17 : DFA
    {
        public DFA17(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 17;
            this.eot = DFA17_eot;
            this.eof = DFA17_eof;
            this.min = DFA17_min;
            this.max = DFA17_max;
            this.accept = DFA17_accept;
            this.special = DFA17_special;
            this.transition = DFA17_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( INDENTATION | LI | MI | NULL | Bool | NEWLINE | WS | COMMA | QUOT | LBRACKET | RBRACKET | LBRACE | RBRACE | Integer | Float | UnQuotedString );"; }
        }

    }


    protected internal int DFA17_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA17_0 = input.LA(1);

                   	s = -1;
                   	if ( (LA17_0 == ' ') ) { s = 1; }

                   	else if ( (LA17_0 == '-') ) { s = 2; }

                   	else if ( (LA17_0 == ':') ) { s = 3; }

                   	else if ( (LA17_0 == 'n') ) { s = 4; }

                   	else if ( (LA17_0 == 't') ) { s = 5; }

                   	else if ( (LA17_0 == 'f') ) { s = 6; }

                   	else if ( (LA17_0 == '\n' || LA17_0 == '\r') ) { s = 7; }

                   	else if ( (LA17_0 == '\t') ) { s = 8; }

                   	else if ( (LA17_0 == ',') ) { s = 9; }

                   	else if ( (LA17_0 == '\"') ) { s = 10; }

                   	else if ( (LA17_0 == '[') ) { s = 11; }

                   	else if ( (LA17_0 == ']') ) { s = 12; }

                   	else if ( (LA17_0 == '{') ) { s = 13; }

                   	else if ( (LA17_0 == '}') ) { s = 14; }

                   	else if ( (LA17_0 == '0') ) { s = 15; }

                   	else if ( ((LA17_0 >= '1' && LA17_0 <= '9')) ) { s = 16; }

                   	else if ( ((LA17_0 >= '\u0000' && LA17_0 <= '\b') || (LA17_0 >= '\u000B' && LA17_0 <= '\f') || (LA17_0 >= '\u000E' && LA17_0 <= '\u001F') || LA17_0 == '!' || (LA17_0 >= '#' && LA17_0 <= '+') || (LA17_0 >= '.' && LA17_0 <= '/') || (LA17_0 >= ';' && LA17_0 <= 'Z') || LA17_0 == '\\' || (LA17_0 >= '^' && LA17_0 <= 'e') || (LA17_0 >= 'g' && LA17_0 <= 'm') || (LA17_0 >= 'o' && LA17_0 <= 's') || (LA17_0 >= 'u' && LA17_0 <= 'z') || LA17_0 == '|' || (LA17_0 >= '~' && LA17_0 <= '\uFFFF')) ) { s = 17; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA17_1 = input.LA(1);

                   	 
                   	int index17_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA17_1 == ' ') && ((CharPositionInLine == 0)) ) { s = 19; }

                   	else s = 18;

                   	 
                   	input.Seek(index17_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA17_18 = input.LA(1);

                   	 
                   	int index17_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( ((CharPositionInLine == 0)) ) { s = 19; }

                   	else if ( (true) ) { s = 8; }

                   	 
                   	input.Seek(index17_18);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae17 =
            new NoViableAltException(dfa.Description, 17, _s, input);
        dfa.Error(nvae17);
        throw nvae17;
    }
 
    
}
}