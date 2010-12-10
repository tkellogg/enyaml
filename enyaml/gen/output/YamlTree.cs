// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g 2010-12-09 19:35:49

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
		"DOUBLE_QUOTE", 
		"SINGLE_QUOTE", 
		"TRUE", 
		"FALSE", 
		"NULL", 
		"QuotedString", 
		"EscapeSequence", 
		"UnicodeEscape", 
		"HexDigit"
    };

    public const int SINGLE_QUOTE = 6;
    public const int DOUBLE_QUOTE = 5;
    public const int UnicodeEscape = 12;
    public const int NULL = 9;
    public const int QUOTED_STRING = 4;
    public const int FALSE = 8;
    public const int QuotedString = 10;
    public const int EOF = -1;
    public const int TRUE = 7;
    public const int HexDigit = 13;
    public const int EscapeSequence = 11;

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
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:37:1: value returns [object result] : s= string_expr ;
    public object value() // throws RecognitionException [1]
    {   
        object result = default(object);

        string s = default(string);


        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:38:2: (s= string_expr )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:38:4: s= string_expr
            {
            	PushFollow(FOLLOW_string_expr_in_value62);
            	s = string_expr();
            	state.followingStackPointer--;

            	 result =  s; 

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


    // $ANTLR start "string_expr"
    // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:41:1: string_expr returns [string result] : ^( QUOTED_STRING QuotedString ) ;
    public string string_expr() // throws RecognitionException [1]
    {   
        string result = default(string);

        CommonTree QuotedString1 = null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:42:2: ( ^( QUOTED_STRING QuotedString ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\YamlTree.g:42:4: ^( QUOTED_STRING QuotedString )
            {
            	Match(input,QUOTED_STRING,FOLLOW_QUOTED_STRING_in_string_expr82); 

            	Match(input, Token.DOWN, null); 
            	QuotedString1=(CommonTree)Match(input,QuotedString,FOLLOW_QuotedString_in_string_expr84); 

            	Match(input, Token.UP, null); 
            	 result =  ExtractString(QuotedString1); 

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

 

    public static readonly BitSet FOLLOW_string_expr_in_value62 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QUOTED_STRING_in_string_expr82 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_QuotedString_in_string_expr84 = new BitSet(new ulong[]{0x0000000000000008UL});

}
}