// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g 2010-12-20 09:23:02

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


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
		"Integer", 
		"DecDigit", 
		"HexDigit", 
		"Float", 
		"Exponent", 
		"QuotedString", 
		"UnQuotedStringChars", 
		"Bool", 
		"EscapeSequence", 
		"UnicodeEscape", 
		"'{'", 
		"','", 
		"'}'", 
		"':'", 
		"'['", 
		"']'"
    };

    public const int INTEGER = 6;
    public const int Bool = 19;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int T__24 = 24;
    public const int T__23 = 23;
    public const int DOUBLE_QUOTE = 9;
    public const int T__22 = 22;
    public const int BOOL = 8;
    public const int Exponent = 16;
    public const int FLOAT = 7;
    public const int EOF = -1;
    public const int QuotedString = 17;
    public const int HexDigit = 14;
    public const int DecDigit = 13;
    public const int Float = 15;
    public const int SINGLE_QUOTE = 10;
    public const int UnicodeEscape = 21;
    public const int MAP = 11;
    public const int QUOTED_STRING = 4;
    public const int UnQuotedStringChars = 18;
    public const int UNQUOTED_STRING = 5;
    public const int EscapeSequence = 20;
    public const int Integer = 12;

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


    	private string ExtractString(CommonTree token) {
                var text = token.Text;
                if (text.StartsWith("\""))
                    text = text.Substring(1, text.Length - 2);
                return Regex.Replace(text, "\\\\([btnfr'\"\\\\])", x => {
                    switch (x.Groups[1].Value) {
                        case "b": return "\b";
                        case "t": return "\t";
                        case "n": return "\n";
                        case "f": return "\f";
                        case "r": return "\r";
                        case "'": return "'";
                        case "\"": return "\"";
                        case "\\": return "\\";
                        default: throw new InvalidOperationException("Can't ever get here");
                    }
                });
    	}
    	



    // $ANTLR start "value"
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:39:1: value returns [object result] : (b= boolean | i= integer | f= float_expr | s= string_expr | m= map | l= list );
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
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:40:2: (b= boolean | i= integer | f= float_expr | s= string_expr | m= map | l= list )
            int alt1 = 6;
            switch ( input.LA(1) ) 
            {
            case BOOL:
            	{
                alt1 = 1;
                }
                break;
            case INTEGER:
            	{
                alt1 = 2;
                }
                break;
            case FLOAT:
            	{
                alt1 = 3;
                }
                break;
            case QUOTED_STRING:
            	{
                alt1 = 4;
                }
                break;
            case 22:
            	{
                alt1 = 5;
                }
                break;
            case 26:
            	{
                alt1 = 6;
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
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:40:4: b= boolean
                    {
                    	PushFollow(FOLLOW_boolean_in_value62);
                    	b = boolean();
                    	state.followingStackPointer--;

                    	 result =  b; 

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:41:4: i= integer
                    {
                    	PushFollow(FOLLOW_integer_in_value71);
                    	i = integer();
                    	state.followingStackPointer--;

                    	 result =  i; 

                    }
                    break;
                case 3 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:42:4: f= float_expr
                    {
                    	PushFollow(FOLLOW_float_expr_in_value80);
                    	f = float_expr();
                    	state.followingStackPointer--;

                    	 result =  f; 

                    }
                    break;
                case 4 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:43:4: s= string_expr
                    {
                    	PushFollow(FOLLOW_string_expr_in_value89);
                    	s = string_expr();
                    	state.followingStackPointer--;

                    	 result =  s; 

                    }
                    break;
                case 5 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:44:4: m= map
                    {
                    	PushFollow(FOLLOW_map_in_value98);
                    	m = map();
                    	state.followingStackPointer--;

                    	 result =  m; 

                    }
                    break;
                case 6 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:45:4: l= list
                    {
                    	PushFollow(FOLLOW_list_in_value107);
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


    // $ANTLR start "boolean"
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:48:1: boolean returns [bool result] : ^( BOOL Bool ) ;
    public bool boolean() // throws RecognitionException [1]
    {   
        bool result = default(bool);

        CommonTree Bool1 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:49:2: ( ^( BOOL Bool ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:49:4: ^( BOOL Bool )
            {
            	Match(input,BOOL,FOLLOW_BOOL_in_boolean126); 

            	Match(input, Token.DOWN, null); 
            	Bool1=(CommonTree)Match(input,Bool,FOLLOW_Bool_in_boolean128); 

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:53:1: integer returns [int result] : ^( INTEGER Integer ) ;
    public int integer() // throws RecognitionException [1]
    {   
        int result = default(int);

        CommonTree Integer2 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:54:2: ( ^( INTEGER Integer ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:54:4: ^( INTEGER Integer )
            {
            	Match(input,INTEGER,FOLLOW_INTEGER_in_integer150); 

            	Match(input, Token.DOWN, null); 
            	Integer2=(CommonTree)Match(input,Integer,FOLLOW_Integer_in_integer152); 

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:58:1: float_expr returns [double result] : ^( FLOAT Float ) ;
    public double float_expr() // throws RecognitionException [1]
    {   
        double result = default(double);

        CommonTree Float3 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:59:2: ( ^( FLOAT Float ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:59:4: ^( FLOAT Float )
            {
            	Match(input,FLOAT,FOLLOW_FLOAT_in_float_expr174); 

            	Match(input, Token.DOWN, null); 
            	Float3=(CommonTree)Match(input,Float,FOLLOW_Float_in_float_expr176); 

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:63:1: string_expr returns [string result] : ^( QUOTED_STRING QuotedString ) ;
    public string string_expr() // throws RecognitionException [1]
    {   
        string result = default(string);

        CommonTree QuotedString4 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:64:2: ( ^( QUOTED_STRING QuotedString ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:64:4: ^( QUOTED_STRING QuotedString )
            {
            	Match(input,QUOTED_STRING,FOLLOW_QUOTED_STRING_in_string_expr199); 

            	Match(input, Token.DOWN, null); 
            	QuotedString4=(CommonTree)Match(input,QuotedString,FOLLOW_QuotedString_in_string_expr201); 

            	Match(input, Token.UP, null); 
            	 result =  ExtractString(QuotedString4); 

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:70:1: map returns [SortedDictionary<string, object> result] : '{' ( map_pair )+ '}' ;
    public SortedDictionary<string, object> map() // throws RecognitionException [1]
    {   
        map_stack.Push(new map_scope());
        SortedDictionary<string, object> result = default(SortedDictionary<string, object>);


        		((map_scope)map_stack.Peek()).dict =  new SortedDictionary<string, object>();
        	
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:80:2: ( '{' ( map_pair )+ '}' )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:80:4: '{' ( map_pair )+ '}'
            {
            	Match(input,22,FOLLOW_22_in_map241); 
            	// C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:80:8: ( map_pair )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == 25) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:80:8: map_pair
            			    {
            			    	PushFollow(FOLLOW_map_pair_in_map243);
            			    	map_pair();
            			    	state.followingStackPointer--;


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

            	Match(input,24,FOLLOW_24_in_map246); 

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:83:1: map_pair : ^( ':' key= string_expr val= value ) ;
    public void map_pair() // throws RecognitionException [1]
    {   
        string key = default(string);

        object val = default(object);


        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:84:2: ( ^( ':' key= string_expr val= value ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:84:4: ^( ':' key= string_expr val= value )
            {
            	Match(input,25,FOLLOW_25_in_map_pair260); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_string_expr_in_map_pair264);
            	key = string_expr();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_value_in_map_pair268);
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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:88:1: list returns [List<object> result] : '[' ( value )+ ']' ;
    public List<object> list() // throws RecognitionException [1]
    {   
        List<object> result = default(List<object>);

        object value5 = default(object);



        		result =  new List<object>();
        	
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:92:2: ( '[' ( value )+ ']' )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:92:4: '[' ( value )+ ']'
            {
            	Match(input,26,FOLLOW_26_in_list295); 
            	// C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:92:8: ( value )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == QUOTED_STRING || (LA3_0 >= INTEGER && LA3_0 <= BOOL) || LA3_0 == 22 || LA3_0 == 26) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:92:9: value
            			    {
            			    	PushFollow(FOLLOW_value_in_list298);
            			    	value5 = value();
            			    	state.followingStackPointer--;

            			    	 result.Add(value5); 

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

            	Match(input,27,FOLLOW_27_in_list304); 

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

 

    public static readonly BitSet FOLLOW_boolean_in_value62 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_integer_in_value71 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_float_expr_in_value80 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string_expr_in_value89 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_map_in_value98 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_list_in_value107 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_in_boolean126 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Bool_in_boolean128 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_INTEGER_in_integer150 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Integer_in_integer152 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_FLOAT_in_float_expr174 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Float_in_float_expr176 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_QUOTED_STRING_in_string_expr199 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_QuotedString_in_string_expr201 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_22_in_map241 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_map_pair_in_map243 = new BitSet(new ulong[]{0x0000000003000000UL});
    public static readonly BitSet FOLLOW_24_in_map246 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_25_in_map_pair260 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_string_expr_in_map_pair264 = new BitSet(new ulong[]{0x00000000044001D0UL});
    public static readonly BitSet FOLLOW_value_in_map_pair268 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_26_in_list295 = new BitSet(new ulong[]{0x00000000044001D0UL});
    public static readonly BitSet FOLLOW_value_in_list298 = new BitSet(new ulong[]{0x000000000C4001D0UL});
    public static readonly BitSet FOLLOW_27_in_list304 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}