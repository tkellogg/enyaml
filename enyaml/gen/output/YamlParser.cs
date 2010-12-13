// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g 2010-12-12 17:59:30

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
		"Exponent", 
		"QuotedString", 
		"UnQuotedStringChars", 
		"EscapeSequence", 
		"UnicodeEscape"
    };

    public const int INTEGER = 6;
    public const int DOUBLE_QUOTE = 8;
    public const int NULL = 12;
    public const int Exponent = 17;
    public const int FLOAT = 7;
    public const int EOF = -1;
    public const int QuotedString = 18;
    public const int TRUE = 10;
    public const int HexDigit = 15;
    public const int DecDigit = 14;
    public const int Float = 16;
    public const int SINGLE_QUOTE = 9;
    public const int UnicodeEscape = 21;
    public const int QUOTED_STRING = 4;
    public const int UnQuotedStringChars = 19;
    public const int UNQUOTED_STRING = 5;
    public const int FALSE = 11;
    public const int EscapeSequence = 20;
    public const int Integer = 13;

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


    public class value_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "value"
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:15:1: value : ( integer | float_expr | string_expr );
    public YamlParser.value_return value() // throws RecognitionException [1]
    {   
        YamlParser.value_return retval = new YamlParser.value_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        YamlParser.integer_return integer1 = default(YamlParser.integer_return);

        YamlParser.float_expr_return float_expr2 = default(YamlParser.float_expr_return);

        YamlParser.string_expr_return string_expr3 = default(YamlParser.string_expr_return);



        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:16:2: ( integer | float_expr | string_expr )
            int alt1 = 3;
            switch ( input.LA(1) ) 
            {
            case Integer:
            	{
                alt1 = 1;
                }
                break;
            case Float:
            	{
                alt1 = 2;
                }
                break;
            case QuotedString:
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
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:16:4: integer
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_integer_in_value70);
                    	integer1 = integer();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, integer1.Tree);

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:17:4: float_expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_float_expr_in_value76);
                    	float_expr2 = float_expr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, float_expr2.Tree);

                    }
                    break;
                case 3 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:18:4: string_expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_string_expr_in_value81);
                    	string_expr3 = string_expr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, string_expr3.Tree);

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
    // $ANTLR end "value"

    public class integer_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "integer"
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:20:1: integer : Integer -> ^( INTEGER Integer ) ;
    public YamlParser.integer_return integer() // throws RecognitionException [1]
    {   
        YamlParser.integer_return retval = new YamlParser.integer_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Integer4 = null;

        object Integer4_tree=null;
        RewriteRuleTokenStream stream_Integer = new RewriteRuleTokenStream(adaptor,"token Integer");

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:21:2: ( Integer -> ^( INTEGER Integer ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:21:4: Integer
            {
            	Integer4=(IToken)Match(input,Integer,FOLLOW_Integer_in_integer90);  
            	stream_Integer.Add(Integer4);



            	// AST REWRITE
            	// elements:          Integer
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 21:12: -> ^( INTEGER Integer )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:21:15: ^( INTEGER Integer )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(INTEGER, "INTEGER"), root_1);

            	    adaptor.AddChild(root_1, stream_Integer.NextNode());

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
    // $ANTLR end "integer"

    public class float_expr_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "float_expr"
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:29:1: float_expr : Float -> ^( FLOAT Float ) ;
    public YamlParser.float_expr_return float_expr() // throws RecognitionException [1]
    {   
        YamlParser.float_expr_return retval = new YamlParser.float_expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Float5 = null;

        object Float5_tree=null;
        RewriteRuleTokenStream stream_Float = new RewriteRuleTokenStream(adaptor,"token Float");

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:30:2: ( Float -> ^( FLOAT Float ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:30:4: Float
            {
            	Float5=(IToken)Match(input,Float,FOLLOW_Float_in_float_expr138);  
            	stream_Float.Add(Float5);



            	// AST REWRITE
            	// elements:          Float
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 30:10: -> ^( FLOAT Float )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:30:13: ^( FLOAT Float )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FLOAT, "FLOAT"), root_1);

            	    adaptor.AddChild(root_1, stream_Float.NextNode());

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
    // $ANTLR end "float_expr"

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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:41:1: string_expr : QuotedString -> ^( QUOTED_STRING QuotedString ) ;
    public YamlParser.string_expr_return string_expr() // throws RecognitionException [1]
    {   
        YamlParser.string_expr_return retval = new YamlParser.string_expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken QuotedString6 = null;

        object QuotedString6_tree=null;
        RewriteRuleTokenStream stream_QuotedString = new RewriteRuleTokenStream(adaptor,"token QuotedString");

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:42:2: ( QuotedString -> ^( QUOTED_STRING QuotedString ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:42:4: QuotedString
            {
            	QuotedString6=(IToken)Match(input,QuotedString,FOLLOW_QuotedString_in_string_expr214);  
            	stream_QuotedString.Add(QuotedString6);



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
            	// 42:17: -> ^( QUOTED_STRING QuotedString )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:42:20: ^( QUOTED_STRING QuotedString )
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
    // $ANTLR end "string_expr"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_integer_in_value70 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_float_expr_in_value76 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string_expr_in_value81 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Integer_in_integer90 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Float_in_float_expr138 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QuotedString_in_string_expr214 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}