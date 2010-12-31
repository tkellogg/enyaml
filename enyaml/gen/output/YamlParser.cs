// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g 2010-12-31 15:44:01

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
		"Integer", 
		"DecDigit", 
		"HexDigit", 
		"LI", 
		"Float", 
		"Exponent", 
		"QuotedString", 
		"UnQuotedStringChars", 
		"Bool", 
		"NEWLINE", 
		"EscapeSequence", 
		"NonColonChars", 
		"UnicodeEscape", 
		"'{'", 
		"','", 
		"'}'", 
		"':'", 
		"'['", 
		"']'"
    };

    public const int INTEGER = 6;
    public const int Bool = 25;
    public const int DOUBLE_QUOTE = 9;
    public const int BOOL = 8;
    public const int Exponent = 22;
    public const int DEDENT = 14;
    public const int FLOAT = 7;
    public const int QuotedString = 23;
    public const int EOF = -1;
    public const int LIST = 12;
    public const int HexDigit = 19;
    public const int DecDigit = 18;
    public const int INDENT = 13;
    public const int Float = 21;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int SINGLE_QUOTE = 10;
    public const int NonColonChars = 28;
    public const int T__32 = 32;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int NEWLINE = 26;
    public const int T__35 = 35;
    public const int DENT = 15;
    public const int UnicodeEscape = 29;
    public const int MAP = 11;
    public const int QUOTED_STRING = 4;
    public const int UnQuotedStringChars = 24;
    public const int LI = 20;
    public const int UNQUOTED_STRING = 5;
    public const int EscapeSequence = 27;
    public const int Integer = 17;
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:37:1: value : ( boolean | integer | float_expr | string_expr | map | list );
    public YamlParser.value_return value() // throws RecognitionException [1]
    {   
        YamlParser.value_return retval = new YamlParser.value_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        YamlParser.boolean_return boolean1 = default(YamlParser.boolean_return);

        YamlParser.integer_return integer2 = default(YamlParser.integer_return);

        YamlParser.float_expr_return float_expr3 = default(YamlParser.float_expr_return);

        YamlParser.string_expr_return string_expr4 = default(YamlParser.string_expr_return);

        YamlParser.map_return map5 = default(YamlParser.map_return);

        YamlParser.list_return list6 = default(YamlParser.list_return);



        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:38:2: ( boolean | integer | float_expr | string_expr | map | list )
            int alt1 = 6;
            int LA1_0 = input.LA(1);

            if ( (LA1_0 == Bool) )
            {
                alt1 = 1;
            }
            else if ( (LA1_0 == Integer) )
            {
                alt1 = 2;
            }
            else if ( (LA1_0 == Float) )
            {
                alt1 = 3;
            }
            else if ( (LA1_0 == QuotedString) )
            {
                alt1 = 4;
            }
            else if ( (LA1_0 == INDENT) && ((!IsInFlow)) )
            {
                alt1 = 5;
            }
            else if ( (LA1_0 == 30) )
            {
                alt1 = 5;
            }
            else if ( (LA1_0 == INDENTATION || LA1_0 == LI) && ((!IsInFlow)) )
            {
                alt1 = 6;
            }
            else if ( (LA1_0 == 34) )
            {
                alt1 = 6;
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
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:38:4: boolean
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_boolean_in_value142);
                    	boolean1 = boolean();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, boolean1.Tree);

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:39:4: integer
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_integer_in_value147);
                    	integer2 = integer();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, integer2.Tree);

                    }
                    break;
                case 3 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:40:4: float_expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_float_expr_in_value153);
                    	float_expr3 = float_expr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, float_expr3.Tree);

                    }
                    break;
                case 4 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:41:4: string_expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_string_expr_in_value158);
                    	string_expr4 = string_expr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, string_expr4.Tree);

                    }
                    break;
                case 5 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:42:4: map
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_map_in_value163);
                    	map5 = map();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, map5.Tree);

                    }
                    break;
                case 6 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:43:4: list
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_list_in_value168);
                    	list6 = list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, list6.Tree);

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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:46:1: integer : Integer -> ^( INTEGER Integer ) ;
    public YamlParser.integer_return integer() // throws RecognitionException [1]
    {   
        YamlParser.integer_return retval = new YamlParser.integer_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Integer7 = null;

        object Integer7_tree=null;
        RewriteRuleTokenStream stream_Integer = new RewriteRuleTokenStream(adaptor,"token Integer");

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:47:2: ( Integer -> ^( INTEGER Integer ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:47:4: Integer
            {
            	Integer7=(IToken)Match(input,Integer,FOLLOW_Integer_in_integer179);  
            	stream_Integer.Add(Integer7);



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
            	// 47:12: -> ^( INTEGER Integer )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:47:15: ^( INTEGER Integer )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:59:1: float_expr : Float -> ^( FLOAT Float ) ;
    public YamlParser.float_expr_return float_expr() // throws RecognitionException [1]
    {   
        YamlParser.float_expr_return retval = new YamlParser.float_expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Float8 = null;

        object Float8_tree=null;
        RewriteRuleTokenStream stream_Float = new RewriteRuleTokenStream(adaptor,"token Float");

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:60:2: ( Float -> ^( FLOAT Float ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:60:4: Float
            {
            	Float8=(IToken)Match(input,Float,FOLLOW_Float_in_float_expr239);  
            	stream_Float.Add(Float8);



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
            	// 60:10: -> ^( FLOAT Float )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:60:13: ^( FLOAT Float )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:71:1: string_expr : QuotedString -> ^( QUOTED_STRING QuotedString ) ;
    public YamlParser.string_expr_return string_expr() // throws RecognitionException [1]
    {   
        YamlParser.string_expr_return retval = new YamlParser.string_expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken QuotedString9 = null;

        object QuotedString9_tree=null;
        RewriteRuleTokenStream stream_QuotedString = new RewriteRuleTokenStream(adaptor,"token QuotedString");

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:72:2: ( QuotedString -> ^( QUOTED_STRING QuotedString ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:72:4: QuotedString
            {
            	QuotedString9=(IToken)Match(input,QuotedString,FOLLOW_QuotedString_in_string_expr315);  
            	stream_QuotedString.Add(QuotedString9);



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
            	// 72:17: -> ^( QUOTED_STRING QuotedString )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:72:20: ^( QUOTED_STRING QuotedString )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:84:1: boolean : Bool -> ^( BOOL Bool ) ;
    public YamlParser.boolean_return boolean() // throws RecognitionException [1]
    {   
        YamlParser.boolean_return retval = new YamlParser.boolean_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Bool10 = null;

        object Bool10_tree=null;
        RewriteRuleTokenStream stream_Bool = new RewriteRuleTokenStream(adaptor,"token Bool");

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:85:2: ( Bool -> ^( BOOL Bool ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:85:4: Bool
            {
            	Bool10=(IToken)Match(input,Bool,FOLLOW_Bool_in_boolean358);  
            	stream_Bool.Add(Bool10);



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
            	// 85:9: -> ^( BOOL Bool )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:85:12: ^( BOOL Bool )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:92:1: flow_map : '{' ( fskip )* map_pair ( fskip )* ( ',' ( fskip )* map_pair ( fskip )* )* '}' -> ^( MAP ( map_pair )+ ) ;
    public YamlParser.flow_map_return flow_map() // throws RecognitionException [1]
    {   
        YamlParser.flow_map_return retval = new YamlParser.flow_map_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal11 = null;
        IToken char_literal15 = null;
        IToken char_literal19 = null;
        YamlParser.fskip_return fskip12 = default(YamlParser.fskip_return);

        YamlParser.map_pair_return map_pair13 = default(YamlParser.map_pair_return);

        YamlParser.fskip_return fskip14 = default(YamlParser.fskip_return);

        YamlParser.fskip_return fskip16 = default(YamlParser.fskip_return);

        YamlParser.map_pair_return map_pair17 = default(YamlParser.map_pair_return);

        YamlParser.fskip_return fskip18 = default(YamlParser.fskip_return);


        object char_literal11_tree=null;
        object char_literal15_tree=null;
        object char_literal19_tree=null;
        RewriteRuleTokenStream stream_30 = new RewriteRuleTokenStream(adaptor,"token 30");
        RewriteRuleTokenStream stream_32 = new RewriteRuleTokenStream(adaptor,"token 32");
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleSubtreeStream stream_map_pair = new RewriteRuleSubtreeStream(adaptor,"rule map_pair");
        RewriteRuleSubtreeStream stream_fskip = new RewriteRuleSubtreeStream(adaptor,"rule fskip");

        	flowLvl++;
        	BlockLevel++;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:2: ( '{' ( fskip )* map_pair ( fskip )* ( ',' ( fskip )* map_pair ( fskip )* )* '}' -> ^( MAP ( map_pair )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:4: '{' ( fskip )* map_pair ( fskip )* ( ',' ( fskip )* map_pair ( fskip )* )* '}'
            {
            	char_literal11=(IToken)Match(input,30,FOLLOW_30_in_flow_map401);  
            	stream_30.Add(char_literal11);

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:8: ( fskip )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= INDENT && LA2_0 <= DEDENT) || LA2_0 == INDENTATION || LA2_0 == NEWLINE) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:8: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_flow_map403);
            			    	fskip12 = fskip();
            			    	state.followingStackPointer--;

            			    	stream_fskip.Add(fskip12.Tree);

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	PushFollow(FOLLOW_map_pair_in_flow_map406);
            	map_pair13 = map_pair();
            	state.followingStackPointer--;

            	stream_map_pair.Add(map_pair13.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:24: ( fskip )*
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
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:24: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_flow_map408);
            			    	fskip14 = fskip();
            			    	state.followingStackPointer--;

            			    	stream_fskip.Add(fskip14.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:31: ( ',' ( fskip )* map_pair ( fskip )* )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == 31) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:32: ',' ( fskip )* map_pair ( fskip )*
            			    {
            			    	char_literal15=(IToken)Match(input,31,FOLLOW_31_in_flow_map412);  
            			    	stream_31.Add(char_literal15);

            			    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:36: ( fskip )*
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
            			    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:36: fskip
            			    			    {
            			    			    	PushFollow(FOLLOW_fskip_in_flow_map414);
            			    			    	fskip16 = fskip();
            			    			    	state.followingStackPointer--;

            			    			    	stream_fskip.Add(fskip16.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop4;
            			    	    }
            			    	} while (true);

            			    	loop4:
            			    		;	// Stops C# compiler whining that label 'loop4' has no statements

            			    	PushFollow(FOLLOW_map_pair_in_flow_map417);
            			    	map_pair17 = map_pair();
            			    	state.followingStackPointer--;

            			    	stream_map_pair.Add(map_pair17.Tree);
            			    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:52: ( fskip )*
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
            			    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:52: fskip
            			    			    {
            			    			    	PushFollow(FOLLOW_fskip_in_flow_map419);
            			    			    	fskip18 = fskip();
            			    			    	state.followingStackPointer--;

            			    			    	stream_fskip.Add(fskip18.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop5;
            			    	    }
            			    	} while (true);

            			    	loop5:
            			    		;	// Stops C# compiler whining that label 'loop5' has no statements


            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements

            	char_literal19=(IToken)Match(input,32,FOLLOW_32_in_flow_map425);  
            	stream_32.Add(char_literal19);



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
            	// 98:3: -> ^( MAP ( map_pair )+ )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:98:6: ^( MAP ( map_pair )+ )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:105:1: block_map : INDENT DENT map_pair ( NEWLINE DENT map_pair )* DEDENT -> ^( MAP ( map_pair )+ ) ;
    public YamlParser.block_map_return block_map() // throws RecognitionException [1]
    {   
        YamlParser.block_map_return retval = new YamlParser.block_map_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INDENT20 = null;
        IToken DENT21 = null;
        IToken NEWLINE23 = null;
        IToken DENT24 = null;
        IToken DEDENT26 = null;
        YamlParser.map_pair_return map_pair22 = default(YamlParser.map_pair_return);

        YamlParser.map_pair_return map_pair25 = default(YamlParser.map_pair_return);


        object INDENT20_tree=null;
        object DENT21_tree=null;
        object NEWLINE23_tree=null;
        object DENT24_tree=null;
        object DEDENT26_tree=null;
        RewriteRuleTokenStream stream_DEDENT = new RewriteRuleTokenStream(adaptor,"token DEDENT");
        RewriteRuleTokenStream stream_NEWLINE = new RewriteRuleTokenStream(adaptor,"token NEWLINE");
        RewriteRuleTokenStream stream_DENT = new RewriteRuleTokenStream(adaptor,"token DENT");
        RewriteRuleTokenStream stream_INDENT = new RewriteRuleTokenStream(adaptor,"token INDENT");
        RewriteRuleSubtreeStream stream_map_pair = new RewriteRuleSubtreeStream(adaptor,"rule map_pair");

        	BlockLevel++;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:109:2: ( INDENT DENT map_pair ( NEWLINE DENT map_pair )* DEDENT -> ^( MAP ( map_pair )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:109:4: INDENT DENT map_pair ( NEWLINE DENT map_pair )* DEDENT
            {
            	INDENT20=(IToken)Match(input,INDENT,FOLLOW_INDENT_in_block_map457);  
            	stream_INDENT.Add(INDENT20);

            	DENT21=(IToken)Match(input,DENT,FOLLOW_DENT_in_block_map459);  
            	stream_DENT.Add(DENT21);

            	PushFollow(FOLLOW_map_pair_in_block_map461);
            	map_pair22 = map_pair();
            	state.followingStackPointer--;

            	stream_map_pair.Add(map_pair22.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:109:25: ( NEWLINE DENT map_pair )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == NEWLINE) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:109:26: NEWLINE DENT map_pair
            			    {
            			    	NEWLINE23=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_block_map464);  
            			    	stream_NEWLINE.Add(NEWLINE23);

            			    	DENT24=(IToken)Match(input,DENT,FOLLOW_DENT_in_block_map466);  
            			    	stream_DENT.Add(DENT24);

            			    	PushFollow(FOLLOW_map_pair_in_block_map468);
            			    	map_pair25 = map_pair();
            			    	state.followingStackPointer--;

            			    	stream_map_pair.Add(map_pair25.Tree);

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

            	DEDENT26=(IToken)Match(input,DEDENT,FOLLOW_DEDENT_in_block_map472);  
            	stream_DEDENT.Add(DEDENT26);



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
            	// 110:3: -> ^( MAP ( map_pair )+ )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:110:6: ^( MAP ( map_pair )+ )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:116:1: map : ({...}? => block_map | flow_map );
    public YamlParser.map_return map() // throws RecognitionException [1]
    {   
        YamlParser.map_return retval = new YamlParser.map_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        YamlParser.block_map_return block_map27 = default(YamlParser.block_map_return);

        YamlParser.flow_map_return flow_map28 = default(YamlParser.flow_map_return);



        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:117:2: ({...}? => block_map | flow_map )
            int alt8 = 2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0 == INDENT) && ((!IsInFlow)) )
            {
                alt8 = 1;
            }
            else if ( (LA8_0 == 30) )
            {
                alt8 = 2;
            }
            else 
            {
                NoViableAltException nvae_d8s0 =
                    new NoViableAltException("", 8, 0, input);

                throw nvae_d8s0;
            }
            switch (alt8) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:117:4: {...}? => block_map
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	if ( !((!IsInFlow)) ) 
                    	{
                    	    throw new FailedPredicateException(input, "map", "!IsInFlow");
                    	}
                    	PushFollow(FOLLOW_block_map_in_map503);
                    	block_map27 = block_map();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, block_map27.Tree);

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:118:4: flow_map
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_flow_map_in_map508);
                    	flow_map28 = flow_map();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, flow_map28.Tree);

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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:121:1: map_pair : string_expr ( fskip )* ':' ( fskip )* value -> ^( ':' string_expr value ) ;
    public YamlParser.map_pair_return map_pair() // throws RecognitionException [1]
    {   
        YamlParser.map_pair_return retval = new YamlParser.map_pair_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal31 = null;
        YamlParser.string_expr_return string_expr29 = default(YamlParser.string_expr_return);

        YamlParser.fskip_return fskip30 = default(YamlParser.fskip_return);

        YamlParser.fskip_return fskip32 = default(YamlParser.fskip_return);

        YamlParser.value_return value33 = default(YamlParser.value_return);


        object char_literal31_tree=null;
        RewriteRuleTokenStream stream_33 = new RewriteRuleTokenStream(adaptor,"token 33");
        RewriteRuleSubtreeStream stream_value = new RewriteRuleSubtreeStream(adaptor,"rule value");
        RewriteRuleSubtreeStream stream_string_expr = new RewriteRuleSubtreeStream(adaptor,"rule string_expr");
        RewriteRuleSubtreeStream stream_fskip = new RewriteRuleSubtreeStream(adaptor,"rule fskip");
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:122:2: ( string_expr ( fskip )* ':' ( fskip )* value -> ^( ':' string_expr value ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:122:4: string_expr ( fskip )* ':' ( fskip )* value
            {
            	PushFollow(FOLLOW_string_expr_in_map_pair520);
            	string_expr29 = string_expr();
            	state.followingStackPointer--;

            	stream_string_expr.Add(string_expr29.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:122:16: ( fskip )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= INDENT && LA9_0 <= DEDENT) || LA9_0 == INDENTATION || LA9_0 == NEWLINE) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:122:16: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_map_pair522);
            			    	fskip30 = fskip();
            			    	state.followingStackPointer--;

            			    	stream_fskip.Add(fskip30.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	char_literal31=(IToken)Match(input,33,FOLLOW_33_in_map_pair525);  
            	stream_33.Add(char_literal31);

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:122:27: ( fskip )*
            	do 
            	{
            	    int alt10 = 2;
            	    alt10 = dfa10.Predict(input);
            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:122:27: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_map_pair527);
            			    	fskip32 = fskip();
            			    	state.followingStackPointer--;

            			    	stream_fskip.Add(fskip32.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	PushFollow(FOLLOW_value_in_map_pair530);
            	value33 = value();
            	state.followingStackPointer--;

            	stream_value.Add(value33.Tree);


            	// AST REWRITE
            	// elements:          string_expr, value, 33
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 123:3: -> ^( ':' string_expr value )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:123:6: ^( ':' string_expr value )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_33.NextNode(), root_1);

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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:126:1: list : ({...}? => block_list | flow_list );
    public YamlParser.list_return list() // throws RecognitionException [1]
    {   
        YamlParser.list_return retval = new YamlParser.list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        YamlParser.block_list_return block_list34 = default(YamlParser.block_list_return);

        YamlParser.flow_list_return flow_list35 = default(YamlParser.flow_list_return);



        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:127:2: ({...}? => block_list | flow_list )
            int alt11 = 2;
            int LA11_0 = input.LA(1);

            if ( (LA11_0 == INDENTATION || LA11_0 == LI) && ((!IsInFlow)) )
            {
                alt11 = 1;
            }
            else if ( (LA11_0 == 34) )
            {
                alt11 = 2;
            }
            else 
            {
                NoViableAltException nvae_d11s0 =
                    new NoViableAltException("", 11, 0, input);

                throw nvae_d11s0;
            }
            switch (alt11) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:127:4: {...}? => block_list
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	if ( !((!IsInFlow)) ) 
                    	{
                    	    throw new FailedPredicateException(input, "list", "!IsInFlow");
                    	}
                    	PushFollow(FOLLOW_block_list_in_list558);
                    	block_list34 = block_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, block_list34.Tree);

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:128:4: flow_list
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_flow_list_in_list563);
                    	flow_list35 = flow_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, flow_list35.Tree);

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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:132:1: fskip : ( NEWLINE | INDENTATION | INDENT | DEDENT );
    public YamlParser.fskip_return fskip() // throws RecognitionException [1]
    {   
        YamlParser.fskip_return retval = new YamlParser.fskip_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set36 = null;

        object set36_tree=null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:133:2: ( NEWLINE | INDENTATION | INDENT | DEDENT )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set36 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= INDENT && input.LA(1) <= DEDENT) || input.LA(1) == INDENTATION || input.LA(1) == NEWLINE ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set36));
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:136:1: flow_list : '[' ( fskip )* value ( fskip )* ( ',' ( fskip )* value ( fskip )* )* ']' -> ^( LIST ( value )+ ) ;
    public YamlParser.flow_list_return flow_list() // throws RecognitionException [1]
    {   
        YamlParser.flow_list_return retval = new YamlParser.flow_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal37 = null;
        IToken char_literal41 = null;
        IToken char_literal45 = null;
        YamlParser.fskip_return fskip38 = default(YamlParser.fskip_return);

        YamlParser.value_return value39 = default(YamlParser.value_return);

        YamlParser.fskip_return fskip40 = default(YamlParser.fskip_return);

        YamlParser.fskip_return fskip42 = default(YamlParser.fskip_return);

        YamlParser.value_return value43 = default(YamlParser.value_return);

        YamlParser.fskip_return fskip44 = default(YamlParser.fskip_return);


        object char_literal37_tree=null;
        object char_literal41_tree=null;
        object char_literal45_tree=null;
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleTokenStream stream_35 = new RewriteRuleTokenStream(adaptor,"token 35");
        RewriteRuleTokenStream stream_34 = new RewriteRuleTokenStream(adaptor,"token 34");
        RewriteRuleSubtreeStream stream_value = new RewriteRuleSubtreeStream(adaptor,"rule value");
        RewriteRuleSubtreeStream stream_fskip = new RewriteRuleSubtreeStream(adaptor,"rule fskip");

        	flowLvl++;
        	BlockLevel++;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:2: ( '[' ( fskip )* value ( fskip )* ( ',' ( fskip )* value ( fskip )* )* ']' -> ^( LIST ( value )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:4: '[' ( fskip )* value ( fskip )* ( ',' ( fskip )* value ( fskip )* )* ']'
            {
            	char_literal37=(IToken)Match(input,34,FOLLOW_34_in_flow_list606);  
            	stream_34.Add(char_literal37);

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:8: ( fskip )*
            	do 
            	{
            	    int alt12 = 2;
            	    alt12 = dfa12.Predict(input);
            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:8: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_flow_list608);
            			    	fskip38 = fskip();
            			    	state.followingStackPointer--;

            			    	stream_fskip.Add(fskip38.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	PushFollow(FOLLOW_value_in_flow_list611);
            	value39 = value();
            	state.followingStackPointer--;

            	stream_value.Add(value39.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:21: ( fskip )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( ((LA13_0 >= INDENT && LA13_0 <= DEDENT) || LA13_0 == INDENTATION || LA13_0 == NEWLINE) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:21: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_flow_list613);
            			    	fskip40 = fskip();
            			    	state.followingStackPointer--;

            			    	stream_fskip.Add(fskip40.Tree);

            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:28: ( ',' ( fskip )* value ( fskip )* )*
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( (LA16_0 == 31) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:29: ',' ( fskip )* value ( fskip )*
            			    {
            			    	char_literal41=(IToken)Match(input,31,FOLLOW_31_in_flow_list617);  
            			    	stream_31.Add(char_literal41);

            			    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:33: ( fskip )*
            			    	do 
            			    	{
            			    	    int alt14 = 2;
            			    	    alt14 = dfa14.Predict(input);
            			    	    switch (alt14) 
            			    		{
            			    			case 1 :
            			    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:33: fskip
            			    			    {
            			    			    	PushFollow(FOLLOW_fskip_in_flow_list619);
            			    			    	fskip42 = fskip();
            			    			    	state.followingStackPointer--;

            			    			    	stream_fskip.Add(fskip42.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop14;
            			    	    }
            			    	} while (true);

            			    	loop14:
            			    		;	// Stops C# compiler whining that label 'loop14' has no statements

            			    	PushFollow(FOLLOW_value_in_flow_list622);
            			    	value43 = value();
            			    	state.followingStackPointer--;

            			    	stream_value.Add(value43.Tree);
            			    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:46: ( fskip )*
            			    	do 
            			    	{
            			    	    int alt15 = 2;
            			    	    int LA15_0 = input.LA(1);

            			    	    if ( ((LA15_0 >= INDENT && LA15_0 <= DEDENT) || LA15_0 == INDENTATION || LA15_0 == NEWLINE) )
            			    	    {
            			    	        alt15 = 1;
            			    	    }


            			    	    switch (alt15) 
            			    		{
            			    			case 1 :
            			    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:46: fskip
            			    			    {
            			    			    	PushFollow(FOLLOW_fskip_in_flow_list624);
            			    			    	fskip44 = fskip();
            			    			    	state.followingStackPointer--;

            			    			    	stream_fskip.Add(fskip44.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop15;
            			    	    }
            			    	} while (true);

            			    	loop15:
            			    		;	// Stops C# compiler whining that label 'loop15' has no statements


            			    }
            			    break;

            			default:
            			    goto loop16;
            	    }
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements

            	char_literal45=(IToken)Match(input,35,FOLLOW_35_in_flow_list629);  
            	stream_35.Add(char_literal45);



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
            	// 142:3: -> ^( LIST ( value )+ )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:142:6: ^( LIST ( value )+ )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:149:1: block_list : ( INDENTATION INDENT ( block_list_item )+ INDENTATION DEDENT -> ^( LIST ( block_list_item )+ ) | {...}? ( block_list_item )+ -> ^( LIST ( block_list_item )+ ) );
    public YamlParser.block_list_return block_list() // throws RecognitionException [1]
    {   
        YamlParser.block_list_return retval = new YamlParser.block_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INDENTATION46 = null;
        IToken INDENT47 = null;
        IToken INDENTATION49 = null;
        IToken DEDENT50 = null;
        YamlParser.block_list_item_return block_list_item48 = default(YamlParser.block_list_item_return);

        YamlParser.block_list_item_return block_list_item51 = default(YamlParser.block_list_item_return);


        object INDENTATION46_tree=null;
        object INDENT47_tree=null;
        object INDENTATION49_tree=null;
        object DEDENT50_tree=null;
        RewriteRuleTokenStream stream_DEDENT = new RewriteRuleTokenStream(adaptor,"token DEDENT");
        RewriteRuleTokenStream stream_INDENT = new RewriteRuleTokenStream(adaptor,"token INDENT");
        RewriteRuleTokenStream stream_INDENTATION = new RewriteRuleTokenStream(adaptor,"token INDENTATION");
        RewriteRuleSubtreeStream stream_block_list_item = new RewriteRuleSubtreeStream(adaptor,"rule block_list_item");

        	BlockLevel++;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:153:2: ( INDENTATION INDENT ( block_list_item )+ INDENTATION DEDENT -> ^( LIST ( block_list_item )+ ) | {...}? ( block_list_item )+ -> ^( LIST ( block_list_item )+ ) )
            int alt19 = 2;
            int LA19_0 = input.LA(1);

            if ( (LA19_0 == INDENTATION) )
            {
                alt19 = 1;
            }
            else if ( (LA19_0 == LI) )
            {
                alt19 = 2;
            }
            else 
            {
                NoViableAltException nvae_d19s0 =
                    new NoViableAltException("", 19, 0, input);

                throw nvae_d19s0;
            }
            switch (alt19) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:153:4: INDENTATION INDENT ( block_list_item )+ INDENTATION DEDENT
                    {
                    	INDENTATION46=(IToken)Match(input,INDENTATION,FOLLOW_INDENTATION_in_block_list662);  
                    	stream_INDENTATION.Add(INDENTATION46);

                    	INDENT47=(IToken)Match(input,INDENT,FOLLOW_INDENT_in_block_list664);  
                    	stream_INDENT.Add(INDENT47);

                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:153:23: ( block_list_item )+
                    	int cnt17 = 0;
                    	do 
                    	{
                    	    int alt17 = 2;
                    	    int LA17_0 = input.LA(1);

                    	    if ( (LA17_0 == LI) )
                    	    {
                    	        alt17 = 1;
                    	    }


                    	    switch (alt17) 
                    		{
                    			case 1 :
                    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:153:23: block_list_item
                    			    {
                    			    	PushFollow(FOLLOW_block_list_item_in_block_list666);
                    			    	block_list_item48 = block_list_item();
                    			    	state.followingStackPointer--;

                    			    	stream_block_list_item.Add(block_list_item48.Tree);

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt17 >= 1 ) goto loop17;
                    		            EarlyExitException eee17 =
                    		                new EarlyExitException(17, input);
                    		            throw eee17;
                    	    }
                    	    cnt17++;
                    	} while (true);

                    	loop17:
                    		;	// Stops C# compiler whining that label 'loop17' has no statements

                    	INDENTATION49=(IToken)Match(input,INDENTATION,FOLLOW_INDENTATION_in_block_list669);  
                    	stream_INDENTATION.Add(INDENTATION49);

                    	DEDENT50=(IToken)Match(input,DEDENT,FOLLOW_DEDENT_in_block_list671);  
                    	stream_DEDENT.Add(DEDENT50);



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
                    	// 154:3: -> ^( LIST ( block_list_item )+ )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:154:6: ^( LIST ( block_list_item )+ )
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
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:155:4: {...}? ( block_list_item )+
                    {
                    	if ( !((flowLvl == 0)) ) 
                    	{
                    	    throw new FailedPredicateException(input, "block_list", "flowLvl == 0");
                    	}
                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:155:20: ( block_list_item )+
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
                    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:155:20: block_list_item
                    			    {
                    			    	PushFollow(FOLLOW_block_list_item_in_block_list689);
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
                    	// 156:3: -> ^( LIST ( block_list_item )+ )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:156:6: ^( LIST ( block_list_item )+ )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:162:1: block_list_item : {...}? LI value NEWLINE -> value ;
    public YamlParser.block_list_item_return block_list_item() // throws RecognitionException [1]
    {   
        block_list_item_stack.Push(new block_list_item_scope());
        YamlParser.block_list_item_return retval = new YamlParser.block_list_item_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LI52 = null;
        IToken NEWLINE54 = null;
        YamlParser.value_return value53 = default(YamlParser.value_return);


        object LI52_tree=null;
        object NEWLINE54_tree=null;
        RewriteRuleTokenStream stream_NEWLINE = new RewriteRuleTokenStream(adaptor,"token NEWLINE");
        RewriteRuleTokenStream stream_LI = new RewriteRuleTokenStream(adaptor,"token LI");
        RewriteRuleSubtreeStream stream_value = new RewriteRuleSubtreeStream(adaptor,"rule value");

        	((block_list_item_scope)block_list_item_stack.Peek()).lvl =  BlockLevel;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:169:2: ({...}? LI value NEWLINE -> value )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:169:4: {...}? LI value NEWLINE
            {
            	if ( !((((block_list_item_scope)block_list_item_stack.Peek()).lvl == BlockLevel)) ) 
            	{
            	    throw new FailedPredicateException(input, "block_list_item", "$block_list_item::lvl == BlockLevel");
            	}
            	LI52=(IToken)Match(input,LI,FOLLOW_LI_in_block_list_item728);  
            	stream_LI.Add(LI52);

            	PushFollow(FOLLOW_value_in_block_list_item730);
            	value53 = value();
            	state.followingStackPointer--;

            	stream_value.Add(value53.Tree);
            	NEWLINE54=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_block_list_item732);  
            	stream_NEWLINE.Add(NEWLINE54);



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
            	// 170:3: -> value
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


   	protected DFA10 dfa10;
   	protected DFA12 dfa12;
   	protected DFA14 dfa14;
	private void InitializeCyclicDFAs()
	{
    	this.dfa10 = new DFA10(this);
    	this.dfa12 = new DFA12(this);
    	this.dfa14 = new DFA14(this);
	    this.dfa10.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA10_SpecialStateTransition);
	    this.dfa12.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA12_SpecialStateTransition);
	    this.dfa14.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA14_SpecialStateTransition);
	}

    const string DFA10_eotS =
        "\x0b\uffff";
    const string DFA10_eofS =
        "\x0b\uffff";
    const string DFA10_minS =
        "\x01\x0d\x04\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA10_maxS =
        "\x01\x22\x04\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA10_acceptS =
        "\x01\uffff\x01\x02\x06\uffff\x02\x02\x01\x01";
    const string DFA10_specialS =
        "\x01\x00\x04\uffff\x01\x01\x01\uffff\x01\x02\x03\uffff}>";
    static readonly string[] DFA10_transitionS = {
            "\x01\x05\x01\x0a\x01\uffff\x01\x07\x01\x01\x02\uffff\x01\x08"+
            "\x01\x01\x01\uffff\x01\x01\x01\uffff\x01\x01\x01\x0a\x03\uffff"+
            "\x01\x01\x03\uffff\x01\x09",
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

    static readonly short[] DFA10_eot = DFA.UnpackEncodedString(DFA10_eotS);
    static readonly short[] DFA10_eof = DFA.UnpackEncodedString(DFA10_eofS);
    static readonly char[] DFA10_min = DFA.UnpackEncodedStringToUnsignedChars(DFA10_minS);
    static readonly char[] DFA10_max = DFA.UnpackEncodedStringToUnsignedChars(DFA10_maxS);
    static readonly short[] DFA10_accept = DFA.UnpackEncodedString(DFA10_acceptS);
    static readonly short[] DFA10_special = DFA.UnpackEncodedString(DFA10_specialS);
    static readonly short[][] DFA10_transition = DFA.UnpackEncodedStringArray(DFA10_transitionS);

    protected class DFA10 : DFA
    {
        public DFA10(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 10;
            this.eot = DFA10_eot;
            this.eof = DFA10_eof;
            this.min = DFA10_min;
            this.max = DFA10_max;
            this.accept = DFA10_accept;
            this.special = DFA10_special;
            this.transition = DFA10_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 122:27: ( fskip )*"; }
        }

    }


    protected internal int DFA10_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA10_0 = input.LA(1);

                   	 
                   	int index10_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA10_0 == Integer || LA10_0 == Float || LA10_0 == QuotedString || LA10_0 == Bool || LA10_0 == 30) ) { s = 1; }

                   	else if ( (LA10_0 == INDENT) ) { s = 5; }

                   	else if ( (LA10_0 == INDENTATION) ) { s = 7; }

                   	else if ( (LA10_0 == LI) && ((!IsInFlow)) ) { s = 8; }

                   	else if ( (LA10_0 == 34) ) { s = 9; }

                   	else if ( (LA10_0 == DEDENT || LA10_0 == NEWLINE) ) { s = 10; }

                   	 
                   	input.Seek(index10_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA10_5 = input.LA(1);

                   	 
                   	int index10_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 10; }

                   	else if ( ((!IsInFlow)) ) { s = 9; }

                   	 
                   	input.Seek(index10_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA10_7 = input.LA(1);

                   	 
                   	int index10_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 10; }

                   	else if ( ((!IsInFlow)) ) { s = 9; }

                   	 
                   	input.Seek(index10_7);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae10 =
            new NoViableAltException(dfa.Description, 10, _s, input);
        dfa.Error(nvae10);
        throw nvae10;
    }
    const string DFA12_eotS =
        "\x0b\uffff";
    const string DFA12_eofS =
        "\x0b\uffff";
    const string DFA12_minS =
        "\x01\x0d\x04\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA12_maxS =
        "\x01\x22\x04\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA12_acceptS =
        "\x01\uffff\x01\x02\x06\uffff\x02\x02\x01\x01";
    const string DFA12_specialS =
        "\x01\x00\x04\uffff\x01\x01\x01\uffff\x01\x02\x03\uffff}>";
    static readonly string[] DFA12_transitionS = {
            "\x01\x05\x01\x0a\x01\uffff\x01\x07\x01\x01\x02\uffff\x01\x08"+
            "\x01\x01\x01\uffff\x01\x01\x01\uffff\x01\x01\x01\x0a\x03\uffff"+
            "\x01\x01\x03\uffff\x01\x09",
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

    static readonly short[] DFA12_eot = DFA.UnpackEncodedString(DFA12_eotS);
    static readonly short[] DFA12_eof = DFA.UnpackEncodedString(DFA12_eofS);
    static readonly char[] DFA12_min = DFA.UnpackEncodedStringToUnsignedChars(DFA12_minS);
    static readonly char[] DFA12_max = DFA.UnpackEncodedStringToUnsignedChars(DFA12_maxS);
    static readonly short[] DFA12_accept = DFA.UnpackEncodedString(DFA12_acceptS);
    static readonly short[] DFA12_special = DFA.UnpackEncodedString(DFA12_specialS);
    static readonly short[][] DFA12_transition = DFA.UnpackEncodedStringArray(DFA12_transitionS);

    protected class DFA12 : DFA
    {
        public DFA12(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 12;
            this.eot = DFA12_eot;
            this.eof = DFA12_eof;
            this.min = DFA12_min;
            this.max = DFA12_max;
            this.accept = DFA12_accept;
            this.special = DFA12_special;
            this.transition = DFA12_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 141:8: ( fskip )*"; }
        }

    }


    protected internal int DFA12_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA12_0 = input.LA(1);

                   	 
                   	int index12_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA12_0 == Integer || LA12_0 == Float || LA12_0 == QuotedString || LA12_0 == Bool || LA12_0 == 30) ) { s = 1; }

                   	else if ( (LA12_0 == INDENT) ) { s = 5; }

                   	else if ( (LA12_0 == INDENTATION) ) { s = 7; }

                   	else if ( (LA12_0 == LI) && ((!IsInFlow)) ) { s = 8; }

                   	else if ( (LA12_0 == 34) ) { s = 9; }

                   	else if ( (LA12_0 == DEDENT || LA12_0 == NEWLINE) ) { s = 10; }

                   	 
                   	input.Seek(index12_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA12_5 = input.LA(1);

                   	 
                   	int index12_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 10; }

                   	else if ( ((!IsInFlow)) ) { s = 9; }

                   	 
                   	input.Seek(index12_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA12_7 = input.LA(1);

                   	 
                   	int index12_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 10; }

                   	else if ( ((!IsInFlow)) ) { s = 9; }

                   	 
                   	input.Seek(index12_7);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae12 =
            new NoViableAltException(dfa.Description, 12, _s, input);
        dfa.Error(nvae12);
        throw nvae12;
    }
    const string DFA14_eotS =
        "\x0b\uffff";
    const string DFA14_eofS =
        "\x0b\uffff";
    const string DFA14_minS =
        "\x01\x0d\x04\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA14_maxS =
        "\x01\x22\x04\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA14_acceptS =
        "\x01\uffff\x01\x02\x06\uffff\x02\x02\x01\x01";
    const string DFA14_specialS =
        "\x01\x00\x04\uffff\x01\x01\x01\uffff\x01\x02\x03\uffff}>";
    static readonly string[] DFA14_transitionS = {
            "\x01\x05\x01\x0a\x01\uffff\x01\x07\x01\x01\x02\uffff\x01\x08"+
            "\x01\x01\x01\uffff\x01\x01\x01\uffff\x01\x01\x01\x0a\x03\uffff"+
            "\x01\x01\x03\uffff\x01\x09",
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

    static readonly short[] DFA14_eot = DFA.UnpackEncodedString(DFA14_eotS);
    static readonly short[] DFA14_eof = DFA.UnpackEncodedString(DFA14_eofS);
    static readonly char[] DFA14_min = DFA.UnpackEncodedStringToUnsignedChars(DFA14_minS);
    static readonly char[] DFA14_max = DFA.UnpackEncodedStringToUnsignedChars(DFA14_maxS);
    static readonly short[] DFA14_accept = DFA.UnpackEncodedString(DFA14_acceptS);
    static readonly short[] DFA14_special = DFA.UnpackEncodedString(DFA14_specialS);
    static readonly short[][] DFA14_transition = DFA.UnpackEncodedStringArray(DFA14_transitionS);

    protected class DFA14 : DFA
    {
        public DFA14(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 14;
            this.eot = DFA14_eot;
            this.eof = DFA14_eof;
            this.min = DFA14_min;
            this.max = DFA14_max;
            this.accept = DFA14_accept;
            this.special = DFA14_special;
            this.transition = DFA14_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 141:33: ( fskip )*"; }
        }

    }


    protected internal int DFA14_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA14_0 = input.LA(1);

                   	 
                   	int index14_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA14_0 == Integer || LA14_0 == Float || LA14_0 == QuotedString || LA14_0 == Bool || LA14_0 == 30) ) { s = 1; }

                   	else if ( (LA14_0 == INDENT) ) { s = 5; }

                   	else if ( (LA14_0 == INDENTATION) ) { s = 7; }

                   	else if ( (LA14_0 == LI) && ((!IsInFlow)) ) { s = 8; }

                   	else if ( (LA14_0 == 34) ) { s = 9; }

                   	else if ( (LA14_0 == DEDENT || LA14_0 == NEWLINE) ) { s = 10; }

                   	 
                   	input.Seek(index14_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA14_5 = input.LA(1);

                   	 
                   	int index14_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 10; }

                   	else if ( ((!IsInFlow)) ) { s = 9; }

                   	 
                   	input.Seek(index14_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA14_7 = input.LA(1);

                   	 
                   	int index14_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 10; }

                   	else if ( ((!IsInFlow)) ) { s = 9; }

                   	 
                   	input.Seek(index14_7);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae14 =
            new NoViableAltException(dfa.Description, 14, _s, input);
        dfa.Error(nvae14);
        throw nvae14;
    }
 

    public static readonly BitSet FOLLOW_boolean_in_value142 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_integer_in_value147 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_float_expr_in_value153 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string_expr_in_value158 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_map_in_value163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_list_in_value168 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Integer_in_integer179 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Float_in_float_expr239 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QuotedString_in_string_expr315 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Bool_in_boolean358 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_30_in_flow_map401 = new BitSet(new ulong[]{0x0000000004816000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_map403 = new BitSet(new ulong[]{0x0000000004816000UL});
    public static readonly BitSet FOLLOW_map_pair_in_flow_map406 = new BitSet(new ulong[]{0x0000000184016000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_map408 = new BitSet(new ulong[]{0x0000000184016000UL});
    public static readonly BitSet FOLLOW_31_in_flow_map412 = new BitSet(new ulong[]{0x0000000004816000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_map414 = new BitSet(new ulong[]{0x0000000004816000UL});
    public static readonly BitSet FOLLOW_map_pair_in_flow_map417 = new BitSet(new ulong[]{0x0000000184016000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_map419 = new BitSet(new ulong[]{0x0000000184016000UL});
    public static readonly BitSet FOLLOW_32_in_flow_map425 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INDENT_in_block_map457 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_DENT_in_block_map459 = new BitSet(new ulong[]{0x0000000004816000UL});
    public static readonly BitSet FOLLOW_map_pair_in_block_map461 = new BitSet(new ulong[]{0x0000000004004000UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_block_map464 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_DENT_in_block_map466 = new BitSet(new ulong[]{0x0000000004816000UL});
    public static readonly BitSet FOLLOW_map_pair_in_block_map468 = new BitSet(new ulong[]{0x0000000004004000UL});
    public static readonly BitSet FOLLOW_DEDENT_in_block_map472 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_map_in_map503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_flow_map_in_map508 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string_expr_in_map_pair520 = new BitSet(new ulong[]{0x0000000204016000UL});
    public static readonly BitSet FOLLOW_fskip_in_map_pair522 = new BitSet(new ulong[]{0x0000000204016000UL});
    public static readonly BitSet FOLLOW_33_in_map_pair525 = new BitSet(new ulong[]{0x0000000446B36000UL});
    public static readonly BitSet FOLLOW_fskip_in_map_pair527 = new BitSet(new ulong[]{0x0000000446B36000UL});
    public static readonly BitSet FOLLOW_value_in_map_pair530 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_list_in_list558 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_flow_list_in_list563 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_fskip0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_34_in_flow_list606 = new BitSet(new ulong[]{0x0000000446B36000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_list608 = new BitSet(new ulong[]{0x0000000446B36000UL});
    public static readonly BitSet FOLLOW_value_in_flow_list611 = new BitSet(new ulong[]{0x0000000884016000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_list613 = new BitSet(new ulong[]{0x0000000884016000UL});
    public static readonly BitSet FOLLOW_31_in_flow_list617 = new BitSet(new ulong[]{0x0000000446B36000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_list619 = new BitSet(new ulong[]{0x0000000446B36000UL});
    public static readonly BitSet FOLLOW_value_in_flow_list622 = new BitSet(new ulong[]{0x0000000884016000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_list624 = new BitSet(new ulong[]{0x0000000884016000UL});
    public static readonly BitSet FOLLOW_35_in_flow_list629 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INDENTATION_in_block_list662 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_INDENT_in_block_list664 = new BitSet(new ulong[]{0x0000000000110000UL});
    public static readonly BitSet FOLLOW_block_list_item_in_block_list666 = new BitSet(new ulong[]{0x0000000000110000UL});
    public static readonly BitSet FOLLOW_INDENTATION_in_block_list669 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DEDENT_in_block_list671 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_list_item_in_block_list689 = new BitSet(new ulong[]{0x0000000000110002UL});
    public static readonly BitSet FOLLOW_LI_in_block_list_item728 = new BitSet(new ulong[]{0x0000000446B36000UL});
    public static readonly BitSet FOLLOW_value_in_block_list_item730 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_block_list_item732 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}