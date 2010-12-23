// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g 2010-12-23 15:36:29

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
    public const int Bool = 24;
    public const int DOUBLE_QUOTE = 9;
    public const int BOOL = 8;
    public const int Exponent = 21;
    public const int DEDENT = 14;
    public const int FLOAT = 7;
    public const int EOF = -1;
    public const int QuotedString = 22;
    public const int LIST = 12;
    public const int HexDigit = 18;
    public const int DecDigit = 17;
    public const int INDENT = 13;
    public const int Float = 20;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int SINGLE_QUOTE = 10;
    public const int T__32 = 32;
    public const int NonColonChars = 28;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int NEWLINE = 25;
    public const int DENT = 15;
    public const int UnicodeEscape = 29;
    public const int MAP = 11;
    public const int QUOTED_STRING = 4;
    public const int UnQuotedStringChars = 23;
    public const int UNQUOTED_STRING = 5;
    public const int LI = 19;
    public const int EscapeSequence = 27;
    public const int Integer = 16;
    public const int INDENTATION = 26;

    	
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

    // $ANTLR start "T__30"
    public void mT__30() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__30;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:38:7: ( '{' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:38:9: '{'
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
    // $ANTLR end "T__30"

    // $ANTLR start "T__31"
    public void mT__31() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__31;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:39:7: ( ',' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:39:9: ','
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
    // $ANTLR end "T__31"

    // $ANTLR start "T__32"
    public void mT__32() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__32;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:40:7: ( '}' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:40:9: '}'
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
    // $ANTLR end "T__32"

    // $ANTLR start "T__33"
    public void mT__33() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__33;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:41:7: ( ':' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:41:9: ':'
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
    // $ANTLR end "T__33"

    // $ANTLR start "T__34"
    public void mT__34() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__34;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:42:7: ( '[' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:42:9: '['
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
    // $ANTLR end "T__34"

    // $ANTLR start "T__35"
    public void mT__35() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__35;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:43:7: ( ']' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:43:9: ']'
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
    // $ANTLR end "T__35"

    // $ANTLR start "Integer"
    public void mInteger() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Integer;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:71:2: ( ( '-' )? ( DecDigit )+ | ( '0' 'x' ( HexDigit )+ ) )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == '-' || (LA4_0 >= '1' && LA4_0 <= '9')) )
            {
                alt4 = 1;
            }
            else if ( (LA4_0 == '0') )
            {
                int LA4_2 = input.LA(2);

                if ( (LA4_2 == 'x') )
                {
                    alt4 = 2;
                }
                else 
                {
                    alt4 = 1;}
            }
            else 
            {
                NoViableAltException nvae_d4s0 =
                    new NoViableAltException("", 4, 0, input);

                throw nvae_d4s0;
            }
            switch (alt4) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:71:4: ( '-' )? ( DecDigit )+
                    {
                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:71:4: ( '-' )?
                    	int alt1 = 2;
                    	int LA1_0 = input.LA(1);

                    	if ( (LA1_0 == '-') )
                    	{
                    	    alt1 = 1;
                    	}
                    	switch (alt1) 
                    	{
                    	    case 1 :
                    	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:71:4: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:71:9: ( DecDigit )+
                    	int cnt2 = 0;
                    	do 
                    	{
                    	    int alt2 = 2;
                    	    int LA2_0 = input.LA(1);

                    	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
                    	    {
                    	        alt2 = 1;
                    	    }


                    	    switch (alt2) 
                    		{
                    			case 1 :
                    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:71:9: DecDigit
                    			    {
                    			    	mDecDigit(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt2 >= 1 ) goto loop2;
                    		            EarlyExitException eee2 =
                    		                new EarlyExitException(2, input);
                    		            throw eee2;
                    	    }
                    	    cnt2++;
                    	} while (true);

                    	loop2:
                    		;	// Stops C# compiler whining that label 'loop2' has no statements


                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:72:4: ( '0' 'x' ( HexDigit )+ )
                    {
                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:72:4: ( '0' 'x' ( HexDigit )+ )
                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:72:5: '0' 'x' ( HexDigit )+
                    	{
                    		Match('0'); 
                    		Match('x'); 
                    		// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:72:13: ( HexDigit )+
                    		int cnt3 = 0;
                    		do 
                    		{
                    		    int alt3 = 2;
                    		    int LA3_0 = input.LA(1);

                    		    if ( ((LA3_0 >= '0' && LA3_0 <= '9') || (LA3_0 >= 'A' && LA3_0 <= 'F') || (LA3_0 >= 'a' && LA3_0 <= 'f')) )
                    		    {
                    		        alt3 = 1;
                    		    }


                    		    switch (alt3) 
                    			{
                    				case 1 :
                    				    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:72:13: HexDigit
                    				    {
                    				    	mHexDigit(); 

                    				    }
                    				    break;

                    				default:
                    				    if ( cnt3 >= 1 ) goto loop3;
                    			            EarlyExitException eee3 =
                    			                new EarlyExitException(3, input);
                    			            throw eee3;
                    		    }
                    		    cnt3++;
                    		} while (true);

                    		loop3:
                    			;	// Stops C# compiler whining that label 'loop3' has no statements


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

    // $ANTLR start "LI"
    public void mLI() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LI;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:76:2: ( '-' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:76:4: '-'
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

    // $ANTLR start "Float"
    public void mFloat() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Float;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:84:2: ( ( '-' )? ( DecDigit )+ '.' ( DecDigit )* ( Exponent )? )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:84:4: ( '-' )? ( DecDigit )+ '.' ( DecDigit )* ( Exponent )?
            {
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:84:4: ( '-' )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == '-') )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:84:4: '-'
            	        {
            	        	Match('-'); 

            	        }
            	        break;

            	}

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:84:9: ( DecDigit )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= '0' && LA6_0 <= '9')) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:84:9: DecDigit
            			    {
            			    	mDecDigit(); 

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

            	Match('.'); 
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:84:23: ( DecDigit )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( ((LA7_0 >= '0' && LA7_0 <= '9')) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:84:23: DecDigit
            			    {
            			    	mDecDigit(); 

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:84:33: ( Exponent )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == 'E' || LA8_0 == 'e') )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:84:33: Exponent
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

    // $ANTLR start "Exponent"
    public void mExponent() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:88:2: ( ( 'e' | 'E' ) ( '-' | '+' )? ( DecDigit )+ )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:88:4: ( 'e' | 'E' ) ( '-' | '+' )? ( DecDigit )+
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

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:88:16: ( '-' | '+' )?
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == '+' || LA9_0 == '-') )
            	{
            	    alt9 = 1;
            	}
            	switch (alt9) 
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

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:88:29: ( DecDigit )+
            	int cnt10 = 0;
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
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:88:29: DecDigit
            			    {
            			    	mDecDigit(); 

            			    }
            			    break;

            			default:
            			    if ( cnt10 >= 1 ) goto loop10;
            		            EarlyExitException eee10 =
            		                new EarlyExitException(10, input);
            		            throw eee10;
            	    }
            	    cnt10++;
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Exponent"

    // $ANTLR start "QuotedString"
    public void mQuotedString() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = QuotedString;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:2: ( '\"' ( UnQuotedStringChars )* '\"' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:4: '\"' ( UnQuotedStringChars )* '\"'
            {
            	Match('\"'); 
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:8: ( UnQuotedStringChars )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( ((LA11_0 >= ' ' && LA11_0 <= '!') || (LA11_0 >= '#' && LA11_0 <= '\uFFFF')) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:8: UnQuotedStringChars
            			    {
            			    	mUnQuotedStringChars(); 

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "QuotedString"

    // $ANTLR start "Bool"
    public void mBool() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Bool;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:109:2: ( 'true' | 'false' )
            int alt12 = 2;
            int LA12_0 = input.LA(1);

            if ( (LA12_0 == 't') )
            {
                alt12 = 1;
            }
            else if ( (LA12_0 == 'f') )
            {
                alt12 = 2;
            }
            else 
            {
                NoViableAltException nvae_d12s0 =
                    new NoViableAltException("", 12, 0, input);

                throw nvae_d12s0;
            }
            switch (alt12) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:109:4: 'true'
                    {
                    	Match("true"); 


                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:109:13: 'false'
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

    // $ANTLR start "INDENTATION"
    public void mINDENTATION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INDENTATION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:167:2: ({...}? => ( ' ' )+ )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:167:4: {...}? => ( ' ' )+
            {
            	if ( !((CharPositionInLine == 0)) ) 
            	{
            	    throw new FailedPredicateException(input, "INDENTATION", "CharPositionInLine == 0");
            	}
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:168:3: ( ' ' )+
            	int cnt13 = 0;
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == ' ') )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:168:3: ' '
            			    {
            			    	Match(' '); 

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

            	 
            				int size = GetIndentationSize(Text);
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

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INDENTATION"

    // $ANTLR start "NEWLINE"
    public void mNEWLINE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEWLINE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:185:2: ( '\\r\\n' | '\\n' | '\\r' )
            int alt14 = 3;
            int LA14_0 = input.LA(1);

            if ( (LA14_0 == '\r') )
            {
                int LA14_1 = input.LA(2);

                if ( (LA14_1 == '\n') )
                {
                    alt14 = 1;
                }
                else 
                {
                    alt14 = 3;}
            }
            else if ( (LA14_0 == '\n') )
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
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:185:4: '\\r\\n'
                    {
                    	Match("\r\n"); 


                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:185:13: '\\n'
                    {
                    	Match('\n'); 

                    }
                    break;
                case 3 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:185:20: '\\r'
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

    // $ANTLR start "UnQuotedStringChars"
    public void mUnQuotedStringChars() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:189:2: ( ( EscapeSequence | ~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\\"' ) ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:189:4: ( EscapeSequence | ~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\\"' ) )
            {
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:189:4: ( EscapeSequence | ~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\\"' ) )
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == '\\') )
            	{
            	    alt15 = 1;
            	}
            	else if ( ((LA15_0 >= ' ' && LA15_0 <= '!') || (LA15_0 >= '#' && LA15_0 <= '[') || (LA15_0 >= ']' && LA15_0 <= '\uFFFF')) )
            	{
            	    alt15 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d15s0 =
            	        new NoViableAltException("", 15, 0, input);

            	    throw nvae_d15s0;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:189:5: EscapeSequence
            	        {
            	        	mEscapeSequence(); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:189:22: ~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\\"' )
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
    // $ANTLR end "UnQuotedStringChars"

    // $ANTLR start "NonColonChars"
    public void mNonColonChars() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:193:2: ( ( EscapeSequence | ~ ( ':' ) )* )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:193:4: ( EscapeSequence | ~ ( ':' ) )*
            {
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:193:4: ( EscapeSequence | ~ ( ':' ) )*
            	do 
            	{
            	    int alt16 = 3;
            	    alt16 = dfa16.Predict(input);
            	    switch (alt16) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:193:5: EscapeSequence
            			    {
            			    	mEscapeSequence(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:193:22: ~ ( ':' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '9') || (input.LA(1) >= ';' && input.LA(1) <= '\uFFFF') ) 
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
            			    goto loop16;
            	    }
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "NonColonChars"

    // $ANTLR start "EscapeSequence"
    public void mEscapeSequence() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:197:2: ( '\\\\' ( UnicodeEscape | 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:197:4: '\\\\' ( UnicodeEscape | 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
            {
            	Match('\\'); 
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:197:9: ( UnicodeEscape | 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
            	int alt17 = 9;
            	switch ( input.LA(1) ) 
            	{
            	case 'u':
            		{
            	    alt17 = 1;
            	    }
            	    break;
            	case 'b':
            		{
            	    alt17 = 2;
            	    }
            	    break;
            	case 't':
            		{
            	    alt17 = 3;
            	    }
            	    break;
            	case 'n':
            		{
            	    alt17 = 4;
            	    }
            	    break;
            	case 'f':
            		{
            	    alt17 = 5;
            	    }
            	    break;
            	case 'r':
            		{
            	    alt17 = 6;
            	    }
            	    break;
            	case '\"':
            		{
            	    alt17 = 7;
            	    }
            	    break;
            	case '\'':
            		{
            	    alt17 = 8;
            	    }
            	    break;
            	case '\\':
            		{
            	    alt17 = 9;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d17s0 =
            		        new NoViableAltException("", 17, 0, input);

            		    throw nvae_d17s0;
            	}

            	switch (alt17) 
            	{
            	    case 1 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:197:10: UnicodeEscape
            	        {
            	        	mUnicodeEscape(); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:197:26: 'b'
            	        {
            	        	Match('b'); 

            	        }
            	        break;
            	    case 3 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:197:30: 't'
            	        {
            	        	Match('t'); 

            	        }
            	        break;
            	    case 4 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:197:34: 'n'
            	        {
            	        	Match('n'); 

            	        }
            	        break;
            	    case 5 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:197:38: 'f'
            	        {
            	        	Match('f'); 

            	        }
            	        break;
            	    case 6 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:197:42: 'r'
            	        {
            	        	Match('r'); 

            	        }
            	        break;
            	    case 7 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:197:46: '\\\"'
            	        {
            	        	Match('\"'); 

            	        }
            	        break;
            	    case 8 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:197:51: '\\''
            	        {
            	        	Match('\''); 

            	        }
            	        break;
            	    case 9 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:197:56: '\\\\'
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:201:2: ( 'u' HexDigit HexDigit HexDigit HexDigit )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:201:4: 'u' HexDigit HexDigit HexDigit HexDigit
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:205:2: ( '0' .. '9' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:205:4: '0' .. '9'
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:209:2: ( DecDigit | 'A' .. 'F' | 'a' .. 'f' )
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
        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:8: ( T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | Integer | LI | Float | QuotedString | Bool | INDENTATION | NEWLINE )
        int alt18 = 13;
        alt18 = dfa18.Predict(input);
        switch (alt18) 
        {
            case 1 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:10: T__30
                {
                	mT__30(); 

                }
                break;
            case 2 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:16: T__31
                {
                	mT__31(); 

                }
                break;
            case 3 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:22: T__32
                {
                	mT__32(); 

                }
                break;
            case 4 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:28: T__33
                {
                	mT__33(); 

                }
                break;
            case 5 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:34: T__34
                {
                	mT__34(); 

                }
                break;
            case 6 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:40: T__35
                {
                	mT__35(); 

                }
                break;
            case 7 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:46: Integer
                {
                	mInteger(); 

                }
                break;
            case 8 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:54: LI
                {
                	mLI(); 

                }
                break;
            case 9 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:57: Float
                {
                	mFloat(); 

                }
                break;
            case 10 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:63: QuotedString
                {
                	mQuotedString(); 

                }
                break;
            case 11 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:76: Bool
                {
                	mBool(); 

                }
                break;
            case 12 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:81: INDENTATION
                {
                	mINDENTATION(); 

                }
                break;
            case 13 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:93: NEWLINE
                {
                	mNEWLINE(); 

                }
                break;

        }

    }


    protected DFA16 dfa16;
    protected DFA18 dfa18;
	private void InitializeCyclicDFAs()
	{
	    this.dfa16 = new DFA16(this);
	    this.dfa18 = new DFA18(this);
	    this.dfa16.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA16_SpecialStateTransition);
	    this.dfa18.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA18_SpecialStateTransition);
	}

    const string DFA16_eotS =
        "\x01\x01\x01\uffff\x01\x03\x02\uffff\x01\x03\x07\uffff\x03\x03"+
        "\x01\uffff";
    const string DFA16_eofS =
        "\x11\uffff";
    const string DFA16_minS =
        "\x01\x00\x01\uffff\x01\x22\x02\uffff\x01\x30\x07\uffff\x03\x30"+
        "\x01\uffff";
    const string DFA16_maxS =
        "\x01\uffff\x01\uffff\x01\x75\x02\uffff\x01\x66\x07\uffff\x03\x66"+
        "\x01\uffff";
    const string DFA16_acceptS =
        "\x01\uffff\x01\x03\x01\uffff\x01\x02\x01\x01\x01\uffff\x07\x01"+
        "\x03\uffff\x01\x01";
    const string DFA16_specialS =
        "\x01\x00\x10\uffff}>";
    static readonly string[] DFA16_transitionS = {
            "\x3a\x03\x01\uffff\x21\x03\x01\x02\uffa3\x03",
            "",
            "\x01\x0b\x04\uffff\x01\x0c\x34\uffff\x01\x04\x05\uffff\x01"+
            "\x06\x03\uffff\x01\x09\x07\uffff\x01\x08\x03\uffff\x01\x0a\x01"+
            "\uffff\x01\x07\x01\x05",
            "",
            "",
            "\x0a\x0d\x07\uffff\x06\x0d\x1a\uffff\x06\x0d",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x0a\x0e\x07\uffff\x06\x0e\x1a\uffff\x06\x0e",
            "\x0a\x0f\x07\uffff\x06\x0f\x1a\uffff\x06\x0f",
            "\x0a\x10\x07\uffff\x06\x10\x1a\uffff\x06\x10",
            ""
    };

    static readonly short[] DFA16_eot = DFA.UnpackEncodedString(DFA16_eotS);
    static readonly short[] DFA16_eof = DFA.UnpackEncodedString(DFA16_eofS);
    static readonly char[] DFA16_min = DFA.UnpackEncodedStringToUnsignedChars(DFA16_minS);
    static readonly char[] DFA16_max = DFA.UnpackEncodedStringToUnsignedChars(DFA16_maxS);
    static readonly short[] DFA16_accept = DFA.UnpackEncodedString(DFA16_acceptS);
    static readonly short[] DFA16_special = DFA.UnpackEncodedString(DFA16_specialS);
    static readonly short[][] DFA16_transition = DFA.UnpackEncodedStringArray(DFA16_transitionS);

    protected class DFA16 : DFA
    {
        public DFA16(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 16;
            this.eot = DFA16_eot;
            this.eof = DFA16_eof;
            this.min = DFA16_min;
            this.max = DFA16_max;
            this.accept = DFA16_accept;
            this.special = DFA16_special;
            this.transition = DFA16_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 193:4: ( EscapeSequence | ~ ( ':' ) )*"; }
        }

    }


    protected internal int DFA16_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA16_0 = input.LA(1);

                   	s = -1;
                   	if ( (LA16_0 == '\\') ) { s = 2; }

                   	else if ( ((LA16_0 >= '\u0000' && LA16_0 <= '9') || (LA16_0 >= ';' && LA16_0 <= '[') || (LA16_0 >= ']' && LA16_0 <= '\uFFFF')) ) { s = 3; }

                   	else s = 1;

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae16 =
            new NoViableAltException(dfa.Description, 16, _s, input);
        dfa.Error(nvae16);
        throw nvae16;
    }
    const string DFA18_eotS =
        "\x07\uffff\x01\x0e\x02\x0f\x07\uffff";
    const string DFA18_eofS =
        "\x11\uffff";
    const string DFA18_minS =
        "\x01\x0a\x06\uffff\x01\x30\x02\x2e\x07\uffff";
    const string DFA18_maxS =
        "\x01\x7d\x06\uffff\x03\x39\x07\uffff";
    const string DFA18_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x03"+
        "\uffff\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01\x08\x01\x07\x01\x09";
    const string DFA18_specialS =
        "\x01\x00\x10\uffff}>";
    static readonly string[] DFA18_transitionS = {
            "\x01\x0d\x02\uffff\x01\x0d\x12\uffff\x01\x0c\x01\uffff\x01"+
            "\x0a\x09\uffff\x01\x02\x01\x07\x02\uffff\x01\x08\x09\x09\x01"+
            "\x04\x20\uffff\x01\x05\x01\uffff\x01\x06\x08\uffff\x01\x0b\x0d"+
            "\uffff\x01\x0b\x06\uffff\x01\x01\x01\uffff\x01\x03",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x0a\x09",
            "\x01\x10\x01\uffff\x0a\x09",
            "\x01\x10\x01\uffff\x0a\x09",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA18_eot = DFA.UnpackEncodedString(DFA18_eotS);
    static readonly short[] DFA18_eof = DFA.UnpackEncodedString(DFA18_eofS);
    static readonly char[] DFA18_min = DFA.UnpackEncodedStringToUnsignedChars(DFA18_minS);
    static readonly char[] DFA18_max = DFA.UnpackEncodedStringToUnsignedChars(DFA18_maxS);
    static readonly short[] DFA18_accept = DFA.UnpackEncodedString(DFA18_acceptS);
    static readonly short[] DFA18_special = DFA.UnpackEncodedString(DFA18_specialS);
    static readonly short[][] DFA18_transition = DFA.UnpackEncodedStringArray(DFA18_transitionS);

    protected class DFA18 : DFA
    {
        public DFA18(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 18;
            this.eot = DFA18_eot;
            this.eof = DFA18_eof;
            this.min = DFA18_min;
            this.max = DFA18_max;
            this.accept = DFA18_accept;
            this.special = DFA18_special;
            this.transition = DFA18_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | Integer | LI | Float | QuotedString | Bool | INDENTATION | NEWLINE );"; }
        }

    }


    protected internal int DFA18_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA18_0 = input.LA(1);

                   	 
                   	int index18_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA18_0 == '{') ) { s = 1; }

                   	else if ( (LA18_0 == ',') ) { s = 2; }

                   	else if ( (LA18_0 == '}') ) { s = 3; }

                   	else if ( (LA18_0 == ':') ) { s = 4; }

                   	else if ( (LA18_0 == '[') ) { s = 5; }

                   	else if ( (LA18_0 == ']') ) { s = 6; }

                   	else if ( (LA18_0 == '-') ) { s = 7; }

                   	else if ( (LA18_0 == '0') ) { s = 8; }

                   	else if ( ((LA18_0 >= '1' && LA18_0 <= '9')) ) { s = 9; }

                   	else if ( (LA18_0 == '\"') ) { s = 10; }

                   	else if ( (LA18_0 == 'f' || LA18_0 == 't') ) { s = 11; }

                   	else if ( (LA18_0 == ' ') && ((CharPositionInLine == 0)) ) { s = 12; }

                   	else if ( (LA18_0 == '\n' || LA18_0 == '\r') ) { s = 13; }

                   	 
                   	input.Seek(index18_0);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae18 =
            new NoViableAltException(dfa.Description, 18, _s, input);
        dfa.Error(nvae18);
        throw nvae18;
    }
 
    
}
}