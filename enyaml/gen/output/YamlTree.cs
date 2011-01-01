// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g 2011-01-01 14:29:00

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:29:1: boolean returns [bool result] : ^( BOOL Bool ) ;
    public bool boolean() // throws RecognitionException [1]
    {   
        bool result = default(bool);

        CommonTree Bool1 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:30:2: ( ^( BOOL Bool ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:30:4: ^( BOOL Bool )
            {
            	Match(input,BOOL,FOLLOW_BOOL_in_boolean142); 

            	Match(input, Token.DOWN, null); 
            	Bool1=(CommonTree)Match(input,Bool,FOLLOW_Bool_in_boolean144); 

            	Match(input, Token.UP, null); 
            	 result =  bool.Parse(Bool1.Text); 

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:34:1: integer returns [int result] : ^( INTEGER Integer ) ;
    public int integer() // throws RecognitionException [1]
    {   
        int result = default(int);

        CommonTree Integer2 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:35:2: ( ^( INTEGER Integer ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:35:4: ^( INTEGER Integer )
            {
            	Match(input,INTEGER,FOLLOW_INTEGER_in_integer166); 

            	Match(input, Token.DOWN, null); 
            	Integer2=(CommonTree)Match(input,Integer,FOLLOW_Integer_in_integer168); 

            	Match(input, Token.UP, null); 
            	 result =  int.Parse(Integer2.Text); 

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:39:1: float_expr returns [double result] : ^( FLOAT Float ) ;
    public double float_expr() // throws RecognitionException [1]
    {   
        double result = default(double);

        CommonTree Float3 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:40:2: ( ^( FLOAT Float ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:40:4: ^( FLOAT Float )
            {
            	Match(input,FLOAT,FOLLOW_FLOAT_in_float_expr190); 

            	Match(input, Token.DOWN, null); 
            	Float3=(CommonTree)Match(input,Float,FOLLOW_Float_in_float_expr192); 

            	Match(input, Token.UP, null); 
            	 result =  double.Parse(Float3.Text); 

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:44:1: string_expr returns [string result] : ( ^( QUOTED_STRING ( QuotedStringChar )* ) | ^( QUOTED_STRING UnQuotedString ) | ^( QUOTED_STRING Integer ) | ^( UNQUOTED_STRING UnQuotedString ) );
    public string string_expr() // throws RecognitionException [1]
    {   
        string result = default(string);

        CommonTree QuotedStringChar4 = null;
        CommonTree UnQuotedString5 = null;
        CommonTree Integer6 = null;
        CommonTree UnQuotedString7 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:45:2: ( ^( QUOTED_STRING ( QuotedStringChar )* ) | ^( QUOTED_STRING UnQuotedString ) | ^( QUOTED_STRING Integer ) | ^( UNQUOTED_STRING UnQuotedString ) )
            int alt3 = 4;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == QUOTED_STRING) )
            {
                int LA3_1 = input.LA(2);

                if ( (LA3_1 == DOWN) )
                {
                    switch ( input.LA(3) ) 
                    {
                    case UnQuotedString:
                    	{
                        alt3 = 2;
                        }
                        break;
                    case Integer:
                    	{
                        alt3 = 3;
                        }
                        break;
                    case UP:
                    case QuotedStringChar:
                    	{
                        alt3 = 1;
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d3s3 =
                    	        new NoViableAltException("", 3, 3, input);

                    	    throw nvae_d3s3;
                    }

                }
                else 
                {
                    NoViableAltException nvae_d3s1 =
                        new NoViableAltException("", 3, 1, input);

                    throw nvae_d3s1;
                }
            }
            else if ( (LA3_0 == UNQUOTED_STRING) )
            {
                alt3 = 4;
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
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:45:4: ^( QUOTED_STRING ( QuotedStringChar )* )
                    {
                    	Match(input,QUOTED_STRING,FOLLOW_QUOTED_STRING_in_string_expr215); 

                    	if ( input.LA(1) == Token.DOWN )
                    	{
                    	    Match(input, Token.DOWN, null); 
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:45:20: ( QuotedStringChar )*
                    	    do 
                    	    {
                    	        int alt2 = 2;
                    	        int LA2_0 = input.LA(1);

                    	        if ( (LA2_0 == QuotedStringChar) )
                    	        {
                    	            alt2 = 1;
                    	        }


                    	        switch (alt2) 
                    	    	{
                    	    		case 1 :
                    	    		    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:45:20: QuotedStringChar
                    	    		    {
                    	    		    	QuotedStringChar4=(CommonTree)Match(input,QuotedStringChar,FOLLOW_QuotedStringChar_in_string_expr217); 

                    	    		    }
                    	    		    break;

                    	    		default:
                    	    		    goto loop2;
                    	        }
                    	    } while (true);

                    	    loop2:
                    	    	;	// Stops C# compiler whining that label 'loop2' has no statements


                    	    Match(input, Token.UP, null); 
                    	}
                    	 result =  ExtractString(QuotedStringChar4); 

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:47:4: ^( QUOTED_STRING UnQuotedString )
                    {
                    	Match(input,QUOTED_STRING,FOLLOW_QUOTED_STRING_in_string_expr229); 

                    	Match(input, Token.DOWN, null); 
                    	UnQuotedString5=(CommonTree)Match(input,UnQuotedString,FOLLOW_UnQuotedString_in_string_expr231); 

                    	Match(input, Token.UP, null); 
                    	 result =  ExtractString(UnQuotedString5); 

                    }
                    break;
                case 3 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:49:4: ^( QUOTED_STRING Integer )
                    {
                    	Match(input,QUOTED_STRING,FOLLOW_QUOTED_STRING_in_string_expr242); 

                    	Match(input, Token.DOWN, null); 
                    	Integer6=(CommonTree)Match(input,Integer,FOLLOW_Integer_in_string_expr244); 

                    	Match(input, Token.UP, null); 
                    	 result =  ExtractString(Integer6); 

                    }
                    break;
                case 4 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:51:4: ^( UNQUOTED_STRING UnQuotedString )
                    {
                    	Match(input,UNQUOTED_STRING,FOLLOW_UNQUOTED_STRING_in_string_expr255); 

                    	Match(input, Token.DOWN, null); 
                    	UnQuotedString7=(CommonTree)Match(input,UnQuotedString,FOLLOW_UnQuotedString_in_string_expr257); 

                    	Match(input, Token.UP, null); 
                    	 result =  ExtractString(UnQuotedString7); 

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:55:1: map returns [SortedDictionary<string, object> result] : ^( MAP ( map_pair )+ ) ;
    public SortedDictionary<string, object> map() // throws RecognitionException [1]
    {   
        map_stack.Push(new map_scope());
        SortedDictionary<string, object> result = default(SortedDictionary<string, object>);


        		((map_scope)map_stack.Peek()).dict =  new SortedDictionary<string, object>();
        	
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:65:2: ( ^( MAP ( map_pair )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:65:4: ^( MAP ( map_pair )+ )
            {
            	Match(input,MAP,FOLLOW_MAP_in_map296); 

            	Match(input, Token.DOWN, null); 
            	// C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:65:10: ( map_pair )+
            	int cnt4 = 0;
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == MI) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:65:10: map_pair
            			    {
            			    	PushFollow(FOLLOW_map_pair_in_map298);
            			    	map_pair();
            			    	state.followingStackPointer--;


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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:68:1: map_pair : ^( MI key= string_expr val= value ) ;
    public void map_pair() // throws RecognitionException [1]
    {   
        string key = default(string);

        object val = default(object);


        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:69:2: ( ^( MI key= string_expr val= value ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:69:4: ^( MI key= string_expr val= value )
            {
            	Match(input,MI,FOLLOW_MI_in_map_pair315); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_string_expr_in_map_pair319);
            	key = string_expr();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_value_in_map_pair323);
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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:73:1: list returns [List<object> result] : ^( LIST ( value )+ ) ;
    public List<object> list() // throws RecognitionException [1]
    {   
        List<object> result = default(List<object>);

        object value8 = default(object);



        		result =  new List<object>();
        	
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:77:2: ( ^( LIST ( value )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:77:4: ^( LIST ( value )+ )
            {
            	Match(input,LIST,FOLLOW_LIST_in_list351); 

            	Match(input, Token.DOWN, null); 
            	// C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:77:11: ( value )+
            	int cnt5 = 0;
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= QUOTED_STRING && LA5_0 <= BOOL) || (LA5_0 >= MAP && LA5_0 <= LIST) || LA5_0 == NULL) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:77:12: value
            			    {
            			    	PushFollow(FOLLOW_value_in_list354);
            			    	value8 = value();
            			    	state.followingStackPointer--;

            			    	 result.Add(value8); 

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
    public static readonly BitSet FOLLOW_INTEGER_in_integer166 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Integer_in_integer168 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_FLOAT_in_float_expr190 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Float_in_float_expr192 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_QUOTED_STRING_in_string_expr215 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_QuotedStringChar_in_string_expr217 = new BitSet(new ulong[]{0x0000001000000008UL});
    public static readonly BitSet FOLLOW_QUOTED_STRING_in_string_expr229 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_UnQuotedString_in_string_expr231 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_QUOTED_STRING_in_string_expr242 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Integer_in_string_expr244 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_UNQUOTED_STRING_in_string_expr255 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_UnQuotedString_in_string_expr257 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MAP_in_map296 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_map_pair_in_map298 = new BitSet(new ulong[]{0x0000000000040008UL});
    public static readonly BitSet FOLLOW_MI_in_map_pair315 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_string_expr_in_map_pair319 = new BitSet(new ulong[]{0x00000000000819F0UL});
    public static readonly BitSet FOLLOW_value_in_map_pair323 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LIST_in_list351 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_value_in_list354 = new BitSet(new ulong[]{0x00000000000819F8UL});

}
}