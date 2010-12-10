// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g 2010-12-09 20:22:41

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

namespace  enyaml.parser 
{
public partial class YamlParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"QUOTED_STRING", 
		"UNQUOTED_STRING", 
		"DOUBLE_QUOTE", 
		"SINGLE_QUOTE", 
		"TRUE", 
		"FALSE", 
		"NULL", 
		"QuotedString", 
		"UnQuotedString", 
		"EscapeSequence", 
		"UnQuotedStringChars", 
		"UnicodeEscape", 
		"HexDigit"
    };

    public const int SINGLE_QUOTE = 7;
    public const int DOUBLE_QUOTE = 6;
    public const int UnicodeEscape = 15;
    public const int NULL = 10;
    public const int QUOTED_STRING = 4;
    public const int UnQuotedString = 12;
    public const int UnQuotedStringChars = 14;
    public const int UNQUOTED_STRING = 5;
    public const int QuotedString = 11;
    public const int FALSE = 9;
    public const int EOF = -1;
    public const int HexDigit = 16;
    public const int TRUE = 8;
    public const int EscapeSequence = 13;

    // delegates
    // delegators



        public YamlParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public YamlParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return YamlParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g"; }
    }


    public class string_expr_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "string_expr"
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:15:1: string_expr : ( QuotedString -> ^( QUOTED_STRING QuotedString ) | UnQuotedString -> ^( UNQUOTED_STRING UnQuotedString ) );
    public YamlParser.string_expr_return string_expr() // throws RecognitionException [1]
    {   
        YamlParser.string_expr_return retval = new YamlParser.string_expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken QuotedString1 = null;
        IToken UnQuotedString2 = null;

        object QuotedString1_tree=null;
        object UnQuotedString2_tree=null;
        RewriteRuleTokenStream stream_UnQuotedString = new RewriteRuleTokenStream(adaptor,"token UnQuotedString");
        RewriteRuleTokenStream stream_QuotedString = new RewriteRuleTokenStream(adaptor,"token QuotedString");

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:16:2: ( QuotedString -> ^( QUOTED_STRING QuotedString ) | UnQuotedString -> ^( UNQUOTED_STRING UnQuotedString ) )
            int alt1 = 2;
            int LA1_0 = input.LA(1);

            if ( (LA1_0 == QuotedString) )
            {
                alt1 = 1;
            }
            else if ( (LA1_0 == UnQuotedString) )
            {
                alt1 = 2;
            }
            else 
            {
                NoViableAltException nvae_d1s0 =
                    new NoViableAltException("", 1, 0, input);

                throw nvae_d1s0;
            }
            switch (alt1) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:16:4: QuotedString
                    {
                    	QuotedString1=(IToken)Match(input,QuotedString,FOLLOW_QuotedString_in_string_expr65);  
                    	stream_QuotedString.Add(QuotedString1);



                    	// AST REWRITE
                    	// elements:          QuotedString
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 16:17: -> ^( QUOTED_STRING QuotedString )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:16:20: ^( QUOTED_STRING QuotedString )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(QUOTED_STRING, "QUOTED_STRING"), root_1);

                    	    adaptor.AddChild(root_1, stream_QuotedString.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:17:4: UnQuotedString
                    {
                    	UnQuotedString2=(IToken)Match(input,UnQuotedString,FOLLOW_UnQuotedString_in_string_expr79);  
                    	stream_UnQuotedString.Add(UnQuotedString2);



                    	// AST REWRITE
                    	// elements:          UnQuotedString
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 17:19: -> ^( UNQUOTED_STRING UnQuotedString )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:17:22: ^( UNQUOTED_STRING UnQuotedString )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(UNQUOTED_STRING, "UNQUOTED_STRING"), root_1);

                    	    adaptor.AddChild(root_1, stream_UnQuotedString.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "string_expr"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_QuotedString_in_string_expr65 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UnQuotedString_in_string_expr79 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}