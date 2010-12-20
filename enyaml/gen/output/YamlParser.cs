// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g 2010-12-20 09:16:14

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
    public const int QuotedString = 17;
    public const int EOF = -1;
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:15:1: value : ( boolean | integer | float_expr | string_expr | map | list );
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:16:2: ( boolean | integer | float_expr | string_expr | map | list )
            int alt1 = 6;
            switch ( input.LA(1) ) 
            {
            case Bool:
            	{
                alt1 = 1;
                }
                break;
            case Integer:
            	{
                alt1 = 2;
                }
                break;
            case Float:
            	{
                alt1 = 3;
                }
                break;
            case QuotedString:
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
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:16:4: boolean
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_boolean_in_value67);
                    	boolean1 = boolean();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, boolean1.Tree);

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:17:4: integer
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_integer_in_value72);
                    	integer2 = integer();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, integer2.Tree);

                    }
                    break;
                case 3 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:18:4: float_expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_float_expr_in_value78);
                    	float_expr3 = float_expr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, float_expr3.Tree);

                    }
                    break;
                case 4 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:19:4: string_expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_string_expr_in_value83);
                    	string_expr4 = string_expr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, string_expr4.Tree);

                    }
                    break;
                case 5 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:20:4: map
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_map_in_value88);
                    	map5 = map();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, map5.Tree);

                    }
                    break;
                case 6 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:21:4: list
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_list_in_value93);
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:24:1: integer : Integer -> ^( INTEGER Integer ) ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:25:2: ( Integer -> ^( INTEGER Integer ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:25:4: Integer
            {
            	Integer7=(IToken)Match(input,Integer,FOLLOW_Integer_in_integer104);  
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
            	// 25:12: -> ^( INTEGER Integer )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:25:15: ^( INTEGER Integer )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:33:1: float_expr : Float -> ^( FLOAT Float ) ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:34:2: ( Float -> ^( FLOAT Float ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:34:4: Float
            {
            	Float8=(IToken)Match(input,Float,FOLLOW_Float_in_float_expr152);  
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
            	// 34:10: -> ^( FLOAT Float )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:34:13: ^( FLOAT Float )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:45:1: string_expr : QuotedString -> ^( QUOTED_STRING QuotedString ) ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:46:2: ( QuotedString -> ^( QUOTED_STRING QuotedString ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:46:4: QuotedString
            {
            	QuotedString9=(IToken)Match(input,QuotedString,FOLLOW_QuotedString_in_string_expr228);  
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
            	// 46:17: -> ^( QUOTED_STRING QuotedString )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:46:20: ^( QUOTED_STRING QuotedString )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:58:1: boolean : Bool -> ^( BOOL Bool ) ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:59:2: ( Bool -> ^( BOOL Bool ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:59:4: Bool
            {
            	Bool10=(IToken)Match(input,Bool,FOLLOW_Bool_in_boolean271);  
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
            	// 59:9: -> ^( BOOL Bool )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:59:12: ^( BOOL Bool )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:66:1: map : '{' map_pair ( ',' map_pair )* '}' -> '{' ( map_pair )+ '}' ;
    public YamlParser.map_return map() // throws RecognitionException [1]
    {   
        YamlParser.map_return retval = new YamlParser.map_return();
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
        RewriteRuleTokenStream stream_22 = new RewriteRuleTokenStream(adaptor,"token 22");
        RewriteRuleTokenStream stream_23 = new RewriteRuleTokenStream(adaptor,"token 23");
        RewriteRuleTokenStream stream_24 = new RewriteRuleTokenStream(adaptor,"token 24");
        RewriteRuleSubtreeStream stream_map_pair = new RewriteRuleSubtreeStream(adaptor,"rule map_pair");
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:67:2: ( '{' map_pair ( ',' map_pair )* '}' -> '{' ( map_pair )+ '}' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:67:4: '{' map_pair ( ',' map_pair )* '}'
            {
            	char_literal11=(IToken)Match(input,22,FOLLOW_22_in_map309);  
            	stream_22.Add(char_literal11);

            	PushFollow(FOLLOW_map_pair_in_map311);
            	map_pair12 = map_pair();
            	state.followingStackPointer--;

            	stream_map_pair.Add(map_pair12.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:67:17: ( ',' map_pair )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == 23) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:67:18: ',' map_pair
            			    {
            			    	char_literal13=(IToken)Match(input,23,FOLLOW_23_in_map314);  
            			    	stream_23.Add(char_literal13);

            			    	PushFollow(FOLLOW_map_pair_in_map316);
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

            	char_literal15=(IToken)Match(input,24,FOLLOW_24_in_map320);  
            	stream_24.Add(char_literal15);



            	// AST REWRITE
            	// elements:          24, map_pair, 22
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 68:3: -> '{' ( map_pair )+ '}'
            	{
            	    adaptor.AddChild(root_0, stream_22.NextNode());
            	    if ( !(stream_map_pair.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_map_pair.HasNext() )
            	    {
            	        adaptor.AddChild(root_0, stream_map_pair.NextTree());

            	    }
            	    stream_map_pair.Reset();
            	    adaptor.AddChild(root_0, stream_24.NextNode());

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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:71:1: map_pair : string_expr ':' value -> ^( ':' string_expr value ) ;
    public YamlParser.map_pair_return map_pair() // throws RecognitionException [1]
    {   
        YamlParser.map_pair_return retval = new YamlParser.map_pair_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal17 = null;
        YamlParser.string_expr_return string_expr16 = default(YamlParser.string_expr_return);

        YamlParser.value_return value18 = default(YamlParser.value_return);


        object char_literal17_tree=null;
        RewriteRuleTokenStream stream_25 = new RewriteRuleTokenStream(adaptor,"token 25");
        RewriteRuleSubtreeStream stream_value = new RewriteRuleSubtreeStream(adaptor,"rule value");
        RewriteRuleSubtreeStream stream_string_expr = new RewriteRuleSubtreeStream(adaptor,"rule string_expr");
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:72:2: ( string_expr ':' value -> ^( ':' string_expr value ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:72:4: string_expr ':' value
            {
            	PushFollow(FOLLOW_string_expr_in_map_pair343);
            	string_expr16 = string_expr();
            	state.followingStackPointer--;

            	stream_string_expr.Add(string_expr16.Tree);
            	char_literal17=(IToken)Match(input,25,FOLLOW_25_in_map_pair345);  
            	stream_25.Add(char_literal17);

            	PushFollow(FOLLOW_value_in_map_pair347);
            	value18 = value();
            	state.followingStackPointer--;

            	stream_value.Add(value18.Tree);


            	// AST REWRITE
            	// elements:          25, string_expr, value
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 73:3: -> ^( ':' string_expr value )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:73:6: ^( ':' string_expr value )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_25.NextNode(), root_1);

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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:76:1: list : '[' value ( ',' value )* ']' -> '[' ( value )+ ']' ;
    public YamlParser.list_return list() // throws RecognitionException [1]
    {   
        YamlParser.list_return retval = new YamlParser.list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal19 = null;
        IToken char_literal21 = null;
        IToken char_literal23 = null;
        YamlParser.value_return value20 = default(YamlParser.value_return);

        YamlParser.value_return value22 = default(YamlParser.value_return);


        object char_literal19_tree=null;
        object char_literal21_tree=null;
        object char_literal23_tree=null;
        RewriteRuleTokenStream stream_23 = new RewriteRuleTokenStream(adaptor,"token 23");
        RewriteRuleTokenStream stream_26 = new RewriteRuleTokenStream(adaptor,"token 26");
        RewriteRuleTokenStream stream_27 = new RewriteRuleTokenStream(adaptor,"token 27");
        RewriteRuleSubtreeStream stream_value = new RewriteRuleSubtreeStream(adaptor,"rule value");
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:77:2: ( '[' value ( ',' value )* ']' -> '[' ( value )+ ']' )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:77:4: '[' value ( ',' value )* ']'
            {
            	char_literal19=(IToken)Match(input,26,FOLLOW_26_in_list372);  
            	stream_26.Add(char_literal19);

            	PushFollow(FOLLOW_value_in_list374);
            	value20 = value();
            	state.followingStackPointer--;

            	stream_value.Add(value20.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:77:14: ( ',' value )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == 23) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:77:15: ',' value
            			    {
            			    	char_literal21=(IToken)Match(input,23,FOLLOW_23_in_list377);  
            			    	stream_23.Add(char_literal21);

            			    	PushFollow(FOLLOW_value_in_list379);
            			    	value22 = value();
            			    	state.followingStackPointer--;

            			    	stream_value.Add(value22.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	char_literal23=(IToken)Match(input,27,FOLLOW_27_in_list383);  
            	stream_27.Add(char_literal23);



            	// AST REWRITE
            	// elements:          26, value, 27
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 78:3: -> '[' ( value )+ ']'
            	{
            	    adaptor.AddChild(root_0, stream_26.NextNode());
            	    if ( !(stream_value.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_value.HasNext() )
            	    {
            	        adaptor.AddChild(root_0, stream_value.NextTree());

            	    }
            	    stream_value.Reset();
            	    adaptor.AddChild(root_0, stream_27.NextNode());

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
    // $ANTLR end "list"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_boolean_in_value67 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_integer_in_value72 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_float_expr_in_value78 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string_expr_in_value83 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_map_in_value88 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_list_in_value93 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Integer_in_integer104 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Float_in_float_expr152 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QuotedString_in_string_expr228 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Bool_in_boolean271 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_22_in_map309 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_map_pair_in_map311 = new BitSet(new ulong[]{0x0000000001800000UL});
    public static readonly BitSet FOLLOW_23_in_map314 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_map_pair_in_map316 = new BitSet(new ulong[]{0x0000000001800000UL});
    public static readonly BitSet FOLLOW_24_in_map320 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string_expr_in_map_pair343 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_map_pair345 = new BitSet(new ulong[]{0x00000000044A9000UL});
    public static readonly BitSet FOLLOW_value_in_map_pair347 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_26_in_list372 = new BitSet(new ulong[]{0x00000000044A9000UL});
    public static readonly BitSet FOLLOW_value_in_list374 = new BitSet(new ulong[]{0x0000000008800000UL});
    public static readonly BitSet FOLLOW_23_in_list377 = new BitSet(new ulong[]{0x00000000044A9000UL});
    public static readonly BitSet FOLLOW_value_in_list379 = new BitSet(new ulong[]{0x0000000008800000UL});
    public static readonly BitSet FOLLOW_27_in_list383 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}