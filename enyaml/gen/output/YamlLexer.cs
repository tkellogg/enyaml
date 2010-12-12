// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g 2010-12-12 16:15:21

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class YamlLexer : Lexer {
    public const int INTEGER = 6;
    public const int DOUBLE_QUOTE = 8;
    public const int NULL = 12;
    public const int FLOAT = 7;
    public const int EOF = -1;
    public const int QuotedString = 17;
    public const int TRUE = 10;
    public const int HexDigit = 15;
    public const int DecDigit = 14;
    public const int Float = 16;
    public const int SINGLE_QUOTE = 9;
    public const int UnicodeEscape = 20;
    public const int QUOTED_STRING = 4;
    public const int UnQuotedStringChars = 18;
    public const int UNQUOTED_STRING = 5;
    public const int FALSE = 11;
    public const int EscapeSequence = 19;
    public const int Integer = 13;

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

    // $ANTLR start "Integer"
    public void mInteger() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Integer;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:25:2: ( ( '-' )? ( DecDigit )+ | ( '0' 'x' ( HexDigit )+ ) )
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
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:25:4: ( '-' )? ( DecDigit )+
                    {
                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:25:4: ( '-' )?
                    	int alt1 = 2;
                    	int LA1_0 = input.LA(1);

                    	if ( (LA1_0 == '-') )
                    	{
                    	    alt1 = 1;
                    	}
                    	switch (alt1) 
                    	{
                    	    case 1 :
                    	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:25:4: '-'
                    	        {
                    	        	Match('-'); 

                    	        }
                    	        break;

                    	}

                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:25:9: ( DecDigit )+
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
                    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:25:9: DecDigit
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
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:26:4: ( '0' 'x' ( HexDigit )+ )
                    {
                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:26:4: ( '0' 'x' ( HexDigit )+ )
                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:26:5: '0' 'x' ( HexDigit )+
                    	{
                    		Match('0'); 
                    		Match('x'); 
                    		// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:26:13: ( HexDigit )+
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
                    				    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:26:13: HexDigit
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

    // $ANTLR start "Float"
    public void mFloat() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Float;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:34:2: ( ( '-' )? ( DecDigit )+ '.' ( DecDigit )* )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:34:4: ( '-' )? ( DecDigit )+ '.' ( DecDigit )*
            {
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:34:4: ( '-' )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == '-') )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:34:4: '-'
            	        {
            	        	Match('-'); 

            	        }
            	        break;

            	}

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:34:9: ( DecDigit )+
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
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:34:9: DecDigit
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
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:34:23: ( DecDigit )*
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
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:34:23: DecDigit
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


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Float"

    // $ANTLR start "QuotedString"
    public void mQuotedString() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = QuotedString;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:43:2: ( '\"' ( UnQuotedStringChars )* '\"' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:43:4: '\"' ( UnQuotedStringChars )* '\"'
            {
            	Match('\"'); 
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:43:8: ( UnQuotedStringChars )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( ((LA8_0 >= ' ' && LA8_0 <= '!') || (LA8_0 >= '#' && LA8_0 <= '\uFFFF')) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:43:8: UnQuotedStringChars
            			    {
            			    	mUnQuotedStringChars(); 

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

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

    // $ANTLR start "UnQuotedStringChars"
    public void mUnQuotedStringChars() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:51:2: ( ( EscapeSequence | ~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\\"' ) ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:51:4: ( EscapeSequence | ~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\\"' ) )
            {
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:51:4: ( EscapeSequence | ~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\\"' ) )
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == '\\') )
            	{
            	    alt9 = 1;
            	}
            	else if ( ((LA9_0 >= ' ' && LA9_0 <= '!') || (LA9_0 >= '#' && LA9_0 <= '[') || (LA9_0 >= ']' && LA9_0 <= '\uFFFF')) )
            	{
            	    alt9 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d9s0 =
            	        new NoViableAltException("", 9, 0, input);

            	    throw nvae_d9s0;
            	}
            	switch (alt9) 
            	{
            	    case 1 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:51:5: EscapeSequence
            	        {
            	        	mEscapeSequence(); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:51:22: ~ ( '\\u0000' .. '\\u001f' | '\\\\' | '\\\"' )
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

    // $ANTLR start "EscapeSequence"
    public void mEscapeSequence() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:55:2: ( '\\\\' ( UnicodeEscape | 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:55:4: '\\\\' ( UnicodeEscape | 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
            {
            	Match('\\'); 
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:55:9: ( UnicodeEscape | 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
            	int alt10 = 9;
            	switch ( input.LA(1) ) 
            	{
            	case 'u':
            		{
            	    alt10 = 1;
            	    }
            	    break;
            	case 'b':
            		{
            	    alt10 = 2;
            	    }
            	    break;
            	case 't':
            		{
            	    alt10 = 3;
            	    }
            	    break;
            	case 'n':
            		{
            	    alt10 = 4;
            	    }
            	    break;
            	case 'f':
            		{
            	    alt10 = 5;
            	    }
            	    break;
            	case 'r':
            		{
            	    alt10 = 6;
            	    }
            	    break;
            	case '\"':
            		{
            	    alt10 = 7;
            	    }
            	    break;
            	case '\'':
            		{
            	    alt10 = 8;
            	    }
            	    break;
            	case '\\':
            		{
            	    alt10 = 9;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d10s0 =
            		        new NoViableAltException("", 10, 0, input);

            		    throw nvae_d10s0;
            	}

            	switch (alt10) 
            	{
            	    case 1 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:55:10: UnicodeEscape
            	        {
            	        	mUnicodeEscape(); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:55:26: 'b'
            	        {
            	        	Match('b'); 

            	        }
            	        break;
            	    case 3 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:55:30: 't'
            	        {
            	        	Match('t'); 

            	        }
            	        break;
            	    case 4 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:55:34: 'n'
            	        {
            	        	Match('n'); 

            	        }
            	        break;
            	    case 5 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:55:38: 'f'
            	        {
            	        	Match('f'); 

            	        }
            	        break;
            	    case 6 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:55:42: 'r'
            	        {
            	        	Match('r'); 

            	        }
            	        break;
            	    case 7 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:55:46: '\\\"'
            	        {
            	        	Match('\"'); 

            	        }
            	        break;
            	    case 8 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:55:51: '\\''
            	        {
            	        	Match('\''); 

            	        }
            	        break;
            	    case 9 :
            	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:55:56: '\\\\'
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:59:2: ( 'u' HexDigit HexDigit HexDigit HexDigit )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:59:4: 'u' HexDigit HexDigit HexDigit HexDigit
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:63:2: ( '0' .. '9' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:63:4: '0' .. '9'
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:67:2: ( DecDigit | 'A' .. 'F' | 'a' .. 'f' )
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
        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:8: ( Integer | Float | QuotedString )
        int alt11 = 3;
        alt11 = dfa11.Predict(input);
        switch (alt11) 
        {
            case 1 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:10: Integer
                {
                	mInteger(); 

                }
                break;
            case 2 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:18: Float
                {
                	mFloat(); 

                }
                break;
            case 3 :
                // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:1:24: QuotedString
                {
                	mQuotedString(); 

                }
                break;

        }

    }


    protected DFA11 dfa11;
	private void InitializeCyclicDFAs()
	{
	    this.dfa11 = new DFA11(this);
	}

    const string DFA11_eotS =
        "\x02\uffff\x02\x05\x03\uffff";
    const string DFA11_eofS =
        "\x07\uffff";
    const string DFA11_minS =
        "\x01\x22\x01\x30\x02\x2e\x03\uffff";
    const string DFA11_maxS =
        "\x04\x39\x03\uffff";
    const string DFA11_acceptS =
        "\x04\uffff\x01\x03\x01\x01\x01\x02";
    const string DFA11_specialS =
        "\x07\uffff}>";
    static readonly string[] DFA11_transitionS = {
            "\x01\x04\x0a\uffff\x01\x01\x02\uffff\x01\x02\x09\x03",
            "\x0a\x03",
            "\x01\x06\x01\uffff\x0a\x03",
            "\x01\x06\x01\uffff\x0a\x03",
            "",
            "",
            ""
    };

    static readonly short[] DFA11_eot = DFA.UnpackEncodedString(DFA11_eotS);
    static readonly short[] DFA11_eof = DFA.UnpackEncodedString(DFA11_eofS);
    static readonly char[] DFA11_min = DFA.UnpackEncodedStringToUnsignedChars(DFA11_minS);
    static readonly char[] DFA11_max = DFA.UnpackEncodedStringToUnsignedChars(DFA11_maxS);
    static readonly short[] DFA11_accept = DFA.UnpackEncodedString(DFA11_acceptS);
    static readonly short[] DFA11_special = DFA.UnpackEncodedString(DFA11_specialS);
    static readonly short[][] DFA11_transition = DFA.UnpackEncodedStringArray(DFA11_transitionS);

    protected class DFA11 : DFA
    {
        public DFA11(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 11;
            this.eot = DFA11_eot;
            this.eof = DFA11_eof;
            this.min = DFA11_min;
            this.max = DFA11_max;
            this.accept = DFA11_accept;
            this.special = DFA11_special;
            this.transition = DFA11_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( Integer | Float | QuotedString );"; }
        }

    }

 
    
}
