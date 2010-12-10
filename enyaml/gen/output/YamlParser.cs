// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g 2010-12-09 19:20:36

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
    public const int QuotedString = 10;
    public const int FALSE = 8;
    public const int EOF = -1;
    public const int HexDigit = 13;
    public const int TRUE = 7;
    public const int EscapeSequence = 11;

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


    public class quoted_string_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "quoted_string"
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:15:1: quoted_string : QuotedString -> ^( QUOTED_STRING QuotedString ) ;
    public YamlParser.quoted_string_return quoted_string() // throws RecognitionException [1]
    {   
        YamlParser.quoted_string_return retval = new YamlParser.quoted_string_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken QuotedString1 = null;

        object QuotedString1_tree=null;
        RewriteRuleTokenStream stream_QuotedString = new RewriteRuleTokenStream(adaptor,"token QuotedString");

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:15:15: ( QuotedString -> ^( QUOTED_STRING QuotedString ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:15:17: QuotedString
            {
            	QuotedString1=(IToken)Match(input,QuotedString,FOLLOW_QuotedString_in_quoted_string60);  
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
            	// 16:2: -> ^( QUOTED_STRING QuotedString )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:16:5: ^( QUOTED_STRING QuotedString )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(QUOTED_STRING, "QUOTED_STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_QuotedString.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "quoted_string"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_QuotedString_in_quoted_string60 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}