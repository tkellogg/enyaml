// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g 2011-01-02 20:13:39

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


namespace  enyaml.parser 
{
public partial class YamlTree : TreeParser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"QUOTED_STRING", 
		"UNQUOTED_STRING", 
		"INTEGER", 
		"FLOAT", 
		"BOOL", 
		"DOUBLE_QUOTE", 
		"SINGLE_QUOTE", 
		"MAP", 
		"LIST", 
		"INDENT", 
		"DEDENT", 
		"DENT", 
		"INDENTATION", 
		"LI", 
		"MI", 
		"NULL", 
		"Bool", 
		"NEWLINE", 
		"WS", 
		"COMMA", 
		"QUOT", 
		"LBRACKET", 
		"RBRACKET", 
		"LBRACE", 
		"RBRACE", 
		"DecDigit", 
		"HexDigit", 
		"Integer", 
		"Exponent", 
		"Float", 
		"FreeChars", 
		"UnQuotedString", 
		"QuotedStringChar", 
		"EscapeSequence", 
		"UnicodeEscape"
    };

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



        public YamlTree(ITreeNodeStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public YamlTree(ITreeNodeStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        

    override public string[] TokenNames {
		get { return YamlTree.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g"; }
    }



    // $ANTLR start "value"
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:15:1: value returns [object result] : (n= null_expr | b= boolean | i= integer | f= float_expr | s= string_expr | m= map | l= list );
    public object value() // throws RecognitionException [1]
    {   
        object result = default(object);

        bool b = default(bool);

        int i = default(int);

        double f = default(double);

        string s = default(string);

        SortedDictionary<string, object> m = default(SortedDictionary<string, object>);

        List<object> l = default(List<object>);


        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:16:2: (n= null_expr | b= boolean | i= integer | f= float_expr | s= string_expr | m= map | l= list )
            int alt1 = 7;
            switch ( input.LA(1) ) 
            {
            case NULL:
            	{
                alt1 = 1;
                }
                break;
            case BOOL:
            	{
                alt1 = 2;
                }
                break;
            case INTEGER:
            	{
                alt1 = 3;
                }
                break;
            case FLOAT:
            	{
                alt1 = 4;
                }
                break;
            case QUOTED_STRING:
            case UNQUOTED_STRING:
            	{
                alt1 = 5;
                }
                break;
            case MAP:
            	{
                alt1 = 6;
                }
                break;
            case LIST:
            	{
                alt1 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d1s0 =
            	        new NoViableAltException("", 1, 0, input);

            	    throw nvae_d1s0;
            }

            switch (alt1) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:16:4: n= null_expr
                    {
                    	PushFollow(FOLLOW_null_expr_in_value56);
                    	null_expr();
                    	state.followingStackPointer--;

                    	 result =  null; 

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:17:4: b= boolean
                    {
                    	PushFollow(FOLLOW_boolean_in_value65);
                    	b = boolean();
                    	state.followingStackPointer--;

                    	 result =  b; 

                    }
                    break;
                case 3 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:18:4: i= integer
                    {
                    	PushFollow(FOLLOW_integer_in_value74);
                    	i = integer();
                    	state.followingStackPointer--;

                    	 result =  i; 

                    }
                    break;
                case 4 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:19:4: f= float_expr
                    {
                    	PushFollow(FOLLOW_float_expr_in_value83);
                    	f = float_expr();
                    	state.followingStackPointer--;

                    	 result =  f; 

                    }
                    break;
                case 5 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:20:4: s= string_expr
                    {
                    	PushFollow(FOLLOW_string_expr_in_value92);
                    	s = string_expr();
                    	state.followingStackPointer--;

                    	 result =  s; 

                    }
                    break;
                case 6 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:21:4: m= map
                    {
                    	PushFollow(FOLLOW_map_in_value101);
                    	m = map();
                    	state.followingStackPointer--;

                    	 result =  m; 

                    }
                    break;
                case 7 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:22:4: l= list
                    {
                    	PushFollow(FOLLOW_list_in_value110);
                    	l = list();
                    	state.followingStackPointer--;

                    	 result =  l; 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return result;
    }
    // $ANTLR end "value"


    // $ANTLR start "null_expr"
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:25:1: null_expr : NULL ;
    public void null_expr() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:26:2: ( NULL )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:26:4: NULL
            {
            	Match(input,NULL,FOLLOW_NULL_in_null_expr125); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "null_expr"


    // $ANTLR start "boolean"
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:29:1: boolean returns [bool result] : ( ^( BOOL Bool ) | ^( BOOL UnQuotedString ) );
    public bool boolean() // throws RecognitionException [1]
    {   
        bool result = default(bool);

        CommonTree Bool1 = null;
        CommonTree UnQuotedString2 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:30:2: ( ^( BOOL Bool ) | ^( BOOL UnQuotedString ) )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == BOOL) )
            {
                int LA2_1 = input.LA(2);

                if ( (LA2_1 == DOWN) )
                {
                    int LA2_2 = input.LA(3);

                    if ( (LA2_2 == Bool) )
                    {
                        alt2 = 1;
                    }
                    else if ( (LA2_2 == UnQuotedString) )
                    {
                        alt2 = 2;
                    }
                    else 
                    {
                        NoViableAltException nvae_d2s2 =
                            new NoViableAltException("", 2, 2, input);

                        throw nvae_d2s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d2s1 =
                        new NoViableAltException("", 2, 1, input);

                    throw nvae_d2s1;
                }
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
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:30:4: ^( BOOL Bool )
                    {
                    	Match(input,BOOL,FOLLOW_BOOL_in_boolean142); 

                    	Match(input, Token.DOWN, null); 
                    	Bool1=(CommonTree)Match(input,Bool,FOLLOW_Bool_in_boolean144); 

                    	Match(input, Token.UP, null); 
                    	 result =  bool.Parse(Bool1.Text); 

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:32:4: ^( BOOL UnQuotedString )
                    {
                    	Match(input,BOOL,FOLLOW_BOOL_in_boolean155); 

                    	Match(input, Token.DOWN, null); 
                    	UnQuotedString2=(CommonTree)Match(input,UnQuotedString,FOLLOW_UnQuotedString_in_boolean157); 

                    	Match(input, Token.UP, null); 
                    	 result =  bool.Parse(UnQuotedString2.Text); 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return result;
    }
    // $ANTLR end "boolean"


    // $ANTLR start "integer"
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:36:1: integer returns [int result] : ^( INTEGER Integer ) ;
    public int integer() // throws RecognitionException [1]
    {   
        int result = default(int);

        CommonTree Integer3 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:37:2: ( ^( INTEGER Integer ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:37:4: ^( INTEGER Integer )
            {
            	Match(input,INTEGER,FOLLOW_INTEGER_in_integer179); 

            	Match(input, Token.DOWN, null); 
            	Integer3=(CommonTree)Match(input,Integer,FOLLOW_Integer_in_integer181); 

            	Match(input, Token.UP, null); 
            	 result =  int.Parse(Integer3.Text); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return result;
    }
    // $ANTLR end "integer"


    // $ANTLR start "float_expr"
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:41:1: float_expr returns [double result] : ^( FLOAT Float ) ;
    public double float_expr() // throws RecognitionException [1]
    {   
        double result = default(double);

        CommonTree Float4 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:42:2: ( ^( FLOAT Float ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:42:4: ^( FLOAT Float )
            {
            	Match(input,FLOAT,FOLLOW_FLOAT_in_float_expr203); 

            	Match(input, Token.DOWN, null); 
            	Float4=(CommonTree)Match(input,Float,FOLLOW_Float_in_float_expr205); 

            	Match(input, Token.UP, null); 
            	 result =  double.Parse(Float4.Text); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return result;
    }
    // $ANTLR end "float_expr"


    // $ANTLR start "string_expr"
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:46:1: string_expr returns [string result] : ( ^( QUOTED_STRING ( QuotedStringChar )* ) | ^( QUOTED_STRING UnQuotedString ) | ^( QUOTED_STRING Integer ) | ^( UNQUOTED_STRING UnQuotedString ) );
    public string string_expr() // throws RecognitionException [1]
    {   
        string result = default(string);

        CommonTree QuotedStringChar5 = null;
        CommonTree UnQuotedString6 = null;
        CommonTree Integer7 = null;
        CommonTree UnQuotedString8 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:47:2: ( ^( QUOTED_STRING ( QuotedStringChar )* ) | ^( QUOTED_STRING UnQuotedString ) | ^( QUOTED_STRING Integer ) | ^( UNQUOTED_STRING UnQuotedString ) )
            int alt4 = 4;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == QUOTED_STRING) )
            {
                int LA4_1 = input.LA(2);

                if ( (LA4_1 == DOWN) )
                {
                    switch ( input.LA(3) ) 
                    {
                    case UnQuotedString:
                    	{
                        alt4 = 2;
                        }
                        break;
                    case Integer:
                    	{
                        alt4 = 3;
                        }
                        break;
                    case UP:
                    case QuotedStringChar:
                    	{
                        alt4 = 1;
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d4s3 =
                    	        new NoViableAltException("", 4, 3, input);

                    	    throw nvae_d4s3;
                    }

                }
                else 
                {
                    NoViableAltException nvae_d4s1 =
                        new NoViableAltException("", 4, 1, input);

                    throw nvae_d4s1;
                }
            }
            else if ( (LA4_0 == UNQUOTED_STRING) )
            {
                alt4 = 4;
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
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:47:4: ^( QUOTED_STRING ( QuotedStringChar )* )
                    {
                    	Match(input,QUOTED_STRING,FOLLOW_QUOTED_STRING_in_string_expr228); 

                    	if ( input.LA(1) == Token.DOWN )
                    	{
                    	    Match(input, Token.DOWN, null); 
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:47:20: ( QuotedStringChar )*
                    	    do 
                    	    {
                    	        int alt3 = 2;
                    	        int LA3_0 = input.LA(1);

                    	        if ( (LA3_0 == QuotedStringChar) )
                    	        {
                    	            alt3 = 1;
                    	        }


                    	        switch (alt3) 
                    	    	{
                    	    		case 1 :
                    	    		    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:47:20: QuotedStringChar
                    	    		    {
                    	    		    	QuotedStringChar5=(CommonTree)Match(input,QuotedStringChar,FOLLOW_QuotedStringChar_in_string_expr230); 

                    	    		    }
                    	    		    break;

                    	    		default:
                    	    		    goto loop3;
                    	        }
                    	    } while (true);

                    	    loop3:
                    	    	;	// Stops C# compiler whining that label 'loop3' has no statements


                    	    Match(input, Token.UP, null); 
                    	}
                    	 result =  ExtractString(QuotedStringChar5); 

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:49:4: ^( QUOTED_STRING UnQuotedString )
                    {
                    	Match(input,QUOTED_STRING,FOLLOW_QUOTED_STRING_in_string_expr242); 

                    	Match(input, Token.DOWN, null); 
                    	UnQuotedString6=(CommonTree)Match(input,UnQuotedString,FOLLOW_UnQuotedString_in_string_expr244); 

                    	Match(input, Token.UP, null); 
                    	 result =  ExtractString(UnQuotedString6); 

                    }
                    break;
                case 3 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:51:4: ^( QUOTED_STRING Integer )
                    {
                    	Match(input,QUOTED_STRING,FOLLOW_QUOTED_STRING_in_string_expr255); 

                    	Match(input, Token.DOWN, null); 
                    	Integer7=(CommonTree)Match(input,Integer,FOLLOW_Integer_in_string_expr257); 

                    	Match(input, Token.UP, null); 
                    	 result =  ExtractString(Integer7); 

                    }
                    break;
                case 4 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:53:4: ^( UNQUOTED_STRING UnQuotedString )
                    {
                    	Match(input,UNQUOTED_STRING,FOLLOW_UNQUOTED_STRING_in_string_expr268); 

                    	Match(input, Token.DOWN, null); 
                    	UnQuotedString8=(CommonTree)Match(input,UnQuotedString,FOLLOW_UnQuotedString_in_string_expr270); 

                    	Match(input, Token.UP, null); 
                    	 result =  ExtractString(UnQuotedString8); 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return result;
    }
    // $ANTLR end "string_expr"

    protected class map_scope 
    {
        protected internal SortedDictionary<string, object> dict;
    }
    protected Stack map_stack = new Stack();


    // $ANTLR start "map"
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:57:1: map returns [SortedDictionary<string, object> result] : ^( MAP ( map_pair )+ ) ;
    public SortedDictionary<string, object> map() // throws RecognitionException [1]
    {   
        map_stack.Push(new map_scope());
        SortedDictionary<string, object> result = default(SortedDictionary<string, object>);


        		((map_scope)map_stack.Peek()).dict =  new SortedDictionary<string, object>();
        	
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:67:2: ( ^( MAP ( map_pair )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:67:4: ^( MAP ( map_pair )+ )
            {
            	Match(input,MAP,FOLLOW_MAP_in_map309); 

            	Match(input, Token.DOWN, null); 
            	// C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:67:10: ( map_pair )+
            	int cnt5 = 0;
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == MI) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:67:10: map_pair
            			    {
            			    	PushFollow(FOLLOW_map_pair_in_map311);
            			    	map_pair();
            			    	state.followingStackPointer--;


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


            	Match(input, Token.UP, null); 

            }


            		result = ((map_scope)map_stack.Peek()).dict;
            	
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            map_stack.Pop();
        }
        return result;
    }
    // $ANTLR end "map"


    // $ANTLR start "map_pair"
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:70:1: map_pair : ^( MI key= string_expr val= value ) ;
    public void map_pair() // throws RecognitionException [1]
    {   
        string key = default(string);

        object val = default(object);


        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:71:2: ( ^( MI key= string_expr val= value ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:71:4: ^( MI key= string_expr val= value )
            {
            	Match(input,MI,FOLLOW_MI_in_map_pair328); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_string_expr_in_map_pair332);
            	key = string_expr();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_value_in_map_pair336);
            	val = value();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 ((map_scope)map_stack.Peek()).dict.Add(key, val); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "map_pair"


    // $ANTLR start "list"
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:75:1: list returns [List<object> result] : ^( LIST ( value )+ ) ;
    public List<object> list() // throws RecognitionException [1]
    {   
        List<object> result = default(List<object>);

        object value9 = default(object);



        		result =  new List<object>();
        	
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:79:2: ( ^( LIST ( value )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:79:4: ^( LIST ( value )+ )
            {
            	Match(input,LIST,FOLLOW_LIST_in_list364); 

            	Match(input, Token.DOWN, null); 
            	// C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:79:11: ( value )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= QUOTED_STRING && LA6_0 <= BOOL) || (LA6_0 >= MAP && LA6_0 <= LIST) || LA6_0 == NULL) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:79:12: value
            			    {
            			    	PushFollow(FOLLOW_value_in_list367);
            			    	value9 = value();
            			    	state.followingStackPointer--;

            			    	 result.Add(value9); 

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


            	Match(input, Token.UP, null); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return result;
    }
    // $ANTLR end "list"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_null_expr_in_value56 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_boolean_in_value65 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_integer_in_value74 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_float_expr_in_value83 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string_expr_in_value92 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_map_in_value101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_list_in_value110 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_in_null_expr125 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_in_boolean142 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Bool_in_boolean144 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_BOOL_in_boolean155 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_UnQuotedString_in_boolean157 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_INTEGER_in_integer179 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Integer_in_integer181 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_FLOAT_in_float_expr203 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Float_in_float_expr205 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_QUOTED_STRING_in_string_expr228 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_QuotedStringChar_in_string_expr230 = new BitSet(new ulong[]{0x0000001000000008UL});
    public static readonly BitSet FOLLOW_QUOTED_STRING_in_string_expr242 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_UnQuotedString_in_string_expr244 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_QUOTED_STRING_in_string_expr255 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Integer_in_string_expr257 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_UNQUOTED_STRING_in_string_expr268 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_UnQuotedString_in_string_expr270 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MAP_in_map309 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_map_pair_in_map311 = new BitSet(new ulong[]{0x0000000000040008UL});
    public static readonly BitSet FOLLOW_MI_in_map_pair328 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_string_expr_in_map_pair332 = new BitSet(new ulong[]{0x00000000000819F0UL});
    public static readonly BitSet FOLLOW_value_in_map_pair336 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LIST_in_list364 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_value_in_list367 = new BitSet(new ulong[]{0x00000000000819F8UL});

}
}