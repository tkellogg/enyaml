// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g 2011-01-01 11:44:12

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
		"BOOL", 
		"DOUBLE_QUOTE", 
		"SINGLE_QUOTE", 
		"MAP", 
		"LIST", 
		"INDENT", 
		"DEDENT", 
		"DENT", 
		"INDENTATION", 
		"Bool", 
		"NULL", 
		"Integer", 
		"DecDigit", 
		"HexDigit", 
		"LI", 
		"Float", 
		"Exponent", 
		"QuotedString", 
		"UnQuotedString", 
		"UnQuotedStringChars", 
		"NEWLINE", 
		"FreeChars", 
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
    public const int Bool = 17;
    public const int FreeChars = 29;
    public const int DOUBLE_QUOTE = 9;
    public const int NULL = 18;
    public const int BOOL = 8;
    public const int Exponent = 24;
    public const int UnQuotedString = 26;
    public const int DEDENT = 14;
    public const int FLOAT = 7;
    public const int QuotedString = 25;
    public const int EOF = -1;
    public const int LIST = 12;
    public const int HexDigit = 21;
    public const int DecDigit = 20;
    public const int INDENT = 13;
    public const int Float = 23;
    public const int SINGLE_QUOTE = 10;
    public const int T__32 = 32;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int NEWLINE = 28;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int DENT = 15;
    public const int UnicodeEscape = 31;
    public const int MAP = 11;
    public const int QUOTED_STRING = 4;
    public const int UnQuotedStringChars = 27;
    public const int LI = 22;
    public const int UNQUOTED_STRING = 5;
    public const int EscapeSequence = 30;
    public const int Integer = 19;
    public const int INDENTATION = 16;

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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:37:1: value : ( null_expr | boolean | integer | float_expr | string_expr | map | list );
    public YamlParser.value_return value() // throws RecognitionException [1]
    {   
        YamlParser.value_return retval = new YamlParser.value_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        YamlParser.null_expr_return null_expr1 = default(YamlParser.null_expr_return);

        YamlParser.boolean_return boolean2 = default(YamlParser.boolean_return);

        YamlParser.integer_return integer3 = default(YamlParser.integer_return);

        YamlParser.float_expr_return float_expr4 = default(YamlParser.float_expr_return);

        YamlParser.string_expr_return string_expr5 = default(YamlParser.string_expr_return);

        YamlParser.map_return map6 = default(YamlParser.map_return);

        YamlParser.list_return list7 = default(YamlParser.list_return);



        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:38:2: ( null_expr | boolean | integer | float_expr | string_expr | map | list )
            int alt1 = 7;
            alt1 = dfa1.Predict(input);
            switch (alt1) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:38:4: null_expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_null_expr_in_value142);
                    	null_expr1 = null_expr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, null_expr1.Tree);

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:39:4: boolean
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_boolean_in_value147);
                    	boolean2 = boolean();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, boolean2.Tree);

                    }
                    break;
                case 3 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:40:4: integer
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_integer_in_value152);
                    	integer3 = integer();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, integer3.Tree);

                    }
                    break;
                case 4 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:41:4: float_expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_float_expr_in_value158);
                    	float_expr4 = float_expr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, float_expr4.Tree);

                    }
                    break;
                case 5 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:42:4: string_expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_string_expr_in_value163);
                    	string_expr5 = string_expr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, string_expr5.Tree);

                    }
                    break;
                case 6 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:43:4: map
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_map_in_value168);
                    	map6 = map();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, map6.Tree);

                    }
                    break;
                case 7 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:44:4: list
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_list_in_value173);
                    	list7 = list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, list7.Tree);

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

    public class boolean_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "boolean"
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:47:1: boolean : Bool -> ^( BOOL Bool ) ;
    public YamlParser.boolean_return boolean() // throws RecognitionException [1]
    {   
        YamlParser.boolean_return retval = new YamlParser.boolean_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Bool8 = null;

        object Bool8_tree=null;
        RewriteRuleTokenStream stream_Bool = new RewriteRuleTokenStream(adaptor,"token Bool");

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:48:2: ( Bool -> ^( BOOL Bool ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:48:4: Bool
            {
            	Bool8=(IToken)Match(input,Bool,FOLLOW_Bool_in_boolean186);  
            	stream_Bool.Add(Bool8);



            	// AST REWRITE
            	// elements:          Bool
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 48:9: -> ^( BOOL Bool )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:48:12: ^( BOOL Bool )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BOOL, "BOOL"), root_1);

            	    adaptor.AddChild(root_1, stream_Bool.NextNode());

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
    // $ANTLR end "boolean"

    public class null_expr_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "null_expr"
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:55:1: null_expr : NULL ;
    public YamlParser.null_expr_return null_expr() // throws RecognitionException [1]
    {   
        YamlParser.null_expr_return retval = new YamlParser.null_expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NULL9 = null;

        object NULL9_tree=null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:56:2: ( NULL )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:56:4: NULL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	NULL9=(IToken)Match(input,NULL,FOLLOW_NULL_in_null_expr221); 
            		NULL9_tree = (object)adaptor.Create(NULL9);
            		adaptor.AddChild(root_0, NULL9_tree);


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
    // $ANTLR end "null_expr"

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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:61:1: integer : Integer -> ^( INTEGER Integer ) ;
    public YamlParser.integer_return integer() // throws RecognitionException [1]
    {   
        YamlParser.integer_return retval = new YamlParser.integer_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Integer10 = null;

        object Integer10_tree=null;
        RewriteRuleTokenStream stream_Integer = new RewriteRuleTokenStream(adaptor,"token Integer");

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:62:2: ( Integer -> ^( INTEGER Integer ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:62:4: Integer
            {
            	Integer10=(IToken)Match(input,Integer,FOLLOW_Integer_in_integer241);  
            	stream_Integer.Add(Integer10);



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
            	// 62:12: -> ^( INTEGER Integer )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:62:15: ^( INTEGER Integer )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:74:1: float_expr : Float -> ^( FLOAT Float ) ;
    public YamlParser.float_expr_return float_expr() // throws RecognitionException [1]
    {   
        YamlParser.float_expr_return retval = new YamlParser.float_expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Float11 = null;

        object Float11_tree=null;
        RewriteRuleTokenStream stream_Float = new RewriteRuleTokenStream(adaptor,"token Float");

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:75:2: ( Float -> ^( FLOAT Float ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:75:4: Float
            {
            	Float11=(IToken)Match(input,Float,FOLLOW_Float_in_float_expr301);  
            	stream_Float.Add(Float11);



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
            	// 75:10: -> ^( FLOAT Float )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:75:13: ^( FLOAT Float )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:86:1: string_expr : ( QuotedString -> ^( QUOTED_STRING QuotedString ) | UnQuotedString -> ^( UNQUOTED_STRING UnQuotedString ) );
    public YamlParser.string_expr_return string_expr() // throws RecognitionException [1]
    {   
        YamlParser.string_expr_return retval = new YamlParser.string_expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken QuotedString12 = null;
        IToken UnQuotedString13 = null;

        object QuotedString12_tree=null;
        object UnQuotedString13_tree=null;
        RewriteRuleTokenStream stream_UnQuotedString = new RewriteRuleTokenStream(adaptor,"token UnQuotedString");
        RewriteRuleTokenStream stream_QuotedString = new RewriteRuleTokenStream(adaptor,"token QuotedString");

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:87:2: ( QuotedString -> ^( QUOTED_STRING QuotedString ) | UnQuotedString -> ^( UNQUOTED_STRING UnQuotedString ) )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == QuotedString) )
            {
                alt2 = 1;
            }
            else if ( (LA2_0 == UnQuotedString) )
            {
                alt2 = 2;
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
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:87:4: QuotedString
                    {
                    	QuotedString12=(IToken)Match(input,QuotedString,FOLLOW_QuotedString_in_string_expr377);  
                    	stream_QuotedString.Add(QuotedString12);



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
                    	// 87:17: -> ^( QUOTED_STRING QuotedString )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:87:20: ^( QUOTED_STRING QuotedString )
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
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:88:4: UnQuotedString
                    {
                    	UnQuotedString13=(IToken)Match(input,UnQuotedString,FOLLOW_UnQuotedString_in_string_expr391);  
                    	stream_UnQuotedString.Add(UnQuotedString13);



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
                    	// 88:19: -> ^( UNQUOTED_STRING UnQuotedString )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:88:22: ^( UNQUOTED_STRING UnQuotedString )
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

    public class flow_map_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "flow_map"
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:100:1: flow_map : '{' ( fskip )* map_pair ( fskip )* ( ',' ( fskip )* map_pair ( fskip )* )* '}' -> ^( MAP ( map_pair )+ ) ;
    public YamlParser.flow_map_return flow_map() // throws RecognitionException [1]
    {   
        YamlParser.flow_map_return retval = new YamlParser.flow_map_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal14 = null;
        IToken char_literal18 = null;
        IToken char_literal22 = null;
        YamlParser.fskip_return fskip15 = default(YamlParser.fskip_return);

        YamlParser.map_pair_return map_pair16 = default(YamlParser.map_pair_return);

        YamlParser.fskip_return fskip17 = default(YamlParser.fskip_return);

        YamlParser.fskip_return fskip19 = default(YamlParser.fskip_return);

        YamlParser.map_pair_return map_pair20 = default(YamlParser.map_pair_return);

        YamlParser.fskip_return fskip21 = default(YamlParser.fskip_return);


        object char_literal14_tree=null;
        object char_literal18_tree=null;
        object char_literal22_tree=null;
        RewriteRuleTokenStream stream_32 = new RewriteRuleTokenStream(adaptor,"token 32");
        RewriteRuleTokenStream stream_33 = new RewriteRuleTokenStream(adaptor,"token 33");
        RewriteRuleTokenStream stream_34 = new RewriteRuleTokenStream(adaptor,"token 34");
        RewriteRuleSubtreeStream stream_map_pair = new RewriteRuleSubtreeStream(adaptor,"rule map_pair");
        RewriteRuleSubtreeStream stream_fskip = new RewriteRuleSubtreeStream(adaptor,"rule fskip");

        	flowLvl++;
        	BlockLevel++;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:105:2: ( '{' ( fskip )* map_pair ( fskip )* ( ',' ( fskip )* map_pair ( fskip )* )* '}' -> ^( MAP ( map_pair )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:105:4: '{' ( fskip )* map_pair ( fskip )* ( ',' ( fskip )* map_pair ( fskip )* )* '}'
            {
            	char_literal14=(IToken)Match(input,32,FOLLOW_32_in_flow_map498);  
            	stream_32.Add(char_literal14);

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:105:8: ( fskip )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= INDENT && LA3_0 <= DEDENT) || LA3_0 == INDENTATION || LA3_0 == NEWLINE) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:105:8: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_flow_map500);
            			    	fskip15 = fskip();
            			    	state.followingStackPointer--;

            			    	stream_fskip.Add(fskip15.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	PushFollow(FOLLOW_map_pair_in_flow_map503);
            	map_pair16 = map_pair();
            	state.followingStackPointer--;

            	stream_map_pair.Add(map_pair16.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:105:24: ( fskip )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= INDENT && LA4_0 <= DEDENT) || LA4_0 == INDENTATION || LA4_0 == NEWLINE) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:105:24: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_flow_map505);
            			    	fskip17 = fskip();
            			    	state.followingStackPointer--;

            			    	stream_fskip.Add(fskip17.Tree);

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:105:31: ( ',' ( fskip )* map_pair ( fskip )* )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == 33) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:105:32: ',' ( fskip )* map_pair ( fskip )*
            			    {
            			    	char_literal18=(IToken)Match(input,33,FOLLOW_33_in_flow_map509);  
            			    	stream_33.Add(char_literal18);

            			    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:105:36: ( fskip )*
            			    	do 
            			    	{
            			    	    int alt5 = 2;
            			    	    int LA5_0 = input.LA(1);

            			    	    if ( ((LA5_0 >= INDENT && LA5_0 <= DEDENT) || LA5_0 == INDENTATION || LA5_0 == NEWLINE) )
            			    	    {
            			    	        alt5 = 1;
            			    	    }


            			    	    switch (alt5) 
            			    		{
            			    			case 1 :
            			    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:105:36: fskip
            			    			    {
            			    			    	PushFollow(FOLLOW_fskip_in_flow_map511);
            			    			    	fskip19 = fskip();
            			    			    	state.followingStackPointer--;

            			    			    	stream_fskip.Add(fskip19.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop5;
            			    	    }
            			    	} while (true);

            			    	loop5:
            			    		;	// Stops C# compiler whining that label 'loop5' has no statements

            			    	PushFollow(FOLLOW_map_pair_in_flow_map514);
            			    	map_pair20 = map_pair();
            			    	state.followingStackPointer--;

            			    	stream_map_pair.Add(map_pair20.Tree);
            			    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:105:52: ( fskip )*
            			    	do 
            			    	{
            			    	    int alt6 = 2;
            			    	    int LA6_0 = input.LA(1);

            			    	    if ( ((LA6_0 >= INDENT && LA6_0 <= DEDENT) || LA6_0 == INDENTATION || LA6_0 == NEWLINE) )
            			    	    {
            			    	        alt6 = 1;
            			    	    }


            			    	    switch (alt6) 
            			    		{
            			    			case 1 :
            			    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:105:52: fskip
            			    			    {
            			    			    	PushFollow(FOLLOW_fskip_in_flow_map516);
            			    			    	fskip21 = fskip();
            			    			    	state.followingStackPointer--;

            			    			    	stream_fskip.Add(fskip21.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop6;
            			    	    }
            			    	} while (true);

            			    	loop6:
            			    		;	// Stops C# compiler whining that label 'loop6' has no statements


            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

            	char_literal22=(IToken)Match(input,34,FOLLOW_34_in_flow_map522);  
            	stream_34.Add(char_literal22);



            	// AST REWRITE
            	// elements:          map_pair
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 106:3: -> ^( MAP ( map_pair )+ )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:106:6: ^( MAP ( map_pair )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(MAP, "MAP"), root_1);

            	    if ( !(stream_map_pair.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_map_pair.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_map_pair.NextTree());

            	    }
            	    stream_map_pair.Reset();

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

            	flowLvl--;
            	BlockLevel--;

        }
        return retval;
    }
    // $ANTLR end "flow_map"

    public class block_map_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "block_map"
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:113:1: block_map : INDENT DENT map_pair ( NEWLINE DENT map_pair )* DEDENT -> ^( MAP ( map_pair )+ ) ;
    public YamlParser.block_map_return block_map() // throws RecognitionException [1]
    {   
        YamlParser.block_map_return retval = new YamlParser.block_map_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INDENT23 = null;
        IToken DENT24 = null;
        IToken NEWLINE26 = null;
        IToken DENT27 = null;
        IToken DEDENT29 = null;
        YamlParser.map_pair_return map_pair25 = default(YamlParser.map_pair_return);

        YamlParser.map_pair_return map_pair28 = default(YamlParser.map_pair_return);


        object INDENT23_tree=null;
        object DENT24_tree=null;
        object NEWLINE26_tree=null;
        object DENT27_tree=null;
        object DEDENT29_tree=null;
        RewriteRuleTokenStream stream_DEDENT = new RewriteRuleTokenStream(adaptor,"token DEDENT");
        RewriteRuleTokenStream stream_NEWLINE = new RewriteRuleTokenStream(adaptor,"token NEWLINE");
        RewriteRuleTokenStream stream_DENT = new RewriteRuleTokenStream(adaptor,"token DENT");
        RewriteRuleTokenStream stream_INDENT = new RewriteRuleTokenStream(adaptor,"token INDENT");
        RewriteRuleSubtreeStream stream_map_pair = new RewriteRuleSubtreeStream(adaptor,"rule map_pair");

        	BlockLevel++;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:117:2: ( INDENT DENT map_pair ( NEWLINE DENT map_pair )* DEDENT -> ^( MAP ( map_pair )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:117:4: INDENT DENT map_pair ( NEWLINE DENT map_pair )* DEDENT
            {
            	INDENT23=(IToken)Match(input,INDENT,FOLLOW_INDENT_in_block_map554);  
            	stream_INDENT.Add(INDENT23);

            	DENT24=(IToken)Match(input,DENT,FOLLOW_DENT_in_block_map556);  
            	stream_DENT.Add(DENT24);

            	PushFollow(FOLLOW_map_pair_in_block_map558);
            	map_pair25 = map_pair();
            	state.followingStackPointer--;

            	stream_map_pair.Add(map_pair25.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:117:25: ( NEWLINE DENT map_pair )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == NEWLINE) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:117:26: NEWLINE DENT map_pair
            			    {
            			    	NEWLINE26=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_block_map561);  
            			    	stream_NEWLINE.Add(NEWLINE26);

            			    	DENT27=(IToken)Match(input,DENT,FOLLOW_DENT_in_block_map563);  
            			    	stream_DENT.Add(DENT27);

            			    	PushFollow(FOLLOW_map_pair_in_block_map565);
            			    	map_pair28 = map_pair();
            			    	state.followingStackPointer--;

            			    	stream_map_pair.Add(map_pair28.Tree);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	DEDENT29=(IToken)Match(input,DEDENT,FOLLOW_DEDENT_in_block_map569);  
            	stream_DEDENT.Add(DEDENT29);



            	// AST REWRITE
            	// elements:          map_pair
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 118:3: -> ^( MAP ( map_pair )+ )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:118:6: ^( MAP ( map_pair )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(MAP, "MAP"), root_1);

            	    if ( !(stream_map_pair.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_map_pair.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_map_pair.NextTree());

            	    }
            	    stream_map_pair.Reset();

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

            	BlockLevel--;

        }
        return retval;
    }
    // $ANTLR end "block_map"

    public class map_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "map"
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:124:1: map : ({...}? => block_map | flow_map );
    public YamlParser.map_return map() // throws RecognitionException [1]
    {   
        YamlParser.map_return retval = new YamlParser.map_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        YamlParser.block_map_return block_map30 = default(YamlParser.block_map_return);

        YamlParser.flow_map_return flow_map31 = default(YamlParser.flow_map_return);



        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:125:2: ({...}? => block_map | flow_map )
            int alt9 = 2;
            int LA9_0 = input.LA(1);

            if ( (LA9_0 == INDENT) && ((!IsInFlow)) )
            {
                alt9 = 1;
            }
            else if ( (LA9_0 == 32) )
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
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:125:4: {...}? => block_map
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	if ( !((!IsInFlow)) ) 
                    	{
                    	    throw new FailedPredicateException(input, "map", "!IsInFlow");
                    	}
                    	PushFollow(FOLLOW_block_map_in_map600);
                    	block_map30 = block_map();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, block_map30.Tree);

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:126:4: flow_map
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_flow_map_in_map605);
                    	flow_map31 = flow_map();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, flow_map31.Tree);

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
    // $ANTLR end "map"

    public class map_pair_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "map_pair"
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:129:1: map_pair : string_expr ( fskip )* ':' ( fskip )* value -> ^( ':' string_expr value ) ;
    public YamlParser.map_pair_return map_pair() // throws RecognitionException [1]
    {   
        YamlParser.map_pair_return retval = new YamlParser.map_pair_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal34 = null;
        YamlParser.string_expr_return string_expr32 = default(YamlParser.string_expr_return);

        YamlParser.fskip_return fskip33 = default(YamlParser.fskip_return);

        YamlParser.fskip_return fskip35 = default(YamlParser.fskip_return);

        YamlParser.value_return value36 = default(YamlParser.value_return);


        object char_literal34_tree=null;
        RewriteRuleTokenStream stream_35 = new RewriteRuleTokenStream(adaptor,"token 35");
        RewriteRuleSubtreeStream stream_value = new RewriteRuleSubtreeStream(adaptor,"rule value");
        RewriteRuleSubtreeStream stream_string_expr = new RewriteRuleSubtreeStream(adaptor,"rule string_expr");
        RewriteRuleSubtreeStream stream_fskip = new RewriteRuleSubtreeStream(adaptor,"rule fskip");
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:130:2: ( string_expr ( fskip )* ':' ( fskip )* value -> ^( ':' string_expr value ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:130:4: string_expr ( fskip )* ':' ( fskip )* value
            {
            	PushFollow(FOLLOW_string_expr_in_map_pair617);
            	string_expr32 = string_expr();
            	state.followingStackPointer--;

            	stream_string_expr.Add(string_expr32.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:130:16: ( fskip )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= INDENT && LA10_0 <= DEDENT) || LA10_0 == INDENTATION || LA10_0 == NEWLINE) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:130:16: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_map_pair619);
            			    	fskip33 = fskip();
            			    	state.followingStackPointer--;

            			    	stream_fskip.Add(fskip33.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	char_literal34=(IToken)Match(input,35,FOLLOW_35_in_map_pair622);  
            	stream_35.Add(char_literal34);

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:130:27: ( fskip )*
            	do 
            	{
            	    int alt11 = 2;
            	    alt11 = dfa11.Predict(input);
            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:130:27: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_map_pair624);
            			    	fskip35 = fskip();
            			    	state.followingStackPointer--;

            			    	stream_fskip.Add(fskip35.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	PushFollow(FOLLOW_value_in_map_pair627);
            	value36 = value();
            	state.followingStackPointer--;

            	stream_value.Add(value36.Tree);


            	// AST REWRITE
            	// elements:          string_expr, 35, value
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 131:3: -> ^( ':' string_expr value )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:131:6: ^( ':' string_expr value )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_35.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_string_expr.NextTree());
            	    adaptor.AddChild(root_1, stream_value.NextTree());

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
    // $ANTLR end "map_pair"

    public class list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "list"
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:134:1: list : ({...}? => block_list | flow_list );
    public YamlParser.list_return list() // throws RecognitionException [1]
    {   
        YamlParser.list_return retval = new YamlParser.list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        YamlParser.block_list_return block_list37 = default(YamlParser.block_list_return);

        YamlParser.flow_list_return flow_list38 = default(YamlParser.flow_list_return);



        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:135:2: ({...}? => block_list | flow_list )
            int alt12 = 2;
            int LA12_0 = input.LA(1);

            if ( (LA12_0 == INDENTATION || LA12_0 == LI) && ((!IsInFlow)) )
            {
                alt12 = 1;
            }
            else if ( (LA12_0 == 36) )
            {
                alt12 = 2;
            }
            else 
            {
                NoViableAltException nvae_d12s0 =
                    new NoViableAltException("", 12, 0, input);

                throw nvae_d12s0;
            }
            switch (alt12) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:135:4: {...}? => block_list
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	if ( !((!IsInFlow)) ) 
                    	{
                    	    throw new FailedPredicateException(input, "list", "!IsInFlow");
                    	}
                    	PushFollow(FOLLOW_block_list_in_list655);
                    	block_list37 = block_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, block_list37.Tree);

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:136:4: flow_list
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_flow_list_in_list660);
                    	flow_list38 = flow_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, flow_list38.Tree);

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
    // $ANTLR end "list"

    public class fskip_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "fskip"
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:140:1: fskip : ( NEWLINE | INDENTATION | INDENT | DEDENT );
    public YamlParser.fskip_return fskip() // throws RecognitionException [1]
    {   
        YamlParser.fskip_return retval = new YamlParser.fskip_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set39 = null;

        object set39_tree=null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:2: ( NEWLINE | INDENTATION | INDENT | DEDENT )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set39 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= INDENT && input.LA(1) <= DEDENT) || input.LA(1) == INDENTATION || input.LA(1) == NEWLINE ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set39));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


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
    // $ANTLR end "fskip"

    public class flow_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "flow_list"
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:144:1: flow_list : '[' ( fskip )* value ( fskip )* ( ',' ( fskip )* value ( fskip )* )* ']' -> ^( LIST ( value )+ ) ;
    public YamlParser.flow_list_return flow_list() // throws RecognitionException [1]
    {   
        YamlParser.flow_list_return retval = new YamlParser.flow_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal40 = null;
        IToken char_literal44 = null;
        IToken char_literal48 = null;
        YamlParser.fskip_return fskip41 = default(YamlParser.fskip_return);

        YamlParser.value_return value42 = default(YamlParser.value_return);

        YamlParser.fskip_return fskip43 = default(YamlParser.fskip_return);

        YamlParser.fskip_return fskip45 = default(YamlParser.fskip_return);

        YamlParser.value_return value46 = default(YamlParser.value_return);

        YamlParser.fskip_return fskip47 = default(YamlParser.fskip_return);


        object char_literal40_tree=null;
        object char_literal44_tree=null;
        object char_literal48_tree=null;
        RewriteRuleTokenStream stream_36 = new RewriteRuleTokenStream(adaptor,"token 36");
        RewriteRuleTokenStream stream_33 = new RewriteRuleTokenStream(adaptor,"token 33");
        RewriteRuleTokenStream stream_37 = new RewriteRuleTokenStream(adaptor,"token 37");
        RewriteRuleSubtreeStream stream_value = new RewriteRuleSubtreeStream(adaptor,"rule value");
        RewriteRuleSubtreeStream stream_fskip = new RewriteRuleSubtreeStream(adaptor,"rule fskip");

        	flowLvl++;
        	BlockLevel++;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:149:2: ( '[' ( fskip )* value ( fskip )* ( ',' ( fskip )* value ( fskip )* )* ']' -> ^( LIST ( value )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:149:4: '[' ( fskip )* value ( fskip )* ( ',' ( fskip )* value ( fskip )* )* ']'
            {
            	char_literal40=(IToken)Match(input,36,FOLLOW_36_in_flow_list703);  
            	stream_36.Add(char_literal40);

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:149:8: ( fskip )*
            	do 
            	{
            	    int alt13 = 2;
            	    alt13 = dfa13.Predict(input);
            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:149:8: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_flow_list705);
            			    	fskip41 = fskip();
            			    	state.followingStackPointer--;

            			    	stream_fskip.Add(fskip41.Tree);

            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements

            	PushFollow(FOLLOW_value_in_flow_list708);
            	value42 = value();
            	state.followingStackPointer--;

            	stream_value.Add(value42.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:149:21: ( fskip )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( ((LA14_0 >= INDENT && LA14_0 <= DEDENT) || LA14_0 == INDENTATION || LA14_0 == NEWLINE) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:149:21: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_flow_list710);
            			    	fskip43 = fskip();
            			    	state.followingStackPointer--;

            			    	stream_fskip.Add(fskip43.Tree);

            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:149:28: ( ',' ( fskip )* value ( fskip )* )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == 33) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:149:29: ',' ( fskip )* value ( fskip )*
            			    {
            			    	char_literal44=(IToken)Match(input,33,FOLLOW_33_in_flow_list714);  
            			    	stream_33.Add(char_literal44);

            			    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:149:33: ( fskip )*
            			    	do 
            			    	{
            			    	    int alt15 = 2;
            			    	    alt15 = dfa15.Predict(input);
            			    	    switch (alt15) 
            			    		{
            			    			case 1 :
            			    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:149:33: fskip
            			    			    {
            			    			    	PushFollow(FOLLOW_fskip_in_flow_list716);
            			    			    	fskip45 = fskip();
            			    			    	state.followingStackPointer--;

            			    			    	stream_fskip.Add(fskip45.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop15;
            			    	    }
            			    	} while (true);

            			    	loop15:
            			    		;	// Stops C# compiler whining that label 'loop15' has no statements

            			    	PushFollow(FOLLOW_value_in_flow_list719);
            			    	value46 = value();
            			    	state.followingStackPointer--;

            			    	stream_value.Add(value46.Tree);
            			    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:149:46: ( fskip )*
            			    	do 
            			    	{
            			    	    int alt16 = 2;
            			    	    int LA16_0 = input.LA(1);

            			    	    if ( ((LA16_0 >= INDENT && LA16_0 <= DEDENT) || LA16_0 == INDENTATION || LA16_0 == NEWLINE) )
            			    	    {
            			    	        alt16 = 1;
            			    	    }


            			    	    switch (alt16) 
            			    		{
            			    			case 1 :
            			    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:149:46: fskip
            			    			    {
            			    			    	PushFollow(FOLLOW_fskip_in_flow_list721);
            			    			    	fskip47 = fskip();
            			    			    	state.followingStackPointer--;

            			    			    	stream_fskip.Add(fskip47.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop16;
            			    	    }
            			    	} while (true);

            			    	loop16:
            			    		;	// Stops C# compiler whining that label 'loop16' has no statements


            			    }
            			    break;

            			default:
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements

            	char_literal48=(IToken)Match(input,37,FOLLOW_37_in_flow_list726);  
            	stream_37.Add(char_literal48);



            	// AST REWRITE
            	// elements:          value
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 150:3: -> ^( LIST ( value )+ )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:150:6: ^( LIST ( value )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LIST, "LIST"), root_1);

            	    if ( !(stream_value.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_value.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_value.NextTree());

            	    }
            	    stream_value.Reset();

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

            	flowLvl--;
            	BlockLevel--;

        }
        return retval;
    }
    // $ANTLR end "flow_list"

    public class block_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "block_list"
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:157:1: block_list : ( INDENTATION INDENT ( block_list_item )+ INDENTATION DEDENT -> ^( LIST ( block_list_item )+ ) | {...}? ( block_list_item )+ -> ^( LIST ( block_list_item )+ ) );
    public YamlParser.block_list_return block_list() // throws RecognitionException [1]
    {   
        YamlParser.block_list_return retval = new YamlParser.block_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INDENTATION49 = null;
        IToken INDENT50 = null;
        IToken INDENTATION52 = null;
        IToken DEDENT53 = null;
        YamlParser.block_list_item_return block_list_item51 = default(YamlParser.block_list_item_return);

        YamlParser.block_list_item_return block_list_item54 = default(YamlParser.block_list_item_return);


        object INDENTATION49_tree=null;
        object INDENT50_tree=null;
        object INDENTATION52_tree=null;
        object DEDENT53_tree=null;
        RewriteRuleTokenStream stream_DEDENT = new RewriteRuleTokenStream(adaptor,"token DEDENT");
        RewriteRuleTokenStream stream_INDENT = new RewriteRuleTokenStream(adaptor,"token INDENT");
        RewriteRuleTokenStream stream_INDENTATION = new RewriteRuleTokenStream(adaptor,"token INDENTATION");
        RewriteRuleSubtreeStream stream_block_list_item = new RewriteRuleSubtreeStream(adaptor,"rule block_list_item");

        	BlockLevel++;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:161:2: ( INDENTATION INDENT ( block_list_item )+ INDENTATION DEDENT -> ^( LIST ( block_list_item )+ ) | {...}? ( block_list_item )+ -> ^( LIST ( block_list_item )+ ) )
            int alt20 = 2;
            int LA20_0 = input.LA(1);

            if ( (LA20_0 == INDENTATION) )
            {
                alt20 = 1;
            }
            else if ( (LA20_0 == LI) )
            {
                alt20 = 2;
            }
            else 
            {
                NoViableAltException nvae_d20s0 =
                    new NoViableAltException("", 20, 0, input);

                throw nvae_d20s0;
            }
            switch (alt20) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:161:4: INDENTATION INDENT ( block_list_item )+ INDENTATION DEDENT
                    {
                    	INDENTATION49=(IToken)Match(input,INDENTATION,FOLLOW_INDENTATION_in_block_list759);  
                    	stream_INDENTATION.Add(INDENTATION49);

                    	INDENT50=(IToken)Match(input,INDENT,FOLLOW_INDENT_in_block_list761);  
                    	stream_INDENT.Add(INDENT50);

                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:161:23: ( block_list_item )+
                    	int cnt18 = 0;
                    	do 
                    	{
                    	    int alt18 = 2;
                    	    int LA18_0 = input.LA(1);

                    	    if ( (LA18_0 == LI) )
                    	    {
                    	        alt18 = 1;
                    	    }


                    	    switch (alt18) 
                    		{
                    			case 1 :
                    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:161:23: block_list_item
                    			    {
                    			    	PushFollow(FOLLOW_block_list_item_in_block_list763);
                    			    	block_list_item51 = block_list_item();
                    			    	state.followingStackPointer--;

                    			    	stream_block_list_item.Add(block_list_item51.Tree);

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt18 >= 1 ) goto loop18;
                    		            EarlyExitException eee18 =
                    		                new EarlyExitException(18, input);
                    		            throw eee18;
                    	    }
                    	    cnt18++;
                    	} while (true);

                    	loop18:
                    		;	// Stops C# compiler whining that label 'loop18' has no statements

                    	INDENTATION52=(IToken)Match(input,INDENTATION,FOLLOW_INDENTATION_in_block_list766);  
                    	stream_INDENTATION.Add(INDENTATION52);

                    	DEDENT53=(IToken)Match(input,DEDENT,FOLLOW_DEDENT_in_block_list768);  
                    	stream_DEDENT.Add(DEDENT53);



                    	// AST REWRITE
                    	// elements:          block_list_item
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 162:3: -> ^( LIST ( block_list_item )+ )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:162:6: ^( LIST ( block_list_item )+ )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LIST, "LIST"), root_1);

                    	    if ( !(stream_block_list_item.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_block_list_item.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_block_list_item.NextTree());

                    	    }
                    	    stream_block_list_item.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:163:4: {...}? ( block_list_item )+
                    {
                    	if ( !((flowLvl == 0)) ) 
                    	{
                    	    throw new FailedPredicateException(input, "block_list", "flowLvl == 0");
                    	}
                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:163:20: ( block_list_item )+
                    	int cnt19 = 0;
                    	do 
                    	{
                    	    int alt19 = 2;
                    	    int LA19_0 = input.LA(1);

                    	    if ( (LA19_0 == LI) )
                    	    {
                    	        alt19 = 1;
                    	    }


                    	    switch (alt19) 
                    		{
                    			case 1 :
                    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:163:20: block_list_item
                    			    {
                    			    	PushFollow(FOLLOW_block_list_item_in_block_list786);
                    			    	block_list_item54 = block_list_item();
                    			    	state.followingStackPointer--;

                    			    	stream_block_list_item.Add(block_list_item54.Tree);

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt19 >= 1 ) goto loop19;
                    		            EarlyExitException eee19 =
                    		                new EarlyExitException(19, input);
                    		            throw eee19;
                    	    }
                    	    cnt19++;
                    	} while (true);

                    	loop19:
                    		;	// Stops C# compiler whining that label 'loop19' has no statements



                    	// AST REWRITE
                    	// elements:          block_list_item
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 164:3: -> ^( LIST ( block_list_item )+ )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:164:6: ^( LIST ( block_list_item )+ )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LIST, "LIST"), root_1);

                    	    if ( !(stream_block_list_item.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_block_list_item.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_block_list_item.NextTree());

                    	    }
                    	    stream_block_list_item.Reset();

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

            	BlockLevel--;

        }
        return retval;
    }
    // $ANTLR end "block_list"

    protected class block_list_item_scope 
    {
        protected internal int lvl;
    }
    protected Stack block_list_item_stack = new Stack();

    public class block_list_item_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "block_list_item"
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:170:1: block_list_item : {...}? LI value NEWLINE -> value ;
    public YamlParser.block_list_item_return block_list_item() // throws RecognitionException [1]
    {   
        block_list_item_stack.Push(new block_list_item_scope());
        YamlParser.block_list_item_return retval = new YamlParser.block_list_item_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LI55 = null;
        IToken NEWLINE57 = null;
        YamlParser.value_return value56 = default(YamlParser.value_return);


        object LI55_tree=null;
        object NEWLINE57_tree=null;
        RewriteRuleTokenStream stream_NEWLINE = new RewriteRuleTokenStream(adaptor,"token NEWLINE");
        RewriteRuleTokenStream stream_LI = new RewriteRuleTokenStream(adaptor,"token LI");
        RewriteRuleSubtreeStream stream_value = new RewriteRuleSubtreeStream(adaptor,"rule value");

        	((block_list_item_scope)block_list_item_stack.Peek()).lvl =  BlockLevel;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:177:2: ({...}? LI value NEWLINE -> value )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:177:4: {...}? LI value NEWLINE
            {
            	if ( !((((block_list_item_scope)block_list_item_stack.Peek()).lvl == BlockLevel)) ) 
            	{
            	    throw new FailedPredicateException(input, "block_list_item", "$block_list_item::lvl == BlockLevel");
            	}
            	LI55=(IToken)Match(input,LI,FOLLOW_LI_in_block_list_item825);  
            	stream_LI.Add(LI55);

            	PushFollow(FOLLOW_value_in_block_list_item827);
            	value56 = value();
            	state.followingStackPointer--;

            	stream_value.Add(value56.Tree);
            	NEWLINE57=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_block_list_item829);  
            	stream_NEWLINE.Add(NEWLINE57);



            	// AST REWRITE
            	// elements:          value
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 178:3: -> value
            	{
            	    adaptor.AddChild(root_0, stream_value.NextTree());

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
            block_list_item_stack.Pop();
        }
        return retval;
    }
    // $ANTLR end "block_list_item"

    // Delegated rules


   	protected DFA1 dfa1;
   	protected DFA11 dfa11;
   	protected DFA13 dfa13;
   	protected DFA15 dfa15;
	private void InitializeCyclicDFAs()
	{
    	this.dfa1 = new DFA1(this);
    	this.dfa11 = new DFA11(this);
    	this.dfa13 = new DFA13(this);
    	this.dfa15 = new DFA15(this);
	    this.dfa1.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA1_SpecialStateTransition);
	    this.dfa11.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA11_SpecialStateTransition);
	    this.dfa13.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA13_SpecialStateTransition);
	    this.dfa15.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA15_SpecialStateTransition);
	}

    const string DFA1_eotS =
        "\x0a\uffff";
    const string DFA1_eofS =
        "\x0a\uffff";
    const string DFA1_minS =
        "\x01\x0d\x09\uffff";
    const string DFA1_maxS =
        "\x01\x24\x09\uffff";
    const string DFA1_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x02\x06\x02"+
        "\x07";
    const string DFA1_specialS =
        "\x01\x00\x09\uffff}>";
    static readonly string[] DFA1_transitionS = {
            "\x01\x06\x02\uffff\x01\x08\x01\x02\x01\x01\x01\x03\x02\uffff"+
            "\x01\x08\x01\x04\x01\uffff\x02\x05\x05\uffff\x01\x07\x03\uffff"+
            "\x01\x09",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA1_eot = DFA.UnpackEncodedString(DFA1_eotS);
    static readonly short[] DFA1_eof = DFA.UnpackEncodedString(DFA1_eofS);
    static readonly char[] DFA1_min = DFA.UnpackEncodedStringToUnsignedChars(DFA1_minS);
    static readonly char[] DFA1_max = DFA.UnpackEncodedStringToUnsignedChars(DFA1_maxS);
    static readonly short[] DFA1_accept = DFA.UnpackEncodedString(DFA1_acceptS);
    static readonly short[] DFA1_special = DFA.UnpackEncodedString(DFA1_specialS);
    static readonly short[][] DFA1_transition = DFA.UnpackEncodedStringArray(DFA1_transitionS);

    protected class DFA1 : DFA
    {
        public DFA1(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 1;
            this.eot = DFA1_eot;
            this.eof = DFA1_eof;
            this.min = DFA1_min;
            this.max = DFA1_max;
            this.accept = DFA1_accept;
            this.special = DFA1_special;
            this.transition = DFA1_transition;

        }

        override public string Description
        {
            get { return "37:1: value : ( null_expr | boolean | integer | float_expr | string_expr | map | list );"; }
        }

    }


    protected internal int DFA1_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA1_0 = input.LA(1);

                   	 
                   	int index1_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA1_0 == NULL) ) { s = 1; }

                   	else if ( (LA1_0 == Bool) ) { s = 2; }

                   	else if ( (LA1_0 == Integer) ) { s = 3; }

                   	else if ( (LA1_0 == Float) ) { s = 4; }

                   	else if ( ((LA1_0 >= QuotedString && LA1_0 <= UnQuotedString)) ) { s = 5; }

                   	else if ( (LA1_0 == INDENT) && ((!IsInFlow)) ) { s = 6; }

                   	else if ( (LA1_0 == 32) ) { s = 7; }

                   	else if ( (LA1_0 == INDENTATION || LA1_0 == LI) && ((!IsInFlow)) ) { s = 8; }

                   	else if ( (LA1_0 == 36) ) { s = 9; }

                   	 
                   	input.Seek(index1_0);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae1 =
            new NoViableAltException(dfa.Description, 1, _s, input);
        dfa.Error(nvae1);
        throw nvae1;
    }
    const string DFA11_eotS =
        "\x0d\uffff";
    const string DFA11_eofS =
        "\x0d\uffff";
    const string DFA11_minS =
        "\x01\x0d\x06\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA11_maxS =
        "\x01\x24\x06\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA11_acceptS =
        "\x01\uffff\x01\x02\x08\uffff\x02\x02\x01\x01";
    const string DFA11_specialS =
        "\x01\x00\x06\uffff\x01\x01\x01\uffff\x01\x02\x03\uffff}>";
    static readonly string[] DFA11_transitionS = {
            "\x01\x07\x01\x0c\x01\uffff\x01\x09\x03\x01\x02\uffff\x01\x0a"+
            "\x01\x01\x01\uffff\x02\x01\x01\uffff\x01\x0c\x03\uffff\x01\x01"+
            "\x03\uffff\x01\x0b",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "",
            "\x01\uffff",
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
            get { return "()* loopback of 130:27: ( fskip )*"; }
        }

    }


    protected internal int DFA11_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA11_0 = input.LA(1);

                   	 
                   	int index11_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( ((LA11_0 >= Bool && LA11_0 <= Integer) || LA11_0 == Float || (LA11_0 >= QuotedString && LA11_0 <= UnQuotedString) || LA11_0 == 32) ) { s = 1; }

                   	else if ( (LA11_0 == INDENT) ) { s = 7; }

                   	else if ( (LA11_0 == INDENTATION) ) { s = 9; }

                   	else if ( (LA11_0 == LI) && ((!IsInFlow)) ) { s = 10; }

                   	else if ( (LA11_0 == 36) ) { s = 11; }

                   	else if ( (LA11_0 == DEDENT || LA11_0 == NEWLINE) ) { s = 12; }

                   	 
                   	input.Seek(index11_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA11_7 = input.LA(1);

                   	 
                   	int index11_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 12; }

                   	else if ( ((!IsInFlow)) ) { s = 11; }

                   	 
                   	input.Seek(index11_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA11_9 = input.LA(1);

                   	 
                   	int index11_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 12; }

                   	else if ( ((!IsInFlow)) ) { s = 11; }

                   	 
                   	input.Seek(index11_9);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae11 =
            new NoViableAltException(dfa.Description, 11, _s, input);
        dfa.Error(nvae11);
        throw nvae11;
    }
    const string DFA13_eotS =
        "\x0d\uffff";
    const string DFA13_eofS =
        "\x0d\uffff";
    const string DFA13_minS =
        "\x01\x0d\x06\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA13_maxS =
        "\x01\x24\x06\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA13_acceptS =
        "\x01\uffff\x01\x02\x08\uffff\x02\x02\x01\x01";
    const string DFA13_specialS =
        "\x01\x00\x06\uffff\x01\x01\x01\uffff\x01\x02\x03\uffff}>";
    static readonly string[] DFA13_transitionS = {
            "\x01\x07\x01\x0c\x01\uffff\x01\x09\x03\x01\x02\uffff\x01\x0a"+
            "\x01\x01\x01\uffff\x02\x01\x01\uffff\x01\x0c\x03\uffff\x01\x01"+
            "\x03\uffff\x01\x0b",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "",
            "\x01\uffff",
            "",
            "",
            ""
    };

    static readonly short[] DFA13_eot = DFA.UnpackEncodedString(DFA13_eotS);
    static readonly short[] DFA13_eof = DFA.UnpackEncodedString(DFA13_eofS);
    static readonly char[] DFA13_min = DFA.UnpackEncodedStringToUnsignedChars(DFA13_minS);
    static readonly char[] DFA13_max = DFA.UnpackEncodedStringToUnsignedChars(DFA13_maxS);
    static readonly short[] DFA13_accept = DFA.UnpackEncodedString(DFA13_acceptS);
    static readonly short[] DFA13_special = DFA.UnpackEncodedString(DFA13_specialS);
    static readonly short[][] DFA13_transition = DFA.UnpackEncodedStringArray(DFA13_transitionS);

    protected class DFA13 : DFA
    {
        public DFA13(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 13;
            this.eot = DFA13_eot;
            this.eof = DFA13_eof;
            this.min = DFA13_min;
            this.max = DFA13_max;
            this.accept = DFA13_accept;
            this.special = DFA13_special;
            this.transition = DFA13_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 149:8: ( fskip )*"; }
        }

    }


    protected internal int DFA13_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA13_0 = input.LA(1);

                   	 
                   	int index13_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( ((LA13_0 >= Bool && LA13_0 <= Integer) || LA13_0 == Float || (LA13_0 >= QuotedString && LA13_0 <= UnQuotedString) || LA13_0 == 32) ) { s = 1; }

                   	else if ( (LA13_0 == INDENT) ) { s = 7; }

                   	else if ( (LA13_0 == INDENTATION) ) { s = 9; }

                   	else if ( (LA13_0 == LI) && ((!IsInFlow)) ) { s = 10; }

                   	else if ( (LA13_0 == 36) ) { s = 11; }

                   	else if ( (LA13_0 == DEDENT || LA13_0 == NEWLINE) ) { s = 12; }

                   	 
                   	input.Seek(index13_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA13_7 = input.LA(1);

                   	 
                   	int index13_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 12; }

                   	else if ( ((!IsInFlow)) ) { s = 11; }

                   	 
                   	input.Seek(index13_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA13_9 = input.LA(1);

                   	 
                   	int index13_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 12; }

                   	else if ( ((!IsInFlow)) ) { s = 11; }

                   	 
                   	input.Seek(index13_9);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae13 =
            new NoViableAltException(dfa.Description, 13, _s, input);
        dfa.Error(nvae13);
        throw nvae13;
    }
    const string DFA15_eotS =
        "\x0d\uffff";
    const string DFA15_eofS =
        "\x0d\uffff";
    const string DFA15_minS =
        "\x01\x0d\x06\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA15_maxS =
        "\x01\x24\x06\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA15_acceptS =
        "\x01\uffff\x01\x02\x08\uffff\x02\x02\x01\x01";
    const string DFA15_specialS =
        "\x01\x00\x06\uffff\x01\x01\x01\uffff\x01\x02\x03\uffff}>";
    static readonly string[] DFA15_transitionS = {
            "\x01\x07\x01\x0c\x01\uffff\x01\x09\x03\x01\x02\uffff\x01\x0a"+
            "\x01\x01\x01\uffff\x02\x01\x01\uffff\x01\x0c\x03\uffff\x01\x01"+
            "\x03\uffff\x01\x0b",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "",
            "\x01\uffff",
            "",
            "",
            ""
    };

    static readonly short[] DFA15_eot = DFA.UnpackEncodedString(DFA15_eotS);
    static readonly short[] DFA15_eof = DFA.UnpackEncodedString(DFA15_eofS);
    static readonly char[] DFA15_min = DFA.UnpackEncodedStringToUnsignedChars(DFA15_minS);
    static readonly char[] DFA15_max = DFA.UnpackEncodedStringToUnsignedChars(DFA15_maxS);
    static readonly short[] DFA15_accept = DFA.UnpackEncodedString(DFA15_acceptS);
    static readonly short[] DFA15_special = DFA.UnpackEncodedString(DFA15_specialS);
    static readonly short[][] DFA15_transition = DFA.UnpackEncodedStringArray(DFA15_transitionS);

    protected class DFA15 : DFA
    {
        public DFA15(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 15;
            this.eot = DFA15_eot;
            this.eof = DFA15_eof;
            this.min = DFA15_min;
            this.max = DFA15_max;
            this.accept = DFA15_accept;
            this.special = DFA15_special;
            this.transition = DFA15_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 149:33: ( fskip )*"; }
        }

    }


    protected internal int DFA15_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA15_0 = input.LA(1);

                   	 
                   	int index15_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( ((LA15_0 >= Bool && LA15_0 <= Integer) || LA15_0 == Float || (LA15_0 >= QuotedString && LA15_0 <= UnQuotedString) || LA15_0 == 32) ) { s = 1; }

                   	else if ( (LA15_0 == INDENT) ) { s = 7; }

                   	else if ( (LA15_0 == INDENTATION) ) { s = 9; }

                   	else if ( (LA15_0 == LI) && ((!IsInFlow)) ) { s = 10; }

                   	else if ( (LA15_0 == 36) ) { s = 11; }

                   	else if ( (LA15_0 == DEDENT || LA15_0 == NEWLINE) ) { s = 12; }

                   	 
                   	input.Seek(index15_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA15_7 = input.LA(1);

                   	 
                   	int index15_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 12; }

                   	else if ( ((!IsInFlow)) ) { s = 11; }

                   	 
                   	input.Seek(index15_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA15_9 = input.LA(1);

                   	 
                   	int index15_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 12; }

                   	else if ( ((!IsInFlow)) ) { s = 11; }

                   	 
                   	input.Seek(index15_9);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae15 =
            new NoViableAltException(dfa.Description, 15, _s, input);
        dfa.Error(nvae15);
        throw nvae15;
    }
 

    public static readonly BitSet FOLLOW_null_expr_in_value142 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_boolean_in_value147 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_integer_in_value152 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_float_expr_in_value158 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string_expr_in_value163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_map_in_value168 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_list_in_value173 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Bool_in_boolean186 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_in_null_expr221 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Integer_in_integer241 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Float_in_float_expr301 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QuotedString_in_string_expr377 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UnQuotedString_in_string_expr391 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_flow_map498 = new BitSet(new ulong[]{0x0000000016016000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_map500 = new BitSet(new ulong[]{0x0000000016016000UL});
    public static readonly BitSet FOLLOW_map_pair_in_flow_map503 = new BitSet(new ulong[]{0x0000000610016000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_map505 = new BitSet(new ulong[]{0x0000000610016000UL});
    public static readonly BitSet FOLLOW_33_in_flow_map509 = new BitSet(new ulong[]{0x0000000016016000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_map511 = new BitSet(new ulong[]{0x0000000016016000UL});
    public static readonly BitSet FOLLOW_map_pair_in_flow_map514 = new BitSet(new ulong[]{0x0000000610016000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_map516 = new BitSet(new ulong[]{0x0000000610016000UL});
    public static readonly BitSet FOLLOW_34_in_flow_map522 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INDENT_in_block_map554 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_DENT_in_block_map556 = new BitSet(new ulong[]{0x0000000016016000UL});
    public static readonly BitSet FOLLOW_map_pair_in_block_map558 = new BitSet(new ulong[]{0x0000000010004000UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_block_map561 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_DENT_in_block_map563 = new BitSet(new ulong[]{0x0000000016016000UL});
    public static readonly BitSet FOLLOW_map_pair_in_block_map565 = new BitSet(new ulong[]{0x0000000010004000UL});
    public static readonly BitSet FOLLOW_DEDENT_in_block_map569 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_map_in_map600 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_flow_map_in_map605 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string_expr_in_map_pair617 = new BitSet(new ulong[]{0x0000000810016000UL});
    public static readonly BitSet FOLLOW_fskip_in_map_pair619 = new BitSet(new ulong[]{0x0000000810016000UL});
    public static readonly BitSet FOLLOW_35_in_map_pair622 = new BitSet(new ulong[]{0x0000001116CF6000UL});
    public static readonly BitSet FOLLOW_fskip_in_map_pair624 = new BitSet(new ulong[]{0x0000001116CF6000UL});
    public static readonly BitSet FOLLOW_value_in_map_pair627 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_list_in_list655 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_flow_list_in_list660 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_fskip0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_flow_list703 = new BitSet(new ulong[]{0x0000001116CF6000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_list705 = new BitSet(new ulong[]{0x0000001116CF6000UL});
    public static readonly BitSet FOLLOW_value_in_flow_list708 = new BitSet(new ulong[]{0x0000002210016000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_list710 = new BitSet(new ulong[]{0x0000002210016000UL});
    public static readonly BitSet FOLLOW_33_in_flow_list714 = new BitSet(new ulong[]{0x0000001116CF6000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_list716 = new BitSet(new ulong[]{0x0000001116CF6000UL});
    public static readonly BitSet FOLLOW_value_in_flow_list719 = new BitSet(new ulong[]{0x0000002210016000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_list721 = new BitSet(new ulong[]{0x0000002210016000UL});
    public static readonly BitSet FOLLOW_37_in_flow_list726 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INDENTATION_in_block_list759 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_INDENT_in_block_list761 = new BitSet(new ulong[]{0x0000000000410000UL});
    public static readonly BitSet FOLLOW_block_list_item_in_block_list763 = new BitSet(new ulong[]{0x0000000000410000UL});
    public static readonly BitSet FOLLOW_INDENTATION_in_block_list766 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DEDENT_in_block_list768 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_list_item_in_block_list786 = new BitSet(new ulong[]{0x0000000000410002UL});
    public static readonly BitSet FOLLOW_LI_in_block_list_item825 = new BitSet(new ulong[]{0x0000001116CF6000UL});
    public static readonly BitSet FOLLOW_value_in_block_list_item827 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_block_list_item829 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}