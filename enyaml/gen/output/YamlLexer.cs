// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g 2010-12-31 17:26:22

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
    public const int Bool = 17;
    public const int DOUBLE_QUOTE = 9;
    public const int NULL = 18;
    public const int BOOL = 8;
    public const int Exponent = 24;
    public const int UnQuotedString = 26;
    public const int DEDENT = 14;
    public const int FLOAT = 7;
    public const int EOF = -1;
    public const int QuotedString = 25;
    public const int LIST = 12;
    public const int HexDigit = 21;
    public const int DecDigit = 20;
    public const int INDENT = 13;
    public const int Float = 23;
    public const int SINGLE_QUOTE = 10;
    public const int T__32 = 32;
    public const int NonColonChars = 30;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int NEWLINE = 28;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int DENT = 15;
    public const int UnicodeEscape = 31;
    public const int MAP = 11;
    public const int QUOTED_STRING = 4;
    public const int UnQuotedStringChars = 27;
    public const int UNQUOTED_STRING = 5;
    public const int LI = 22;
    public const int EscapeSequence = 29;
    public const int Integer = 19;
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

    // $ANTLR start "T__32"
    public void mT__32() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__32;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:15:7: ( '{' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:15:9: '{'
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
    // $ANTLR end "T__32"

    // $ANTLR start "T__33"
    public void mT__33() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__33;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:16:7: ( ',' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:16:9: ','
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
    // $ANTLR end "T__33"

    // $ANTLR start "T__34"
    public void mT__34() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__34;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:17:7: ( '}' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:17:9: '}'
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
    // $ANTLR end "T__34"

    // $ANTLR start "T__35"
    public void mT__35() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__35;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:18:7: ( ':' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:18:9: ':'
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
    // $ANTLR end "T__35"

    // $ANTLR start "T__36"
    public void mT__36() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__36;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:19:7: ( '[' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:19:9: '['
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
    // $ANTLR end "T__36"

    // $ANTLR start "T__37"
    public void mT__37() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__37;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:20:7: ( ']' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:20:9: ']'
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
    // $ANTLR end "T__37"

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

    // $ANTLR start "Bool"
    public void mBool() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Bool;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:52:2: ( 'true' | 'false' )
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
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:52:4: 'true'
                    {
                    	Match("true"); 


                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:52:13: 'false'
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

    // $ANTLR start "NULL"
    public void mNULL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NULL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:59:6: ( 'null' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:59:8: 'null'
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

    // $ANTLR start "Integer"
    public void mInteger() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Integer;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:66:2: ( ( '-' )? ( DecDigit )+ | ( '0' 'x' ( HexDigit )+ ) )
            int alt6 = 2;
            int LA6_0 = input.LA(1);

            if ( (LA6_0 == '-' || (LA6_0 >= '1' && LA6_0 <= '9')) )
            {
                alt6 = 1;
            }
            else if ( (LA6_0 == '0') )
            {
                int LA6_2 = input.LA(2);

                if ( (LA6_2 == 'x') )
                {
                    alt6 = 2;
                }
                else 
                {
                    alt6 = 1;}
            }
            else 
            {
                NoViableAltException nvae_d6s0 =
                    new NoViableAltException("", 6, 0, input);

                throw nvae_d6s0;
            }
            switch (alt6) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:66:4: ( '-' )? ( DecDigit )+
                    {
                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:66:4: ( '-' )?
                    	int alt3 = 2;
                    	int LA3_0 = input.LA(1);

                    	if ( (LA3_0 == '-') )
                    	{
                    	    alt3 = 1;
                    	}
                    	switch (alt3) 
                    	{
                    	    case 1 :
                    	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:66:4: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:66:9: ( DecDigit )+
                    	int cnt4 = 0;
                    	do 
                    	{
                    	    int alt4 = 2;
                    	    int LA4_0 = input.LA(1);

                    	    if ( ((LA4_0 >= '0' && LA4_0 <= '9')) )
                    	    {
                    	        alt4 = 1;
                    	    }


                    	    switch (alt4) 
                    		{
                    			case 1 :
                    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:66:9: DecDigit
                    			    {
                    			    	mDecDigit(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt4 >= 1 ) goto loop4;
                    		            EarlyExitException eee4 =
                    		                new EarlyExitException(4, input);
                    		            throw eee4;
                    	    }
                    	    cnt4++;
                    	} while (true);

                    	loop4:
                    		;	// Stops C# compiler whining that label 'loop4' has no statements


                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:67:4: ( '0' 'x' ( HexDigit )+ )
                    {
                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:67:4: ( '0' 'x' ( HexDigit )+ )
                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:67:5: '0' 'x' ( HexDigit )+
                    	{
                    		Match('0'); 
                    		Match('x'); 
                    		// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:67:13: ( HexDigit )+
                    		int cnt5 = 0;
                    		do 
                    		{
                    		    int alt5 = 2;
                    		    int LA5_0 = input.LA(1);

                    		    if ( ((LA5_0 >= '0' && LA5_0 <= '9') || (LA5_0 >= 'A' && LA5_0 <= 'F') || (LA5_0 >= 'a' && LA5_0 <= 'f')) )
                    		    {
                    		        alt5 = 1;
                    		    }


                    		    switch (alt5) 
                    			{
                    				case 1 :
                    				    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:67:13: HexDigit
                    				    {
                    				    	mHexDigit(); 

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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:71:2: ( '-' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:71:4: '-'
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:79:2: ( ( '-' )? ( DecDigit )+ '.' ( DecDigit )* ( Exponent )? )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:79:4: ( '-' )? ( DecDigit )+ '.' ( DecDigit )* ( Exponent )?
            {
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:79:4: ( '-' )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == '-') )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:79:4: '-'
            	        {
            	        	Match('-'); 

            	        }
            	        break;

            	}

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:79:9: ( DecDigit )+
            	int cnt8 = 0;
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( ((LA8_0 >= '0' && LA8_0 <= '9')) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:79:9: DecDigit
            			    {
            			    	mDecDigit(); 

            			    }
            			    break;

            			default:
            			    if ( cnt8 >= 1 ) goto loop8;
            		            EarlyExitException eee8 =
            		                new EarlyExitException(8, input);
            		            throw eee8;
            	    }
            	    cnt8++;
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	Match('.'); 
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:79:23: ( DecDigit )*
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
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:79:23: DecDigit
            			    {
            			    	mDecDigit(); 

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:79:33: ( Exponent )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == 'E' || LA10_0 == 'e') )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:79:33: Exponent
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:83:2: ( ( 'e' | 'E' ) ( '-' | '+' )? ( DecDigit )+ )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:83:4: ( 'e' | 'E' ) ( '-' | '+' )? ( DecDigit )+
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

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:83:16: ( '-' | '+' )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == '+' || LA11_0 == '-') )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
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

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:83:29: ( DecDigit )+
            	int cnt12 = 0;
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= '0' && LA12_0 <= '9')) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:83:29: DecDigit
            			    {
            			    	mDecDigit(); 

            			    }
            			    break;

            			default:
            			    if ( cnt12 >= 1 ) goto loop12;
            		            EarlyExitException eee12 =
            		                new EarlyExitException(12, input);
            		            throw eee12;
            	    }
            	    cnt12++;
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements


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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:92:2: ( '\"' ( UnQuotedStringChars )* '\"' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:92:4: '\"' ( UnQuotedStringChars )* '\"'
            {
            	Match('\"'); 
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:92:8: ( UnQuotedStringChars )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( ((LA13_0 >= ' ' && LA13_0 <= '!') || (LA13_0 >= '#' && LA13_0 <= '9') || (LA13_0 >= ';' && LA13_0 <= '\uFFFF')) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:92:8: UnQuotedStringChars
            			    {
            			    	mUnQuotedStringChars(); 

            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements

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

    // $ANTLR start "UnQuotedString"
    public void mUnQuotedString() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UnQuotedString;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:96:2: (~ ( DecDigit | ':' | '[' | '{' | '}' | ']' | LI | NEWLINE | ' ' | '\\t' | ',' ) ( UnQuotedStringChars )* {...}?)
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:96:4: ~ ( DecDigit | ':' | '[' | '{' | '}' | ']' | LI | NEWLINE | ' ' | '\\t' | ',' ) ( UnQuotedStringChars )* {...}?
            {
            	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\b') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\u001F') || (input.LA(1) >= '!' && input.LA(1) <= '+') || (input.LA(1) >= '.' && input.LA(1) <= '/') || (input.LA(1) >= ';' && input.LA(1) <= 'Z') || input.LA(1) == '\\' || (input.LA(1) >= '^' && input.LA(1) <= 'z') || input.LA(1) == '|' || (input.LA(1) >= '~' && input.LA(1) <= '\uFFFF') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:4: ( UnQuotedStringChars )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( ((LA14_0 >= ' ' && LA14_0 <= '!') || (LA14_0 >= '#' && LA14_0 <= '9') || (LA14_0 >= ';' && LA14_0 <= '\uFFFF')) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:4: UnQuotedStringChars
            			    {
            			    	mUnQuotedStringChars(); 

            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

            	if ( !(( Text != "null" && Text != "false" && Text != "true" )) ) 
            	{
            	    throw new FailedPredicateException(input, "UnQuotedString", " $text != \"null\" && $text != \"false\" && $text != \"true\" ");
            	}

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UnQuotedString"

    // $ANTLR start "NEWLINE"
    public void mNEWLINE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEWLINE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:183:2: ( '\\r\\n' | '\\n' | '\\r' )
            int alt15 = 3;
            int LA15_0 = input.LA(1);

            if ( (LA15_0 == '\r') )
            {
                int LA15_1 = input.LA(2);

                if ( (LA15_1 == '\n') )
                {
                    alt15 = 1;
                }
                else 
                {
                    alt15 = 3;}
            }
            else if ( (LA15_0 == '\n') )
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
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:183:4: '\\r\\n'
                    {
                    	Match("\r\n"); 


                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:183:13: '\\n'
                    {
                    	Match('\n'); 

                    }
                    break;
                case 3 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:183:20: '\\r'
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:187:2: ( ( EscapeSequence | ~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\\"' | ':' | NEWLINE ) ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:187:4: ( EscapeSequence | ~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\\"' | ':' | NEWLINE ) )
            {
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:187:4: ( EscapeSequence | ~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\\"' | ':' | NEWLINE ) )
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == '\\') )
            	{
            	    alt16 = 1;
            	}
            	else if ( ((LA16_0 >= ' ' && LA16_0 <= '!') || (LA16_0 >= '#' && LA16_0 <= '9') || (LA16_0 >= ';' && LA16_0 <= '[') || (LA16_0 >= ']' && LA16_0 <= '\uFFFF')) )
            	{
            	    alt16 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d16s0 =
            	        new NoViableAltException("", 16, 0, input);

            	    throw nvae_d16s0;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:187:5: EscapeSequence
            	        {
            	        	mEscapeSequence(); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:187:22: ~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\\"' | ':' | NEWLINE )
            	        {
            	        	if ( (input.LA(1) >= ' ' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '9') || (input.LA(1) >= ';' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFF') ) 
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:191:2: ( ( EscapeSequence | ~ ( ':' ) )* )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:191:4: ( EscapeSequence | ~ ( ':' ) )*
            {
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:191:4: ( EscapeSequence | ~ ( ':' ) )*
            	do 
            	{
            	    int alt17 = 3;
            	    alt17 = dfa17.Predict(input);
            	    switch (alt17) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:191:5: EscapeSequence
            			    {
            			    	mEscapeSequence(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:191:22: ~ ( ':' )
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
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements


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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:195:2: ( '\\\\' ( UnicodeEscape | 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:195:4: '\\\\' ( UnicodeEscape | 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
            {
            	Match('\\'); 
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:195:9: ( UnicodeEscape | 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
            	int alt18 = 9;
            	switch ( input.LA(1) ) 
            	{
            	case 'u':
            		{
            	    alt18 = 1;
            	    }
            	    break;
            	case 'b':
            		{
            	    alt18 = 2;
            	    }
            	    break;
            	case 't':
            		{
            	    alt18 = 3;
            	    }
            	    break;
            	case 'n':
            		{
            	    alt18 = 4;
            	    }
            	    break;
            	case 'f':
            		{
            	    alt18 = 5;
            	    }
            	    break;
            	case 'r':
            		{
            	    alt18 = 6;
            	    }
            	    break;
            	case '\"':
            		{
            	    alt18 = 7;
            	    }
            	    break;
            	case '\'':
            		{
            	    alt18 = 8;
            	    }
            	    break;
            	case '\\':
            		{
            	    alt18 = 9;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d18s0 =
            		        new NoViableAltException("", 18, 0, input);

            		    throw nvae_d18s0;
            	}

            	switch (alt18) 
            	{
            	    case 1 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:195:10: UnicodeEscape
            	        {
            	        	mUnicodeEscape(); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:195:26: 'b'
            	        {
            	        	Match('b'); 

            	        }
            	        break;
            	    case 3 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:195:30: 't'
            	        {
            	        	Match('t'); 

            	        }
            	        break;
            	    case 4 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:195:34: 'n'
            	        {
            	        	Match('n'); 

            	        }
            	        break;
            	    case 5 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:195:38: 'f'
            	        {
            	        	Match('f'); 

            	        }
            	        break;
            	    case 6 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:195:42: 'r'
            	        {
            	        	Match('r'); 

            	        }
            	        break;
            	    case 7 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:195:46: '\\\"'
            	        {
            	        	Match('\"'); 

            	        }
            	        break;
            	    case 8 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:195:51: '\\''
            	        {
            	        	Match('\''); 

            	        }
            	        break;
            	    case 9 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:195:56: '\\\\'
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:199:2: ( 'u' HexDigit HexDigit HexDigit HexDigit )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:199:4: 'u' HexDigit HexDigit HexDigit HexDigit
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:203:2: ( '0' .. '9' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:203:4: '0' .. '9'
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:207:2: ( DecDigit | 'A' .. 'F' | 'a' .. 'f' )
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
        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:8: ( T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | INDENTATION | Bool | NULL | Integer | LI | Float | QuotedString | UnQuotedString | NEWLINE )
        int alt19 = 15;
        alt19 = dfa19.Predict(input);
        switch (alt19) 
        {
            case 1 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:10: T__32
                {
                	mT__32(); 

                }
                break;
            case 2 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:16: T__33
                {
                	mT__33(); 

                }
                break;
            case 3 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:22: T__34
                {
                	mT__34(); 

                }
                break;
            case 4 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:28: T__35
                {
                	mT__35(); 

                }
                break;
            case 5 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:34: T__36
                {
                	mT__36(); 

                }
                break;
            case 6 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:40: T__37
                {
                	mT__37(); 

                }
                break;
            case 7 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:46: INDENTATION
                {
                	mINDENTATION(); 

                }
                break;
            case 8 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:58: Bool
                {
                	mBool(); 

                }
                break;
            case 9 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:63: NULL
                {
                	mNULL(); 

                }
                break;
            case 10 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:68: Integer
                {
                	mInteger(); 

                }
                break;
            case 11 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:76: LI
                {
                	mLI(); 

                }
                break;
            case 12 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:79: Float
                {
                	mFloat(); 

                }
                break;
            case 13 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:85: QuotedString
                {
                	mQuotedString(); 

                }
                break;
            case 14 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:98: UnQuotedString
                {
                	mUnQuotedString(); 

                }
                break;
            case 15 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:113: NEWLINE
                {
                	mNEWLINE(); 

                }
                break;

        }

    }


    protected DFA17 dfa17;
    protected DFA19 dfa19;
	private void InitializeCyclicDFAs()
	{
	    this.dfa17 = new DFA17(this);
	    this.dfa19 = new DFA19(this);
	    this.dfa17.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA17_SpecialStateTransition);
	    this.dfa19.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA19_SpecialStateTransition);
	}

    const string DFA17_eotS =
        "\x01\x01\x01\uffff\x01\x03\x01\uffff\x01\x03\x08\uffff\x03\x03"+
        "\x01\uffff";
    const string DFA17_eofS =
        "\x11\uffff";
    const string DFA17_minS =
        "\x01\x00\x01\uffff\x01\x22\x01\uffff\x01\x30\x08\uffff\x03\x30"+
        "\x01\uffff";
    const string DFA17_maxS =
        "\x01\uffff\x01\uffff\x01\x75\x01\uffff\x01\x66\x08\uffff\x03\x66"+
        "\x01\uffff";
    const string DFA17_acceptS =
        "\x01\uffff\x01\x03\x01\uffff\x01\x02\x01\uffff\x08\x01\x03\uffff"+
        "\x01\x01";
    const string DFA17_specialS =
        "\x01\x00\x10\uffff}>";
    static readonly string[] DFA17_transitionS = {
            "\x3a\x03\x01\uffff\x21\x03\x01\x02\uffa3\x03",
            "",
            "\x01\x0a\x04\uffff\x01\x0b\x34\uffff\x01\x0c\x05\uffff\x01"+
            "\x05\x03\uffff\x01\x08\x07\uffff\x01\x07\x03\uffff\x01\x09\x01"+
            "\uffff\x01\x06\x01\x04",
            "",
            "\x0a\x0d\x07\uffff\x06\x0d\x1a\uffff\x06\x0d",
            "",
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
            get { return "()* loopback of 191:4: ( EscapeSequence | ~ ( ':' ) )*"; }
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
                   	if ( (LA17_0 == '\\') ) { s = 2; }

                   	else if ( ((LA17_0 >= '\u0000' && LA17_0 <= '9') || (LA17_0 >= ';' && LA17_0 <= '[') || (LA17_0 >= ']' && LA17_0 <= '\uFFFF')) ) { s = 3; }

                   	else s = 1;

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae17 =
            new NoViableAltException(dfa.Description, 17, _s, input);
        dfa.Error(nvae17);
        throw nvae17;
    }
    const string DFA19_eotS =
        "\x08\uffff\x03\x0f\x01\x14\x02\x15\x01\x0f\x02\uffff\x03\x0f\x04"+
        "\uffff\x01\x0f\x01\uffff\x03\x0f\x01\uffff\x08\x0f\x01\x2a\x01\x0f"+
        "\x01\x2c\x02\uffff\x01\x2a\x03\uffff\x01\x0f";
    const string DFA19_eofS =
        "\x30\uffff";
    const string DFA19_minS =
        "\x01\x00\x07\uffff\x01\x72\x01\x61\x01\x75\x01\x30\x02\x2e\x01"+
        "\x20\x02\uffff\x01\x75\x02\x6c\x03\uffff\x01\x22\x01\x20\x01\uffff"+
        "\x01\x65\x01\x73\x01\x6c\x01\x30\x09\x20\x01\x65\x01\x20\x01\x30"+
        "\x01\uffff\x01\x20\x01\uffff\x02\x30\x01\x20";
    const string DFA19_maxS =
        "\x01\uffff\x07\uffff\x01\x72\x01\x61\x01\x75\x03\x39\x01\uffff"+
        "\x02\uffff\x01\x75\x02\x6c\x03\uffff\x01\x75\x01\uffff\x01\uffff"+
        "\x01\x65\x01\x73\x01\x6c\x01\x66\x09\uffff\x01\x65\x01\uffff\x01"+
        "\x66\x01\uffff\x01\uffff\x01\uffff\x02\x66\x01\uffff";
    const string DFA19_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x07\uffff\x01\x0e\x01\x0f\x03\uffff\x01\x0b\x01\x0a\x01\x0c"+
        "\x02\uffff\x01\x0d\x10\uffff\x01\x08\x01\uffff\x01\x09\x03\uffff";
    const string DFA19_specialS =
        "\x01\x00\x2f\uffff}>";
    static readonly string[] DFA19_transitionS = {
            "\x09\x0f\x01\uffff\x01\x10\x02\x0f\x01\x10\x12\x0f\x01\x07"+
            "\x01\x0f\x01\x0e\x09\x0f\x01\x02\x01\x0b\x02\x0f\x01\x0c\x09"+
            "\x0d\x01\x04\x20\x0f\x01\x05\x01\x0f\x01\x06\x08\x0f\x01\x09"+
            "\x07\x0f\x01\x0a\x05\x0f\x01\x08\x06\x0f\x01\x01\x01\x0f\x01"+
            "\x03\uff82\x0f",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x11",
            "\x01\x12",
            "\x01\x13",
            "\x0a\x0d",
            "\x01\x16\x01\uffff\x0a\x0d",
            "\x01\x16\x01\uffff\x0a\x0d",
            "\x02\x18\x01\x19\x17\x18\x01\uffff\x21\x18\x01\x17\uffa3\x18",
            "",
            "",
            "\x01\x1a",
            "\x01\x1b",
            "\x01\x1c",
            "",
            "",
            "",
            "\x01\x23\x04\uffff\x01\x24\x34\uffff\x01\x25\x05\uffff\x01"+
            "\x1e\x03\uffff\x01\x21\x07\uffff\x01\x20\x03\uffff\x01\x22\x01"+
            "\uffff\x01\x1f\x01\x1d",
            "\x02\x18\x01\x19\x17\x18\x01\uffff\x21\x18\x01\x17\uffa3\x18",
            "",
            "\x01\x26",
            "\x01\x27",
            "\x01\x28",
            "\x0a\x29\x07\uffff\x06\x29\x1a\uffff\x06\x29",
            "\x02\x18\x01\x19\x17\x18\x01\uffff\x21\x18\x01\x17\uffa3\x18",
            "\x02\x18\x01\x19\x17\x18\x01\uffff\x21\x18\x01\x17\uffa3\x18",
            "\x02\x18\x01\x19\x17\x18\x01\uffff\x21\x18\x01\x17\uffa3\x18",
            "\x02\x18\x01\x19\x17\x18\x01\uffff\x21\x18\x01\x17\uffa3\x18",
            "\x02\x18\x01\x19\x17\x18\x01\uffff\x21\x18\x01\x17\uffa3\x18",
            "\x02\x18\x01\x19\x17\x18\x01\uffff\x21\x18\x01\x17\uffa3\x18",
            "\x02\x18\x01\x19\x17\x18\x01\uffff\x21\x18\x01\x17\uffa3\x18",
            "\x02\x18\x01\x19\x17\x18\x01\uffff\x21\x18\x01\x17\uffa3\x18",
            "\x02\x0f\x01\uffff\x17\x0f\x01\uffff\uffc5\x0f",
            "\x01\x2b",
            "\x02\x0f\x01\uffff\x17\x0f\x01\uffff\uffc5\x0f",
            "\x0a\x2d\x07\uffff\x06\x2d\x1a\uffff\x06\x2d",
            "",
            "\x02\x0f\x01\uffff\x17\x0f\x01\uffff\uffc5\x0f",
            "",
            "\x0a\x2e\x07\uffff\x06\x2e\x1a\uffff\x06\x2e",
            "\x0a\x2f\x07\uffff\x06\x2f\x1a\uffff\x06\x2f",
            "\x02\x18\x01\x19\x17\x18\x01\uffff\x21\x18\x01\x17\uffa3\x18"
    };

    static readonly short[] DFA19_eot = DFA.UnpackEncodedString(DFA19_eotS);
    static readonly short[] DFA19_eof = DFA.UnpackEncodedString(DFA19_eofS);
    static readonly char[] DFA19_min = DFA.UnpackEncodedStringToUnsignedChars(DFA19_minS);
    static readonly char[] DFA19_max = DFA.UnpackEncodedStringToUnsignedChars(DFA19_maxS);
    static readonly short[] DFA19_accept = DFA.UnpackEncodedString(DFA19_acceptS);
    static readonly short[] DFA19_special = DFA.UnpackEncodedString(DFA19_specialS);
    static readonly short[][] DFA19_transition = DFA.UnpackEncodedStringArray(DFA19_transitionS);

    protected class DFA19 : DFA
    {
        public DFA19(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 19;
            this.eot = DFA19_eot;
            this.eof = DFA19_eof;
            this.min = DFA19_min;
            this.max = DFA19_max;
            this.accept = DFA19_accept;
            this.special = DFA19_special;
            this.transition = DFA19_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | INDENTATION | Bool | NULL | Integer | LI | Float | QuotedString | UnQuotedString | NEWLINE );"; }
        }

    }


    protected internal int DFA19_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA19_0 = input.LA(1);

                   	 
                   	int index19_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA19_0 == '{') ) { s = 1; }

                   	else if ( (LA19_0 == ',') ) { s = 2; }

                   	else if ( (LA19_0 == '}') ) { s = 3; }

                   	else if ( (LA19_0 == ':') ) { s = 4; }

                   	else if ( (LA19_0 == '[') ) { s = 5; }

                   	else if ( (LA19_0 == ']') ) { s = 6; }

                   	else if ( (LA19_0 == ' ') && ((CharPositionInLine == 0)) ) { s = 7; }

                   	else if ( (LA19_0 == 't') ) { s = 8; }

                   	else if ( (LA19_0 == 'f') ) { s = 9; }

                   	else if ( (LA19_0 == 'n') ) { s = 10; }

                   	else if ( (LA19_0 == '-') ) { s = 11; }

                   	else if ( (LA19_0 == '0') ) { s = 12; }

                   	else if ( ((LA19_0 >= '1' && LA19_0 <= '9')) ) { s = 13; }

                   	else if ( (LA19_0 == '\"') ) { s = 14; }

                   	else if ( ((LA19_0 >= '\u0000' && LA19_0 <= '\b') || (LA19_0 >= '\u000B' && LA19_0 <= '\f') || (LA19_0 >= '\u000E' && LA19_0 <= '\u001F') || LA19_0 == '!' || (LA19_0 >= '#' && LA19_0 <= '+') || (LA19_0 >= '.' && LA19_0 <= '/') || (LA19_0 >= ';' && LA19_0 <= 'Z') || LA19_0 == '\\' || (LA19_0 >= '^' && LA19_0 <= 'e') || (LA19_0 >= 'g' && LA19_0 <= 'm') || (LA19_0 >= 'o' && LA19_0 <= 's') || (LA19_0 >= 'u' && LA19_0 <= 'z') || LA19_0 == '|' || (LA19_0 >= '~' && LA19_0 <= '\uFFFF')) ) { s = 15; }

                   	else if ( (LA19_0 == '\n' || LA19_0 == '\r') ) { s = 16; }

                   	 
                   	input.Seek(index19_0);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae19 =
            new NoViableAltException(dfa.Description, 19, _s, input);
        dfa.Error(nvae19);
        throw nvae19;
    }
 
    
}
}