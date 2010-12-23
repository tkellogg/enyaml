// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g 2010-12-23 15:36:29

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
		"INDENTATION", 
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
    public const int Bool = 24;
    public const int DOUBLE_QUOTE = 9;
    public const int BOOL = 8;
    public const int Exponent = 21;
    public const int DEDENT = 14;
    public const int FLOAT = 7;
    public const int QuotedString = 22;
    public const int EOF = -1;
    public const int LIST = 12;
    public const int HexDigit = 18;
    public const int DecDigit = 17;
    public const int INDENT = 13;
    public const int Float = 20;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int SINGLE_QUOTE = 10;
    public const int NonColonChars = 28;
    public const int T__32 = 32;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int NEWLINE = 25;
    public const int T__35 = 35;
    public const int DENT = 15;
    public const int UnicodeEscape = 29;
    public const int MAP = 11;
    public const int QUOTED_STRING = 4;
    public const int UnQuotedStringChars = 23;
    public const int LI = 19;
    public const int UNQUOTED_STRING = 5;
    public const int EscapeSequence = 27;
    public const int Integer = 16;
    public const int INDENTATION = 26;

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


    	protected int flowLvl = 0;
    	protected bool IsInFlow{ get { return flowLvl > 0; } }


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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:57:1: value : ( boolean | integer | float_expr | string_expr | map | list );
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:58:2: ( boolean | integer | float_expr | string_expr | map | list )
            int alt1 = 6;
            alt1 = dfa1.Predict(input);
            switch (alt1) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:58:4: boolean
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_boolean_in_value126);
                    	boolean1 = boolean();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, boolean1.Tree);

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:59:4: integer
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_integer_in_value131);
                    	integer2 = integer();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, integer2.Tree);

                    }
                    break;
                case 3 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:60:4: float_expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_float_expr_in_value137);
                    	float_expr3 = float_expr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, float_expr3.Tree);

                    }
                    break;
                case 4 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:61:4: string_expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_string_expr_in_value142);
                    	string_expr4 = string_expr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, string_expr4.Tree);

                    }
                    break;
                case 5 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:62:4: map
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_map_in_value147);
                    	map5 = map();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, map5.Tree);

                    }
                    break;
                case 6 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:63:4: list
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_list_in_value152);
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:66:1: integer : Integer -> ^( INTEGER Integer ) ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:67:2: ( Integer -> ^( INTEGER Integer ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:67:4: Integer
            {
            	Integer7=(IToken)Match(input,Integer,FOLLOW_Integer_in_integer163);  
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
            	// 67:12: -> ^( INTEGER Integer )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:67:15: ^( INTEGER Integer )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:79:1: float_expr : Float -> ^( FLOAT Float ) ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:80:2: ( Float -> ^( FLOAT Float ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:80:4: Float
            {
            	Float8=(IToken)Match(input,Float,FOLLOW_Float_in_float_expr223);  
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
            	// 80:10: -> ^( FLOAT Float )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:80:13: ^( FLOAT Float )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:91:1: string_expr : QuotedString -> ^( QUOTED_STRING QuotedString ) ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:92:2: ( QuotedString -> ^( QUOTED_STRING QuotedString ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:92:4: QuotedString
            {
            	QuotedString9=(IToken)Match(input,QuotedString,FOLLOW_QuotedString_in_string_expr299);  
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
            	// 92:17: -> ^( QUOTED_STRING QuotedString )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:92:20: ^( QUOTED_STRING QuotedString )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:104:1: boolean : Bool -> ^( BOOL Bool ) ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:105:2: ( Bool -> ^( BOOL Bool ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:105:4: Bool
            {
            	Bool10=(IToken)Match(input,Bool,FOLLOW_Bool_in_boolean342);  
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
            	// 105:9: -> ^( BOOL Bool )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:105:12: ^( BOOL Bool )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:112:1: flow_map : '{' map_pair ( ',' map_pair )* '}' -> ^( MAP ( map_pair )+ ) ;
    public YamlParser.flow_map_return flow_map() // throws RecognitionException [1]
    {   
        YamlParser.flow_map_return retval = new YamlParser.flow_map_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal11 = null;
        IToken char_literal13 = null;
        IToken char_literal15 = null;
        YamlParser.map_pair_return map_pair12 = default(YamlParser.map_pair_return);

        YamlParser.map_pair_return map_pair14 = default(YamlParser.map_pair_return);


        object char_literal11_tree=null;
        object char_literal13_tree=null;
        object char_literal15_tree=null;
        RewriteRuleTokenStream stream_30 = new RewriteRuleTokenStream(adaptor,"token 30");
        RewriteRuleTokenStream stream_32 = new RewriteRuleTokenStream(adaptor,"token 32");
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleSubtreeStream stream_map_pair = new RewriteRuleSubtreeStream(adaptor,"rule map_pair");
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:119:2: ( '{' map_pair ( ',' map_pair )* '}' -> ^( MAP ( map_pair )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:119:4: '{' map_pair ( ',' map_pair )* '}'
            {
            	char_literal11=(IToken)Match(input,30,FOLLOW_30_in_flow_map390);  
            	stream_30.Add(char_literal11);

            	PushFollow(FOLLOW_map_pair_in_flow_map392);
            	map_pair12 = map_pair();
            	state.followingStackPointer--;

            	stream_map_pair.Add(map_pair12.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:119:17: ( ',' map_pair )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == 31) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:119:18: ',' map_pair
            			    {
            			    	char_literal13=(IToken)Match(input,31,FOLLOW_31_in_flow_map395);  
            			    	stream_31.Add(char_literal13);

            			    	PushFollow(FOLLOW_map_pair_in_flow_map397);
            			    	map_pair14 = map_pair();
            			    	state.followingStackPointer--;

            			    	stream_map_pair.Add(map_pair14.Tree);

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	char_literal15=(IToken)Match(input,32,FOLLOW_32_in_flow_map401);  
            	stream_32.Add(char_literal15);



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
            	// 120:3: -> ^( MAP ( map_pair )+ )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:120:6: ^( MAP ( map_pair )+ )
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

            	flowLvl--;

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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:123:1: block_map : INDENT DENT map_pair ( NEWLINE DENT map_pair )* DEDENT -> ^( MAP ( map_pair )+ ) ;
    public YamlParser.block_map_return block_map() // throws RecognitionException [1]
    {   
        YamlParser.block_map_return retval = new YamlParser.block_map_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INDENT16 = null;
        IToken DENT17 = null;
        IToken NEWLINE19 = null;
        IToken DENT20 = null;
        IToken DEDENT22 = null;
        YamlParser.map_pair_return map_pair18 = default(YamlParser.map_pair_return);

        YamlParser.map_pair_return map_pair21 = default(YamlParser.map_pair_return);


        object INDENT16_tree=null;
        object DENT17_tree=null;
        object NEWLINE19_tree=null;
        object DENT20_tree=null;
        object DEDENT22_tree=null;
        RewriteRuleTokenStream stream_DEDENT = new RewriteRuleTokenStream(adaptor,"token DEDENT");
        RewriteRuleTokenStream stream_NEWLINE = new RewriteRuleTokenStream(adaptor,"token NEWLINE");
        RewriteRuleTokenStream stream_DENT = new RewriteRuleTokenStream(adaptor,"token DENT");
        RewriteRuleTokenStream stream_INDENT = new RewriteRuleTokenStream(adaptor,"token INDENT");
        RewriteRuleSubtreeStream stream_map_pair = new RewriteRuleSubtreeStream(adaptor,"rule map_pair");
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:124:2: ( INDENT DENT map_pair ( NEWLINE DENT map_pair )* DEDENT -> ^( MAP ( map_pair )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:124:4: INDENT DENT map_pair ( NEWLINE DENT map_pair )* DEDENT
            {
            	INDENT16=(IToken)Match(input,INDENT,FOLLOW_INDENT_in_block_map424);  
            	stream_INDENT.Add(INDENT16);

            	DENT17=(IToken)Match(input,DENT,FOLLOW_DENT_in_block_map426);  
            	stream_DENT.Add(DENT17);

            	PushFollow(FOLLOW_map_pair_in_block_map428);
            	map_pair18 = map_pair();
            	state.followingStackPointer--;

            	stream_map_pair.Add(map_pair18.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:124:25: ( NEWLINE DENT map_pair )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == NEWLINE) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:124:26: NEWLINE DENT map_pair
            			    {
            			    	NEWLINE19=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_block_map431);  
            			    	stream_NEWLINE.Add(NEWLINE19);

            			    	DENT20=(IToken)Match(input,DENT,FOLLOW_DENT_in_block_map433);  
            			    	stream_DENT.Add(DENT20);

            			    	PushFollow(FOLLOW_map_pair_in_block_map435);
            			    	map_pair21 = map_pair();
            			    	state.followingStackPointer--;

            			    	stream_map_pair.Add(map_pair21.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	DEDENT22=(IToken)Match(input,DEDENT,FOLLOW_DEDENT_in_block_map439);  
            	stream_DEDENT.Add(DEDENT22);



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
            	// 125:3: -> ^( MAP ( map_pair )+ )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:125:6: ^( MAP ( map_pair )+ )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:128:1: map : ({...}? => block_map | flow_map );
    public YamlParser.map_return map() // throws RecognitionException [1]
    {   
        YamlParser.map_return retval = new YamlParser.map_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        YamlParser.block_map_return block_map23 = default(YamlParser.block_map_return);

        YamlParser.flow_map_return flow_map24 = default(YamlParser.flow_map_return);



        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:129:2: ({...}? => block_map | flow_map )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == INDENT) && ((!IsInFlow)) )
            {
                alt4 = 1;
            }
            else if ( (LA4_0 == 30) )
            {
                alt4 = 2;
            }
            else 
            {
                NoViableAltException nvae_d4s0 =
                    new NoViableAltException("", 4, 0, input);

                throw nvae_d4s0;
            }
            switch (alt4) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:129:4: {...}? => block_map
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	if ( !((!IsInFlow)) ) 
                    	{
                    	    throw new FailedPredicateException(input, "map", "!IsInFlow");
                    	}
                    	PushFollow(FOLLOW_block_map_in_map466);
                    	block_map23 = block_map();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, block_map23.Tree);

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:130:4: flow_map
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_flow_map_in_map471);
                    	flow_map24 = flow_map();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, flow_map24.Tree);

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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:133:1: map_pair : string_expr ':' value -> ^( ':' string_expr value ) ;
    public YamlParser.map_pair_return map_pair() // throws RecognitionException [1]
    {   
        YamlParser.map_pair_return retval = new YamlParser.map_pair_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal26 = null;
        YamlParser.string_expr_return string_expr25 = default(YamlParser.string_expr_return);

        YamlParser.value_return value27 = default(YamlParser.value_return);


        object char_literal26_tree=null;
        RewriteRuleTokenStream stream_33 = new RewriteRuleTokenStream(adaptor,"token 33");
        RewriteRuleSubtreeStream stream_value = new RewriteRuleSubtreeStream(adaptor,"rule value");
        RewriteRuleSubtreeStream stream_string_expr = new RewriteRuleSubtreeStream(adaptor,"rule string_expr");
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:134:2: ( string_expr ':' value -> ^( ':' string_expr value ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:134:4: string_expr ':' value
            {
            	PushFollow(FOLLOW_string_expr_in_map_pair483);
            	string_expr25 = string_expr();
            	state.followingStackPointer--;

            	stream_string_expr.Add(string_expr25.Tree);
            	char_literal26=(IToken)Match(input,33,FOLLOW_33_in_map_pair485);  
            	stream_33.Add(char_literal26);

            	PushFollow(FOLLOW_value_in_map_pair487);
            	value27 = value();
            	state.followingStackPointer--;

            	stream_value.Add(value27.Tree);


            	// AST REWRITE
            	// elements:          value, string_expr, 33
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 135:3: -> ^( ':' string_expr value )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:135:6: ^( ':' string_expr value )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:138:1: list : ({...}? => block_list | flow_list );
    public YamlParser.list_return list() // throws RecognitionException [1]
    {   
        YamlParser.list_return retval = new YamlParser.list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        YamlParser.block_list_return block_list28 = default(YamlParser.block_list_return);

        YamlParser.flow_list_return flow_list29 = default(YamlParser.flow_list_return);



        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:139:2: ({...}? => block_list | flow_list )
            int alt5 = 2;
            int LA5_0 = input.LA(1);

            if ( (LA5_0 == INDENT) && ((!IsInFlow)) )
            {
                alt5 = 1;
            }
            else if ( (LA5_0 == 34) )
            {
                alt5 = 2;
            }
            else 
            {
                NoViableAltException nvae_d5s0 =
                    new NoViableAltException("", 5, 0, input);

                throw nvae_d5s0;
            }
            switch (alt5) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:139:4: {...}? => block_list
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	if ( !((!IsInFlow)) ) 
                    	{
                    	    throw new FailedPredicateException(input, "list", "!IsInFlow");
                    	}
                    	PushFollow(FOLLOW_block_list_in_list515);
                    	block_list28 = block_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, block_list28.Tree);

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:140:4: flow_list
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_flow_list_in_list520);
                    	flow_list29 = flow_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, flow_list29.Tree);

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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:143:1: flow_list : '[' value ( ',' value )* ']' -> ^( LIST ( value )+ ) ;
    public YamlParser.flow_list_return flow_list() // throws RecognitionException [1]
    {   
        YamlParser.flow_list_return retval = new YamlParser.flow_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal30 = null;
        IToken char_literal32 = null;
        IToken char_literal34 = null;
        YamlParser.value_return value31 = default(YamlParser.value_return);

        YamlParser.value_return value33 = default(YamlParser.value_return);


        object char_literal30_tree=null;
        object char_literal32_tree=null;
        object char_literal34_tree=null;
        RewriteRuleTokenStream stream_31 = new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleTokenStream stream_35 = new RewriteRuleTokenStream(adaptor,"token 35");
        RewriteRuleTokenStream stream_34 = new RewriteRuleTokenStream(adaptor,"token 34");
        RewriteRuleSubtreeStream stream_value = new RewriteRuleSubtreeStream(adaptor,"rule value");
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:150:2: ( '[' value ( ',' value )* ']' -> ^( LIST ( value )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:150:4: '[' value ( ',' value )* ']'
            {
            	char_literal30=(IToken)Match(input,34,FOLLOW_34_in_flow_list543);  
            	stream_34.Add(char_literal30);

            	PushFollow(FOLLOW_value_in_flow_list545);
            	value31 = value();
            	state.followingStackPointer--;

            	stream_value.Add(value31.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:150:14: ( ',' value )*
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
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:150:15: ',' value
            			    {
            			    	char_literal32=(IToken)Match(input,31,FOLLOW_31_in_flow_list548);  
            			    	stream_31.Add(char_literal32);

            			    	PushFollow(FOLLOW_value_in_flow_list550);
            			    	value33 = value();
            			    	state.followingStackPointer--;

            			    	stream_value.Add(value33.Tree);

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements

            	char_literal34=(IToken)Match(input,35,FOLLOW_35_in_flow_list554);  
            	stream_35.Add(char_literal34);



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
            	// 151:3: -> ^( LIST ( value )+ )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:151:6: ^( LIST ( value )+ )
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

            	flowLvl--;

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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:154:1: block_list : INDENT ( block_list_item )+ DEDENT -> ^( LIST ( block_list_item )+ ) ;
    public YamlParser.block_list_return block_list() // throws RecognitionException [1]
    {   
        YamlParser.block_list_return retval = new YamlParser.block_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INDENT35 = null;
        IToken DEDENT37 = null;
        YamlParser.block_list_item_return block_list_item36 = default(YamlParser.block_list_item_return);


        object INDENT35_tree=null;
        object DEDENT37_tree=null;
        RewriteRuleTokenStream stream_DEDENT = new RewriteRuleTokenStream(adaptor,"token DEDENT");
        RewriteRuleTokenStream stream_INDENT = new RewriteRuleTokenStream(adaptor,"token INDENT");
        RewriteRuleSubtreeStream stream_block_list_item = new RewriteRuleSubtreeStream(adaptor,"rule block_list_item");
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:155:2: ( INDENT ( block_list_item )+ DEDENT -> ^( LIST ( block_list_item )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:155:4: INDENT ( block_list_item )+ DEDENT
            {
            	INDENT35=(IToken)Match(input,INDENT,FOLLOW_INDENT_in_block_list578);  
            	stream_INDENT.Add(INDENT35);

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:155:11: ( block_list_item )+
            	int cnt7 = 0;
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == LI) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:155:11: block_list_item
            			    {
            			    	PushFollow(FOLLOW_block_list_item_in_block_list580);
            			    	block_list_item36 = block_list_item();
            			    	state.followingStackPointer--;

            			    	stream_block_list_item.Add(block_list_item36.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt7 >= 1 ) goto loop7;
            		            EarlyExitException eee7 =
            		                new EarlyExitException(7, input);
            		            throw eee7;
            	    }
            	    cnt7++;
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

            	DEDENT37=(IToken)Match(input,DEDENT,FOLLOW_DEDENT_in_block_list583);  
            	stream_DEDENT.Add(DEDENT37);



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
    // $ANTLR end "block_list"

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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:159:1: block_list_item : LI value NEWLINE -> value ;
    public YamlParser.block_list_item_return block_list_item() // throws RecognitionException [1]
    {   
        YamlParser.block_list_item_return retval = new YamlParser.block_list_item_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LI38 = null;
        IToken NEWLINE40 = null;
        YamlParser.value_return value39 = default(YamlParser.value_return);


        object LI38_tree=null;
        object NEWLINE40_tree=null;
        RewriteRuleTokenStream stream_NEWLINE = new RewriteRuleTokenStream(adaptor,"token NEWLINE");
        RewriteRuleTokenStream stream_LI = new RewriteRuleTokenStream(adaptor,"token LI");
        RewriteRuleSubtreeStream stream_value = new RewriteRuleSubtreeStream(adaptor,"rule value");
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:160:2: ( LI value NEWLINE -> value )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:160:4: LI value NEWLINE
            {
            	LI38=(IToken)Match(input,LI,FOLLOW_LI_in_block_list_item606);  
            	stream_LI.Add(LI38);

            	PushFollow(FOLLOW_value_in_block_list_item608);
            	value39 = value();
            	state.followingStackPointer--;

            	stream_value.Add(value39.Tree);
            	NEWLINE40=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_block_list_item610);  
            	stream_NEWLINE.Add(NEWLINE40);



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
            	// 161:3: -> value
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
        }
        return retval;
    }
    // $ANTLR end "block_list_item"

    // Delegated rules


   	protected DFA1 dfa1;
	private void InitializeCyclicDFAs()
	{
    	this.dfa1 = new DFA1(this);
	    this.dfa1.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA1_SpecialStateTransition);
	}

    const string DFA1_eotS =
        "\x0a\uffff";
    const string DFA1_eofS =
        "\x0a\uffff";
    const string DFA1_minS =
        "\x01\x0d\x04\uffff\x01\x0f\x04\uffff";
    const string DFA1_maxS =
        "\x01\x22\x04\uffff\x01\x13\x04\uffff";
    const string DFA1_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\uffff\x01\x05\x01"+
        "\x06\x01\x05\x01\x06";
    const string DFA1_specialS =
        "\x01\x01\x04\uffff\x01\x00\x04\uffff}>";
    static readonly string[] DFA1_transitionS = {
            "\x01\x05\x02\uffff\x01\x02\x03\uffff\x01\x03\x01\uffff\x01"+
            "\x04\x01\uffff\x01\x01\x05\uffff\x01\x06\x03\uffff\x01\x07",
            "",
            "",
            "",
            "",
            "\x01\x08\x03\uffff\x01\x09",
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
            get { return "57:1: value : ( boolean | integer | float_expr | string_expr | map | list );"; }
        }

    }


    protected internal int DFA1_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA1_5 = input.LA(1);

                   	 
                   	int index1_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA1_5 == DENT) && ((!IsInFlow)) ) { s = 8; }

                   	else if ( (LA1_5 == LI) && ((!IsInFlow)) ) { s = 9; }

                   	 
                   	input.Seek(index1_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA1_0 = input.LA(1);

                   	 
                   	int index1_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA1_0 == Bool) ) { s = 1; }

                   	else if ( (LA1_0 == Integer) ) { s = 2; }

                   	else if ( (LA1_0 == Float) ) { s = 3; }

                   	else if ( (LA1_0 == QuotedString) ) { s = 4; }

                   	else if ( (LA1_0 == INDENT) && ((!IsInFlow)) ) { s = 5; }

                   	else if ( (LA1_0 == 30) ) { s = 6; }

                   	else if ( (LA1_0 == 34) ) { s = 7; }

                   	 
                   	input.Seek(index1_0);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae1 =
            new NoViableAltException(dfa.Description, 1, _s, input);
        dfa.Error(nvae1);
        throw nvae1;
    }
 

    public static readonly BitSet FOLLOW_boolean_in_value126 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_integer_in_value131 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_float_expr_in_value137 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string_expr_in_value142 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_map_in_value147 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_list_in_value152 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Integer_in_integer163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Float_in_float_expr223 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QuotedString_in_string_expr299 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Bool_in_boolean342 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_30_in_flow_map390 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_map_pair_in_flow_map392 = new BitSet(new ulong[]{0x0000000180000000UL});
    public static readonly BitSet FOLLOW_31_in_flow_map395 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_map_pair_in_flow_map397 = new BitSet(new ulong[]{0x0000000180000000UL});
    public static readonly BitSet FOLLOW_32_in_flow_map401 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INDENT_in_block_map424 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_DENT_in_block_map426 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_map_pair_in_block_map428 = new BitSet(new ulong[]{0x0000000002004000UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_block_map431 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_DENT_in_block_map433 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_map_pair_in_block_map435 = new BitSet(new ulong[]{0x0000000002004000UL});
    public static readonly BitSet FOLLOW_DEDENT_in_block_map439 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_map_in_map466 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_flow_map_in_map471 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string_expr_in_map_pair483 = new BitSet(new ulong[]{0x0000000200000000UL});
    public static readonly BitSet FOLLOW_33_in_map_pair485 = new BitSet(new ulong[]{0x0000000441512000UL});
    public static readonly BitSet FOLLOW_value_in_map_pair487 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_list_in_list515 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_flow_list_in_list520 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_34_in_flow_list543 = new BitSet(new ulong[]{0x0000000441512000UL});
    public static readonly BitSet FOLLOW_value_in_flow_list545 = new BitSet(new ulong[]{0x0000000880000000UL});
    public static readonly BitSet FOLLOW_31_in_flow_list548 = new BitSet(new ulong[]{0x0000000441512000UL});
    public static readonly BitSet FOLLOW_value_in_flow_list550 = new BitSet(new ulong[]{0x0000000880000000UL});
    public static readonly BitSet FOLLOW_35_in_flow_list554 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INDENT_in_block_list578 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_block_list_item_in_block_list580 = new BitSet(new ulong[]{0x0000000000084000UL});
    public static readonly BitSet FOLLOW_DEDENT_in_block_list583 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LI_in_block_list_item606 = new BitSet(new ulong[]{0x0000000441512000UL});
    public static readonly BitSet FOLLOW_value_in_block_list_item608 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_block_list_item610 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}