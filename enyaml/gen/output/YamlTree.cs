// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g 2010-12-12 18:50:57

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


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
		"Integer", 
		"DecDigit", 
		"HexDigit", 
		"Float", 
		"Exponent", 
		"QuotedString", 
		"UnQuotedStringChars", 
		"Bool", 
		"EscapeSequence", 
		"UnicodeEscape"
    };

    public const int INTEGER = 6;
    public const int Bool = 18;
    public const int DOUBLE_QUOTE = 9;
    public const int BOOL = 8;
    public const int Exponent = 15;
    public const int FLOAT = 7;
    public const int EOF = -1;
    public const int QuotedString = 16;
    public const int HexDigit = 13;
    public const int DecDigit = 12;
    public const int Float = 14;
    public const int SINGLE_QUOTE = 10;
    public const int UnicodeEscape = 20;
    public const int QUOTED_STRING = 4;
    public const int UnQuotedStringChars = 17;
    public const int UNQUOTED_STRING = 5;
    public const int EscapeSequence = 19;
    public const int Integer = 11;

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:37:1: value returns [object result] : (b= boolean | i= integer | f= float_expr | s= string_expr );
    public object value() // throws RecognitionException [1]
    {   
        object result = default(object);

        bool b = default(bool);

        int i = default(int);

        double f = default(double);

        string s = default(string);


        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:38:2: (b= boolean | i= integer | f= float_expr | s= string_expr )
            int alt1 = 4;
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
            	default:
            	    NoViableAltException nvae_d1s0 =
            	        new NoViableAltException("", 1, 0, input);

            	    throw nvae_d1s0;
            }

            switch (alt1) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:38:4: b= boolean
                    {
                    	PushFollow(FOLLOW_boolean_in_value62);
                    	b = boolean();
                    	state.followingStackPointer--;

                    	 result =  b; 

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:39:4: i= integer
                    {
                    	PushFollow(FOLLOW_integer_in_value71);
                    	i = integer();
                    	state.followingStackPointer--;

                    	 result =  i; 

                    }
                    break;
                case 3 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:40:4: f= float_expr
                    {
                    	PushFollow(FOLLOW_float_expr_in_value80);
                    	f = float_expr();
                    	state.followingStackPointer--;

                    	 result =  f; 

                    }
                    break;
                case 4 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:41:4: s= string_expr
                    {
                    	PushFollow(FOLLOW_string_expr_in_value89);
                    	s = string_expr();
                    	state.followingStackPointer--;

                    	 result =  s; 

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:44:1: boolean returns [bool result] : ^( BOOL Bool ) ;
    public bool boolean() // throws RecognitionException [1]
    {   
        bool result = default(bool);

        CommonTree Bool1 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:45:2: ( ^( BOOL Bool ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:45:4: ^( BOOL Bool )
            {
            	Match(input,BOOL,FOLLOW_BOOL_in_boolean108); 

            	Match(input, Token.DOWN, null); 
            	Bool1=(CommonTree)Match(input,Bool,FOLLOW_Bool_in_boolean110); 

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:49:1: integer returns [int result] : ^( INTEGER Integer ) ;
    public int integer() // throws RecognitionException [1]
    {   
        int result = default(int);

        CommonTree Integer2 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:50:2: ( ^( INTEGER Integer ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:50:4: ^( INTEGER Integer )
            {
            	Match(input,INTEGER,FOLLOW_INTEGER_in_integer132); 

            	Match(input, Token.DOWN, null); 
            	Integer2=(CommonTree)Match(input,Integer,FOLLOW_Integer_in_integer134); 

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:54:1: float_expr returns [double result] : ^( FLOAT Float ) ;
    public double float_expr() // throws RecognitionException [1]
    {   
        double result = default(double);

        CommonTree Float3 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:55:2: ( ^( FLOAT Float ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:55:4: ^( FLOAT Float )
            {
            	Match(input,FLOAT,FOLLOW_FLOAT_in_float_expr156); 

            	Match(input, Token.DOWN, null); 
            	Float3=(CommonTree)Match(input,Float,FOLLOW_Float_in_float_expr158); 

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:59:1: string_expr returns [string result] : ^( QUOTED_STRING QuotedString ) ;
    public string string_expr() // throws RecognitionException [1]
    {   
        string result = default(string);

        CommonTree QuotedString4 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:60:2: ( ^( QUOTED_STRING QuotedString ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:60:4: ^( QUOTED_STRING QuotedString )
            {
            	Match(input,QUOTED_STRING,FOLLOW_QUOTED_STRING_in_string_expr181); 

            	Match(input, Token.DOWN, null); 
            	QuotedString4=(CommonTree)Match(input,QuotedString,FOLLOW_QuotedString_in_string_expr183); 

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

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_boolean_in_value62 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_integer_in_value71 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_float_expr_in_value80 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string_expr_in_value89 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOL_in_boolean108 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Bool_in_boolean110 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_INTEGER_in_integer132 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Integer_in_integer134 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_FLOAT_in_float_expr156 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Float_in_float_expr158 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_QUOTED_STRING_in_string_expr181 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_QuotedString_in_string_expr183 = new BitSet(new ulong[]{0x0000000000000008UL});

}
}