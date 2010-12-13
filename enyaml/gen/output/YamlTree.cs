// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g 2010-12-12 17:50:31

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
		"DOUBLE_QUOTE", 
		"SINGLE_QUOTE", 
		"TRUE", 
		"FALSE", 
		"NULL", 
		"Integer", 
		"DecDigit", 
		"HexDigit", 
		"Float", 
		"QuotedString", 
		"UnQuotedStringChars", 
		"EscapeSequence", 
		"UnicodeEscape"
    };

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:37:1: value returns [object result] : (i= integer | f= float_expr | s= string_expr );
    public object value() // throws RecognitionException [1]
    {   
        object result = default(object);

        int i = default(int);

        double f = default(double);

        string s = default(string);


        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:38:2: (i= integer | f= float_expr | s= string_expr )
            int alt1 = 3;
            switch ( input.LA(1) ) 
            {
            case INTEGER:
            	{
                alt1 = 1;
                }
                break;
            case FLOAT:
            	{
                alt1 = 2;
                }
                break;
            case QUOTED_STRING:
            	{
                alt1 = 3;
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
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:38:4: i= integer
                    {
                    	PushFollow(FOLLOW_integer_in_value62);
                    	i = integer();
                    	state.followingStackPointer--;

                    	 result =  i; 

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:39:4: f= float_expr
                    {
                    	PushFollow(FOLLOW_float_expr_in_value71);
                    	f = float_expr();
                    	state.followingStackPointer--;

                    	 result =  f; 

                    }
                    break;
                case 3 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:40:4: s= string_expr
                    {
                    	PushFollow(FOLLOW_string_expr_in_value80);
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


    // $ANTLR start "integer"
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:43:1: integer returns [int result] : ^( INTEGER Integer ) ;
    public int integer() // throws RecognitionException [1]
    {   
        int result = default(int);

        CommonTree Integer1 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:44:2: ( ^( INTEGER Integer ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:44:4: ^( INTEGER Integer )
            {
            	Match(input,INTEGER,FOLLOW_INTEGER_in_integer99); 

            	Match(input, Token.DOWN, null); 
            	Integer1=(CommonTree)Match(input,Integer,FOLLOW_Integer_in_integer101); 

            	Match(input, Token.UP, null); 
            	 result =  int.Parse(Integer1.Text); 

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:48:1: float_expr returns [double result] : ^( FLOAT Float ) ;
    public double float_expr() // throws RecognitionException [1]
    {   
        double result = default(double);

        CommonTree Float2 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:49:2: ( ^( FLOAT Float ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:49:4: ^( FLOAT Float )
            {
            	Match(input,FLOAT,FOLLOW_FLOAT_in_float_expr123); 

            	Match(input, Token.DOWN, null); 
            	Float2=(CommonTree)Match(input,Float,FOLLOW_Float_in_float_expr125); 

            	Match(input, Token.UP, null); 
            	 result =  double.Parse(Float2.Text); 

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:53:1: string_expr returns [string result] : ^( QUOTED_STRING QuotedString ) ;
    public string string_expr() // throws RecognitionException [1]
    {   
        string result = default(string);

        CommonTree QuotedString3 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:54:2: ( ^( QUOTED_STRING QuotedString ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:54:4: ^( QUOTED_STRING QuotedString )
            {
            	Match(input,QUOTED_STRING,FOLLOW_QUOTED_STRING_in_string_expr148); 

            	Match(input, Token.DOWN, null); 
            	QuotedString3=(CommonTree)Match(input,QuotedString,FOLLOW_QuotedString_in_string_expr150); 

            	Match(input, Token.UP, null); 
            	 result =  ExtractString(QuotedString3); 

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

 

    public static readonly BitSet FOLLOW_integer_in_value62 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_float_expr_in_value71 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string_expr_in_value80 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INTEGER_in_integer99 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Integer_in_integer101 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_FLOAT_in_float_expr123 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Float_in_float_expr125 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_QUOTED_STRING_in_string_expr148 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_QuotedString_in_string_expr150 = new BitSet(new ulong[]{0x0000000000000008UL});

}
}