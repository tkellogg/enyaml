// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g 2011-01-01 13:56:39

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
		"LI", 
		"MI", 
		"NULL", 
		"Bool", 
		"NEWLINE", 
		"WS", 
		"COMMA", 
		"QUOT", 
		"LBRACKET", 
		"RBRACKET", 
		"LBRACE", 
		"RBRACE", 
		"DecDigit", 
		"HexDigit", 
		"Integer", 
		"Exponent", 
		"Float", 
		"FreeChars", 
		"UnQuotedString", 
		"QuotedStringChar", 
		"EscapeSequence", 
		"UnicodeEscape"
    };

    public const int INTEGER = 6;
    public const int Bool = 20;
    public const int RBRACE = 28;
    public const int FreeChars = 34;
    public const int DOUBLE_QUOTE = 9;
    public const int NULL = 19;
    public const int LBRACE = 27;
    public const int QUOT = 24;
    public const int BOOL = 8;
    public const int QuotedStringChar = 36;
    public const int Exponent = 32;
    public const int UnQuotedString = 35;
    public const int FLOAT = 7;
    public const int DEDENT = 14;
    public const int MI = 18;
    public const int EOF = -1;
    public const int LIST = 12;
    public const int HexDigit = 30;
    public const int DecDigit = 29;
    public const int INDENT = 13;
    public const int Float = 33;
    public const int LBRACKET = 25;
    public const int SINGLE_QUOTE = 10;
    public const int WS = 22;
    public const int NEWLINE = 21;
    public const int COMMA = 23;
    public const int DENT = 15;
    public const int UnicodeEscape = 38;
    public const int MAP = 11;
    public const int QUOTED_STRING = 4;
    public const int RBRACKET = 26;
    public const int UNQUOTED_STRING = 5;
    public const int LI = 17;
    public const int EscapeSequence = 37;
    public const int Integer = 31;
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:74:1: value : ( null_expr | boolean | integer | float_expr | string_expr | map | list );
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:75:2: ( null_expr | boolean | integer | float_expr | string_expr | map | list )
            int alt1 = 7;
            alt1 = dfa1.Predict(input);
            switch (alt1) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:75:4: null_expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_null_expr_in_value381);
                    	null_expr1 = null_expr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, null_expr1.Tree);

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:76:4: boolean
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_boolean_in_value386);
                    	boolean2 = boolean();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, boolean2.Tree);

                    }
                    break;
                case 3 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:77:4: integer
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_integer_in_value391);
                    	integer3 = integer();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, integer3.Tree);

                    }
                    break;
                case 4 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:78:4: float_expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_float_expr_in_value397);
                    	float_expr4 = float_expr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, float_expr4.Tree);

                    }
                    break;
                case 5 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:79:4: string_expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_string_expr_in_value402);
                    	string_expr5 = string_expr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, string_expr5.Tree);

                    }
                    break;
                case 6 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:80:4: map
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_map_in_value407);
                    	map6 = map();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, map6.Tree);

                    }
                    break;
                case 7 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:81:4: list
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_list_in_value412);
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:84:1: boolean : Bool -> ^( BOOL Bool ) ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:85:2: ( Bool -> ^( BOOL Bool ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:85:4: Bool
            {
            	Bool8=(IToken)Match(input,Bool,FOLLOW_Bool_in_boolean425);  
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:88:1: null_expr : NULL ;
    public YamlParser.null_expr_return null_expr() // throws RecognitionException [1]
    {   
        YamlParser.null_expr_return retval = new YamlParser.null_expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NULL9 = null;

        object NULL9_tree=null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:89:2: ( NULL )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:89:4: NULL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	NULL9=(IToken)Match(input,NULL,FOLLOW_NULL_in_null_expr445); 
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:92:1: integer : Integer -> ^( INTEGER Integer ) ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:93:2: ( Integer -> ^( INTEGER Integer ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:93:4: Integer
            {
            	Integer10=(IToken)Match(input,Integer,FOLLOW_Integer_in_integer456);  
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
            	// 93:12: -> ^( INTEGER Integer )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:93:15: ^( INTEGER Integer )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:97:1: float_expr : Float -> ^( FLOAT Float ) ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:98:2: ( Float -> ^( FLOAT Float ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:98:4: Float
            {
            	Float11=(IToken)Match(input,Float,FOLLOW_Float_in_float_expr478);  
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
            	// 98:10: -> ^( FLOAT Float )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:98:13: ^( FLOAT Float )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:101:1: string_expr : ( QUOT ( QuotedStringChar )* QUOT -> ^( QUOTED_STRING ( QuotedStringChar )* ) | QUOT UnQuotedString QUOT -> ^( QUOTED_STRING UnQuotedString ) | QUOT Integer QUOT -> ^( QUOTED_STRING Integer ) | UnQuotedString -> ^( UNQUOTED_STRING UnQuotedString ) );
    public YamlParser.string_expr_return string_expr() // throws RecognitionException [1]
    {   
        YamlParser.string_expr_return retval = new YamlParser.string_expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken QUOT12 = null;
        IToken QuotedStringChar13 = null;
        IToken QUOT14 = null;
        IToken QUOT15 = null;
        IToken UnQuotedString16 = null;
        IToken QUOT17 = null;
        IToken QUOT18 = null;
        IToken Integer19 = null;
        IToken QUOT20 = null;
        IToken UnQuotedString21 = null;

        object QUOT12_tree=null;
        object QuotedStringChar13_tree=null;
        object QUOT14_tree=null;
        object QUOT15_tree=null;
        object UnQuotedString16_tree=null;
        object QUOT17_tree=null;
        object QUOT18_tree=null;
        object Integer19_tree=null;
        object QUOT20_tree=null;
        object UnQuotedString21_tree=null;
        RewriteRuleTokenStream stream_QuotedStringChar = new RewriteRuleTokenStream(adaptor,"token QuotedStringChar");
        RewriteRuleTokenStream stream_UnQuotedString = new RewriteRuleTokenStream(adaptor,"token UnQuotedString");
        RewriteRuleTokenStream stream_Integer = new RewriteRuleTokenStream(adaptor,"token Integer");
        RewriteRuleTokenStream stream_QUOT = new RewriteRuleTokenStream(adaptor,"token QUOT");

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:102:2: ( QUOT ( QuotedStringChar )* QUOT -> ^( QUOTED_STRING ( QuotedStringChar )* ) | QUOT UnQuotedString QUOT -> ^( QUOTED_STRING UnQuotedString ) | QUOT Integer QUOT -> ^( QUOTED_STRING Integer ) | UnQuotedString -> ^( UNQUOTED_STRING UnQuotedString ) )
            int alt3 = 4;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == QUOT) )
            {
                switch ( input.LA(2) ) 
                {
                case UnQuotedString:
                	{
                    alt3 = 2;
                    }
                    break;
                case Integer:
                	{
                    alt3 = 3;
                    }
                    break;
                case QUOT:
                case QuotedStringChar:
                	{
                    alt3 = 1;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d3s1 =
                	        new NoViableAltException("", 3, 1, input);

                	    throw nvae_d3s1;
                }

            }
            else if ( (LA3_0 == UnQuotedString) )
            {
                alt3 = 4;
            }
            else 
            {
                NoViableAltException nvae_d3s0 =
                    new NoViableAltException("", 3, 0, input);

                throw nvae_d3s0;
            }
            switch (alt3) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:102:4: QUOT ( QuotedStringChar )* QUOT
                    {
                    	QUOT12=(IToken)Match(input,QUOT,FOLLOW_QUOT_in_string_expr498);  
                    	stream_QUOT.Add(QUOT12);

                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:102:9: ( QuotedStringChar )*
                    	do 
                    	{
                    	    int alt2 = 2;
                    	    int LA2_0 = input.LA(1);

                    	    if ( (LA2_0 == QuotedStringChar) )
                    	    {
                    	        alt2 = 1;
                    	    }


                    	    switch (alt2) 
                    		{
                    			case 1 :
                    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:102:9: QuotedStringChar
                    			    {
                    			    	QuotedStringChar13=(IToken)Match(input,QuotedStringChar,FOLLOW_QuotedStringChar_in_string_expr500);  
                    			    	stream_QuotedStringChar.Add(QuotedStringChar13);


                    			    }
                    			    break;

                    			default:
                    			    goto loop2;
                    	    }
                    	} while (true);

                    	loop2:
                    		;	// Stops C# compiler whining that label 'loop2' has no statements

                    	QUOT14=(IToken)Match(input,QUOT,FOLLOW_QUOT_in_string_expr503);  
                    	stream_QUOT.Add(QUOT14);



                    	// AST REWRITE
                    	// elements:          QuotedStringChar
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 103:3: -> ^( QUOTED_STRING ( QuotedStringChar )* )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:103:6: ^( QUOTED_STRING ( QuotedStringChar )* )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(QUOTED_STRING, "QUOTED_STRING"), root_1);

                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:103:22: ( QuotedStringChar )*
                    	    while ( stream_QuotedStringChar.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_QuotedStringChar.NextNode());

                    	    }
                    	    stream_QuotedStringChar.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:104:4: QUOT UnQuotedString QUOT
                    {
                    	QUOT15=(IToken)Match(input,QUOT,FOLLOW_QUOT_in_string_expr520);  
                    	stream_QUOT.Add(QUOT15);

                    	UnQuotedString16=(IToken)Match(input,UnQuotedString,FOLLOW_UnQuotedString_in_string_expr522);  
                    	stream_UnQuotedString.Add(UnQuotedString16);

                    	QUOT17=(IToken)Match(input,QUOT,FOLLOW_QUOT_in_string_expr524);  
                    	stream_QUOT.Add(QUOT17);



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
                    	// 105:3: -> ^( QUOTED_STRING UnQuotedString )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:105:6: ^( QUOTED_STRING UnQuotedString )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(QUOTED_STRING, "QUOTED_STRING"), root_1);

                    	    adaptor.AddChild(root_1, stream_UnQuotedString.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 3 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:106:4: QUOT Integer QUOT
                    {
                    	QUOT18=(IToken)Match(input,QUOT,FOLLOW_QUOT_in_string_expr540);  
                    	stream_QUOT.Add(QUOT18);

                    	Integer19=(IToken)Match(input,Integer,FOLLOW_Integer_in_string_expr542);  
                    	stream_Integer.Add(Integer19);

                    	QUOT20=(IToken)Match(input,QUOT,FOLLOW_QUOT_in_string_expr544);  
                    	stream_QUOT.Add(QUOT20);



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
                    	// 107:3: -> ^( QUOTED_STRING Integer )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:107:6: ^( QUOTED_STRING Integer )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(QUOTED_STRING, "QUOTED_STRING"), root_1);

                    	    adaptor.AddChild(root_1, stream_Integer.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 4 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:108:4: UnQuotedString
                    {
                    	UnQuotedString21=(IToken)Match(input,UnQuotedString,FOLLOW_UnQuotedString_in_string_expr560);  
                    	stream_UnQuotedString.Add(UnQuotedString21);



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
                    	// 108:19: -> ^( UNQUOTED_STRING UnQuotedString )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:108:22: ^( UNQUOTED_STRING UnQuotedString )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:111:1: flow_map : LBRACE ( fskip )* map_pair ( fskip )* ( COMMA ( fskip )* map_pair ( fskip )* )* RBRACE -> ^( MAP ( map_pair )+ ) ;
    public YamlParser.flow_map_return flow_map() // throws RecognitionException [1]
    {   
        YamlParser.flow_map_return retval = new YamlParser.flow_map_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LBRACE22 = null;
        IToken COMMA26 = null;
        IToken RBRACE30 = null;
        YamlParser.fskip_return fskip23 = default(YamlParser.fskip_return);

        YamlParser.map_pair_return map_pair24 = default(YamlParser.map_pair_return);

        YamlParser.fskip_return fskip25 = default(YamlParser.fskip_return);

        YamlParser.fskip_return fskip27 = default(YamlParser.fskip_return);

        YamlParser.map_pair_return map_pair28 = default(YamlParser.map_pair_return);

        YamlParser.fskip_return fskip29 = default(YamlParser.fskip_return);


        object LBRACE22_tree=null;
        object COMMA26_tree=null;
        object RBRACE30_tree=null;
        RewriteRuleTokenStream stream_RBRACE = new RewriteRuleTokenStream(adaptor,"token RBRACE");
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleTokenStream stream_LBRACE = new RewriteRuleTokenStream(adaptor,"token LBRACE");
        RewriteRuleSubtreeStream stream_map_pair = new RewriteRuleSubtreeStream(adaptor,"rule map_pair");
        RewriteRuleSubtreeStream stream_fskip = new RewriteRuleSubtreeStream(adaptor,"rule fskip");

        	flowLvl++;
        	BlockLevel++;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:116:2: ( LBRACE ( fskip )* map_pair ( fskip )* ( COMMA ( fskip )* map_pair ( fskip )* )* RBRACE -> ^( MAP ( map_pair )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:116:4: LBRACE ( fskip )* map_pair ( fskip )* ( COMMA ( fskip )* map_pair ( fskip )* )* RBRACE
            {
            	LBRACE22=(IToken)Match(input,LBRACE,FOLLOW_LBRACE_in_flow_map588);  
            	stream_LBRACE.Add(LBRACE22);

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:116:11: ( fskip )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= INDENT && LA4_0 <= DEDENT) || LA4_0 == INDENTATION || (LA4_0 >= NEWLINE && LA4_0 <= WS)) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:116:11: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_flow_map590);
            			    	fskip23 = fskip();
            			    	state.followingStackPointer--;

            			    	stream_fskip.Add(fskip23.Tree);

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	PushFollow(FOLLOW_map_pair_in_flow_map593);
            	map_pair24 = map_pair();
            	state.followingStackPointer--;

            	stream_map_pair.Add(map_pair24.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:116:27: ( fskip )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= INDENT && LA5_0 <= DEDENT) || LA5_0 == INDENTATION || (LA5_0 >= NEWLINE && LA5_0 <= WS)) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:116:27: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_flow_map595);
            			    	fskip25 = fskip();
            			    	state.followingStackPointer--;

            			    	stream_fskip.Add(fskip25.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:116:34: ( COMMA ( fskip )* map_pair ( fskip )* )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == COMMA) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:116:35: COMMA ( fskip )* map_pair ( fskip )*
            			    {
            			    	COMMA26=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_flow_map599);  
            			    	stream_COMMA.Add(COMMA26);

            			    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:116:41: ( fskip )*
            			    	do 
            			    	{
            			    	    int alt6 = 2;
            			    	    int LA6_0 = input.LA(1);

            			    	    if ( ((LA6_0 >= INDENT && LA6_0 <= DEDENT) || LA6_0 == INDENTATION || (LA6_0 >= NEWLINE && LA6_0 <= WS)) )
            			    	    {
            			    	        alt6 = 1;
            			    	    }


            			    	    switch (alt6) 
            			    		{
            			    			case 1 :
            			    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:116:41: fskip
            			    			    {
            			    			    	PushFollow(FOLLOW_fskip_in_flow_map601);
            			    			    	fskip27 = fskip();
            			    			    	state.followingStackPointer--;

            			    			    	stream_fskip.Add(fskip27.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop6;
            			    	    }
            			    	} while (true);

            			    	loop6:
            			    		;	// Stops C# compiler whining that label 'loop6' has no statements

            			    	PushFollow(FOLLOW_map_pair_in_flow_map604);
            			    	map_pair28 = map_pair();
            			    	state.followingStackPointer--;

            			    	stream_map_pair.Add(map_pair28.Tree);
            			    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:116:57: ( fskip )*
            			    	do 
            			    	{
            			    	    int alt7 = 2;
            			    	    int LA7_0 = input.LA(1);

            			    	    if ( ((LA7_0 >= INDENT && LA7_0 <= DEDENT) || LA7_0 == INDENTATION || (LA7_0 >= NEWLINE && LA7_0 <= WS)) )
            			    	    {
            			    	        alt7 = 1;
            			    	    }


            			    	    switch (alt7) 
            			    		{
            			    			case 1 :
            			    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:116:57: fskip
            			    			    {
            			    			    	PushFollow(FOLLOW_fskip_in_flow_map606);
            			    			    	fskip29 = fskip();
            			    			    	state.followingStackPointer--;

            			    			    	stream_fskip.Add(fskip29.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop7;
            			    	    }
            			    	} while (true);

            			    	loop7:
            			    		;	// Stops C# compiler whining that label 'loop7' has no statements


            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	RBRACE30=(IToken)Match(input,RBRACE,FOLLOW_RBRACE_in_flow_map612);  
            	stream_RBRACE.Add(RBRACE30);



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
            	// 117:3: -> ^( MAP ( map_pair )+ )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:117:6: ^( MAP ( map_pair )+ )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:124:1: block_map : INDENT DENT map_pair ( NEWLINE DENT map_pair )* DEDENT -> ^( MAP ( map_pair )+ ) ;
    public YamlParser.block_map_return block_map() // throws RecognitionException [1]
    {   
        YamlParser.block_map_return retval = new YamlParser.block_map_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INDENT31 = null;
        IToken DENT32 = null;
        IToken NEWLINE34 = null;
        IToken DENT35 = null;
        IToken DEDENT37 = null;
        YamlParser.map_pair_return map_pair33 = default(YamlParser.map_pair_return);

        YamlParser.map_pair_return map_pair36 = default(YamlParser.map_pair_return);


        object INDENT31_tree=null;
        object DENT32_tree=null;
        object NEWLINE34_tree=null;
        object DENT35_tree=null;
        object DEDENT37_tree=null;
        RewriteRuleTokenStream stream_DEDENT = new RewriteRuleTokenStream(adaptor,"token DEDENT");
        RewriteRuleTokenStream stream_NEWLINE = new RewriteRuleTokenStream(adaptor,"token NEWLINE");
        RewriteRuleTokenStream stream_DENT = new RewriteRuleTokenStream(adaptor,"token DENT");
        RewriteRuleTokenStream stream_INDENT = new RewriteRuleTokenStream(adaptor,"token INDENT");
        RewriteRuleSubtreeStream stream_map_pair = new RewriteRuleSubtreeStream(adaptor,"rule map_pair");

        	BlockLevel++;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:128:2: ( INDENT DENT map_pair ( NEWLINE DENT map_pair )* DEDENT -> ^( MAP ( map_pair )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:128:4: INDENT DENT map_pair ( NEWLINE DENT map_pair )* DEDENT
            {
            	INDENT31=(IToken)Match(input,INDENT,FOLLOW_INDENT_in_block_map644);  
            	stream_INDENT.Add(INDENT31);

            	DENT32=(IToken)Match(input,DENT,FOLLOW_DENT_in_block_map646);  
            	stream_DENT.Add(DENT32);

            	PushFollow(FOLLOW_map_pair_in_block_map648);
            	map_pair33 = map_pair();
            	state.followingStackPointer--;

            	stream_map_pair.Add(map_pair33.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:128:25: ( NEWLINE DENT map_pair )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == NEWLINE) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:128:26: NEWLINE DENT map_pair
            			    {
            			    	NEWLINE34=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_block_map651);  
            			    	stream_NEWLINE.Add(NEWLINE34);

            			    	DENT35=(IToken)Match(input,DENT,FOLLOW_DENT_in_block_map653);  
            			    	stream_DENT.Add(DENT35);

            			    	PushFollow(FOLLOW_map_pair_in_block_map655);
            			    	map_pair36 = map_pair();
            			    	state.followingStackPointer--;

            			    	stream_map_pair.Add(map_pair36.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	DEDENT37=(IToken)Match(input,DEDENT,FOLLOW_DEDENT_in_block_map659);  
            	stream_DEDENT.Add(DEDENT37);



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
            	// 129:3: -> ^( MAP ( map_pair )+ )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:129:6: ^( MAP ( map_pair )+ )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:135:1: map : ({...}? => block_map | flow_map );
    public YamlParser.map_return map() // throws RecognitionException [1]
    {   
        YamlParser.map_return retval = new YamlParser.map_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        YamlParser.block_map_return block_map38 = default(YamlParser.block_map_return);

        YamlParser.flow_map_return flow_map39 = default(YamlParser.flow_map_return);



        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:136:2: ({...}? => block_map | flow_map )
            int alt10 = 2;
            int LA10_0 = input.LA(1);

            if ( (LA10_0 == INDENT) && ((!IsInFlow)) )
            {
                alt10 = 1;
            }
            else if ( (LA10_0 == LBRACE) )
            {
                alt10 = 2;
            }
            else 
            {
                NoViableAltException nvae_d10s0 =
                    new NoViableAltException("", 10, 0, input);

                throw nvae_d10s0;
            }
            switch (alt10) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:136:4: {...}? => block_map
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	if ( !((!IsInFlow)) ) 
                    	{
                    	    throw new FailedPredicateException(input, "map", "!IsInFlow");
                    	}
                    	PushFollow(FOLLOW_block_map_in_map690);
                    	block_map38 = block_map();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, block_map38.Tree);

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:137:4: flow_map
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_flow_map_in_map695);
                    	flow_map39 = flow_map();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, flow_map39.Tree);

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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:140:1: map_pair : string_expr ( fskip )* MI ( fskip )* value -> ^( MI string_expr value ) ;
    public YamlParser.map_pair_return map_pair() // throws RecognitionException [1]
    {   
        YamlParser.map_pair_return retval = new YamlParser.map_pair_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MI42 = null;
        YamlParser.string_expr_return string_expr40 = default(YamlParser.string_expr_return);

        YamlParser.fskip_return fskip41 = default(YamlParser.fskip_return);

        YamlParser.fskip_return fskip43 = default(YamlParser.fskip_return);

        YamlParser.value_return value44 = default(YamlParser.value_return);


        object MI42_tree=null;
        RewriteRuleTokenStream stream_MI = new RewriteRuleTokenStream(adaptor,"token MI");
        RewriteRuleSubtreeStream stream_value = new RewriteRuleSubtreeStream(adaptor,"rule value");
        RewriteRuleSubtreeStream stream_string_expr = new RewriteRuleSubtreeStream(adaptor,"rule string_expr");
        RewriteRuleSubtreeStream stream_fskip = new RewriteRuleSubtreeStream(adaptor,"rule fskip");
        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:2: ( string_expr ( fskip )* MI ( fskip )* value -> ^( MI string_expr value ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:4: string_expr ( fskip )* MI ( fskip )* value
            {
            	PushFollow(FOLLOW_string_expr_in_map_pair707);
            	string_expr40 = string_expr();
            	state.followingStackPointer--;

            	stream_string_expr.Add(string_expr40.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:16: ( fskip )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( ((LA11_0 >= INDENT && LA11_0 <= DEDENT) || LA11_0 == INDENTATION || (LA11_0 >= NEWLINE && LA11_0 <= WS)) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:16: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_map_pair709);
            			    	fskip41 = fskip();
            			    	state.followingStackPointer--;

            			    	stream_fskip.Add(fskip41.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	MI42=(IToken)Match(input,MI,FOLLOW_MI_in_map_pair712);  
            	stream_MI.Add(MI42);

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:26: ( fskip )*
            	do 
            	{
            	    int alt12 = 2;
            	    alt12 = dfa12.Predict(input);
            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:26: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_map_pair714);
            			    	fskip43 = fskip();
            			    	state.followingStackPointer--;

            			    	stream_fskip.Add(fskip43.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	PushFollow(FOLLOW_value_in_map_pair717);
            	value44 = value();
            	state.followingStackPointer--;

            	stream_value.Add(value44.Tree);


            	// AST REWRITE
            	// elements:          value, MI, string_expr
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 142:3: -> ^( MI string_expr value )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:142:6: ^( MI string_expr value )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_MI.NextNode(), root_1);

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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:145:1: list : ({...}? => block_list | flow_list );
    public YamlParser.list_return list() // throws RecognitionException [1]
    {   
        YamlParser.list_return retval = new YamlParser.list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        YamlParser.block_list_return block_list45 = default(YamlParser.block_list_return);

        YamlParser.flow_list_return flow_list46 = default(YamlParser.flow_list_return);



        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:146:2: ({...}? => block_list | flow_list )
            int alt13 = 2;
            int LA13_0 = input.LA(1);

            if ( ((LA13_0 >= INDENTATION && LA13_0 <= LI)) && ((!IsInFlow)) )
            {
                alt13 = 1;
            }
            else if ( (LA13_0 == LBRACKET) )
            {
                alt13 = 2;
            }
            else 
            {
                NoViableAltException nvae_d13s0 =
                    new NoViableAltException("", 13, 0, input);

                throw nvae_d13s0;
            }
            switch (alt13) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:146:4: {...}? => block_list
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	if ( !((!IsInFlow)) ) 
                    	{
                    	    throw new FailedPredicateException(input, "list", "!IsInFlow");
                    	}
                    	PushFollow(FOLLOW_block_list_in_list745);
                    	block_list45 = block_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, block_list45.Tree);

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:147:4: flow_list
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_flow_list_in_list750);
                    	flow_list46 = flow_list();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, flow_list46.Tree);

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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:151:1: fskip : ( NEWLINE | INDENTATION | INDENT | DEDENT | WS );
    public YamlParser.fskip_return fskip() // throws RecognitionException [1]
    {   
        YamlParser.fskip_return retval = new YamlParser.fskip_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set47 = null;

        object set47_tree=null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:152:2: ( NEWLINE | INDENTATION | INDENT | DEDENT | WS )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set47 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= INDENT && input.LA(1) <= DEDENT) || input.LA(1) == INDENTATION || (input.LA(1) >= NEWLINE && input.LA(1) <= WS) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set47));
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:155:1: flow_list : LBRACKET ( fskip )* value ( fskip )* ( COMMA ( fskip )* value ( fskip )* )* RBRACKET -> ^( LIST ( value )+ ) ;
    public YamlParser.flow_list_return flow_list() // throws RecognitionException [1]
    {   
        YamlParser.flow_list_return retval = new YamlParser.flow_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LBRACKET48 = null;
        IToken COMMA52 = null;
        IToken RBRACKET56 = null;
        YamlParser.fskip_return fskip49 = default(YamlParser.fskip_return);

        YamlParser.value_return value50 = default(YamlParser.value_return);

        YamlParser.fskip_return fskip51 = default(YamlParser.fskip_return);

        YamlParser.fskip_return fskip53 = default(YamlParser.fskip_return);

        YamlParser.value_return value54 = default(YamlParser.value_return);

        YamlParser.fskip_return fskip55 = default(YamlParser.fskip_return);


        object LBRACKET48_tree=null;
        object COMMA52_tree=null;
        object RBRACKET56_tree=null;
        RewriteRuleTokenStream stream_LBRACKET = new RewriteRuleTokenStream(adaptor,"token LBRACKET");
        RewriteRuleTokenStream stream_RBRACKET = new RewriteRuleTokenStream(adaptor,"token RBRACKET");
        RewriteRuleTokenStream stream_COMMA = new RewriteRuleTokenStream(adaptor,"token COMMA");
        RewriteRuleSubtreeStream stream_value = new RewriteRuleSubtreeStream(adaptor,"rule value");
        RewriteRuleSubtreeStream stream_fskip = new RewriteRuleSubtreeStream(adaptor,"rule fskip");

        	flowLvl++;
        	BlockLevel++;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:160:2: ( LBRACKET ( fskip )* value ( fskip )* ( COMMA ( fskip )* value ( fskip )* )* RBRACKET -> ^( LIST ( value )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:160:4: LBRACKET ( fskip )* value ( fskip )* ( COMMA ( fskip )* value ( fskip )* )* RBRACKET
            {
            	LBRACKET48=(IToken)Match(input,LBRACKET,FOLLOW_LBRACKET_in_flow_list797);  
            	stream_LBRACKET.Add(LBRACKET48);

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:160:13: ( fskip )*
            	do 
            	{
            	    int alt14 = 2;
            	    alt14 = dfa14.Predict(input);
            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:160:13: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_flow_list799);
            			    	fskip49 = fskip();
            			    	state.followingStackPointer--;

            			    	stream_fskip.Add(fskip49.Tree);

            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

            	PushFollow(FOLLOW_value_in_flow_list802);
            	value50 = value();
            	state.followingStackPointer--;

            	stream_value.Add(value50.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:160:26: ( fskip )*
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( ((LA15_0 >= INDENT && LA15_0 <= DEDENT) || LA15_0 == INDENTATION || (LA15_0 >= NEWLINE && LA15_0 <= WS)) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:160:26: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_flow_list804);
            			    	fskip51 = fskip();
            			    	state.followingStackPointer--;

            			    	stream_fskip.Add(fskip51.Tree);

            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:160:33: ( COMMA ( fskip )* value ( fskip )* )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( (LA18_0 == COMMA) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:160:34: COMMA ( fskip )* value ( fskip )*
            			    {
            			    	COMMA52=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_flow_list808);  
            			    	stream_COMMA.Add(COMMA52);

            			    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:160:40: ( fskip )*
            			    	do 
            			    	{
            			    	    int alt16 = 2;
            			    	    alt16 = dfa16.Predict(input);
            			    	    switch (alt16) 
            			    		{
            			    			case 1 :
            			    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:160:40: fskip
            			    			    {
            			    			    	PushFollow(FOLLOW_fskip_in_flow_list810);
            			    			    	fskip53 = fskip();
            			    			    	state.followingStackPointer--;

            			    			    	stream_fskip.Add(fskip53.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop16;
            			    	    }
            			    	} while (true);

            			    	loop16:
            			    		;	// Stops C# compiler whining that label 'loop16' has no statements

            			    	PushFollow(FOLLOW_value_in_flow_list813);
            			    	value54 = value();
            			    	state.followingStackPointer--;

            			    	stream_value.Add(value54.Tree);
            			    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:160:53: ( fskip )*
            			    	do 
            			    	{
            			    	    int alt17 = 2;
            			    	    int LA17_0 = input.LA(1);

            			    	    if ( ((LA17_0 >= INDENT && LA17_0 <= DEDENT) || LA17_0 == INDENTATION || (LA17_0 >= NEWLINE && LA17_0 <= WS)) )
            			    	    {
            			    	        alt17 = 1;
            			    	    }


            			    	    switch (alt17) 
            			    		{
            			    			case 1 :
            			    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:160:53: fskip
            			    			    {
            			    			    	PushFollow(FOLLOW_fskip_in_flow_list815);
            			    			    	fskip55 = fskip();
            			    			    	state.followingStackPointer--;

            			    			    	stream_fskip.Add(fskip55.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop17;
            			    	    }
            			    	} while (true);

            			    	loop17:
            			    		;	// Stops C# compiler whining that label 'loop17' has no statements


            			    }
            			    break;

            			default:
            			    goto loop18;
            	    }
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements

            	RBRACKET56=(IToken)Match(input,RBRACKET,FOLLOW_RBRACKET_in_flow_list820);  
            	stream_RBRACKET.Add(RBRACKET56);



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
            	// 161:3: -> ^( LIST ( value )+ )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:161:6: ^( LIST ( value )+ )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:168:1: block_list : ( INDENTATION INDENT ( block_list_item )+ INDENTATION DEDENT -> ^( LIST ( block_list_item )+ ) | {...}? ( block_list_item )+ -> ^( LIST ( block_list_item )+ ) );
    public YamlParser.block_list_return block_list() // throws RecognitionException [1]
    {   
        YamlParser.block_list_return retval = new YamlParser.block_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INDENTATION57 = null;
        IToken INDENT58 = null;
        IToken INDENTATION60 = null;
        IToken DEDENT61 = null;
        YamlParser.block_list_item_return block_list_item59 = default(YamlParser.block_list_item_return);

        YamlParser.block_list_item_return block_list_item62 = default(YamlParser.block_list_item_return);


        object INDENTATION57_tree=null;
        object INDENT58_tree=null;
        object INDENTATION60_tree=null;
        object DEDENT61_tree=null;
        RewriteRuleTokenStream stream_DEDENT = new RewriteRuleTokenStream(adaptor,"token DEDENT");
        RewriteRuleTokenStream stream_INDENT = new RewriteRuleTokenStream(adaptor,"token INDENT");
        RewriteRuleTokenStream stream_INDENTATION = new RewriteRuleTokenStream(adaptor,"token INDENTATION");
        RewriteRuleSubtreeStream stream_block_list_item = new RewriteRuleSubtreeStream(adaptor,"rule block_list_item");

        	BlockLevel++;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:172:2: ( INDENTATION INDENT ( block_list_item )+ INDENTATION DEDENT -> ^( LIST ( block_list_item )+ ) | {...}? ( block_list_item )+ -> ^( LIST ( block_list_item )+ ) )
            int alt21 = 2;
            int LA21_0 = input.LA(1);

            if ( (LA21_0 == INDENTATION) )
            {
                alt21 = 1;
            }
            else if ( (LA21_0 == LI) )
            {
                alt21 = 2;
            }
            else 
            {
                NoViableAltException nvae_d21s0 =
                    new NoViableAltException("", 21, 0, input);

                throw nvae_d21s0;
            }
            switch (alt21) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:172:4: INDENTATION INDENT ( block_list_item )+ INDENTATION DEDENT
                    {
                    	INDENTATION57=(IToken)Match(input,INDENTATION,FOLLOW_INDENTATION_in_block_list853);  
                    	stream_INDENTATION.Add(INDENTATION57);

                    	INDENT58=(IToken)Match(input,INDENT,FOLLOW_INDENT_in_block_list855);  
                    	stream_INDENT.Add(INDENT58);

                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:172:23: ( block_list_item )+
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
                    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:172:23: block_list_item
                    			    {
                    			    	PushFollow(FOLLOW_block_list_item_in_block_list857);
                    			    	block_list_item59 = block_list_item();
                    			    	state.followingStackPointer--;

                    			    	stream_block_list_item.Add(block_list_item59.Tree);

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

                    	INDENTATION60=(IToken)Match(input,INDENTATION,FOLLOW_INDENTATION_in_block_list860);  
                    	stream_INDENTATION.Add(INDENTATION60);

                    	DEDENT61=(IToken)Match(input,DEDENT,FOLLOW_DEDENT_in_block_list862);  
                    	stream_DEDENT.Add(DEDENT61);



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
                    	// 173:3: -> ^( LIST ( block_list_item )+ )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:173:6: ^( LIST ( block_list_item )+ )
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
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:174:4: {...}? ( block_list_item )+
                    {
                    	if ( !((flowLvl == 0)) ) 
                    	{
                    	    throw new FailedPredicateException(input, "block_list", "flowLvl == 0");
                    	}
                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:174:20: ( block_list_item )+
                    	int cnt20 = 0;
                    	do 
                    	{
                    	    int alt20 = 2;
                    	    int LA20_0 = input.LA(1);

                    	    if ( (LA20_0 == LI) )
                    	    {
                    	        alt20 = 1;
                    	    }


                    	    switch (alt20) 
                    		{
                    			case 1 :
                    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:174:20: block_list_item
                    			    {
                    			    	PushFollow(FOLLOW_block_list_item_in_block_list880);
                    			    	block_list_item62 = block_list_item();
                    			    	state.followingStackPointer--;

                    			    	stream_block_list_item.Add(block_list_item62.Tree);

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt20 >= 1 ) goto loop20;
                    		            EarlyExitException eee20 =
                    		                new EarlyExitException(20, input);
                    		            throw eee20;
                    	    }
                    	    cnt20++;
                    	} while (true);

                    	loop20:
                    		;	// Stops C# compiler whining that label 'loop20' has no statements



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
                    	// 175:3: -> ^( LIST ( block_list_item )+ )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:175:6: ^( LIST ( block_list_item )+ )
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:181:1: block_list_item : {...}? LI ( WS )* value NEWLINE -> value ;
    public YamlParser.block_list_item_return block_list_item() // throws RecognitionException [1]
    {   
        block_list_item_stack.Push(new block_list_item_scope());
        YamlParser.block_list_item_return retval = new YamlParser.block_list_item_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LI63 = null;
        IToken WS64 = null;
        IToken NEWLINE66 = null;
        YamlParser.value_return value65 = default(YamlParser.value_return);


        object LI63_tree=null;
        object WS64_tree=null;
        object NEWLINE66_tree=null;
        RewriteRuleTokenStream stream_WS = new RewriteRuleTokenStream(adaptor,"token WS");
        RewriteRuleTokenStream stream_NEWLINE = new RewriteRuleTokenStream(adaptor,"token NEWLINE");
        RewriteRuleTokenStream stream_LI = new RewriteRuleTokenStream(adaptor,"token LI");
        RewriteRuleSubtreeStream stream_value = new RewriteRuleSubtreeStream(adaptor,"rule value");

        	((block_list_item_scope)block_list_item_stack.Peek()).lvl =  BlockLevel;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:188:2: ({...}? LI ( WS )* value NEWLINE -> value )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:188:4: {...}? LI ( WS )* value NEWLINE
            {
            	if ( !((((block_list_item_scope)block_list_item_stack.Peek()).lvl == BlockLevel)) ) 
            	{
            	    throw new FailedPredicateException(input, "block_list_item", "$block_list_item::lvl == BlockLevel");
            	}
            	LI63=(IToken)Match(input,LI,FOLLOW_LI_in_block_list_item919);  
            	stream_LI.Add(LI63);

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:188:46: ( WS )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == WS) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:188:46: WS
            			    {
            			    	WS64=(IToken)Match(input,WS,FOLLOW_WS_in_block_list_item921);  
            			    	stream_WS.Add(WS64);


            			    }
            			    break;

            			default:
            			    goto loop22;
            	    }
            	} while (true);

            	loop22:
            		;	// Stops C# compiler whining that label 'loop22' has no statements

            	PushFollow(FOLLOW_value_in_block_list_item924);
            	value65 = value();
            	state.followingStackPointer--;

            	stream_value.Add(value65.Tree);
            	NEWLINE66=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_block_list_item926);  
            	stream_NEWLINE.Add(NEWLINE66);



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
            	// 189:3: -> value
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
   	protected DFA12 dfa12;
   	protected DFA14 dfa14;
   	protected DFA16 dfa16;
	private void InitializeCyclicDFAs()
	{
    	this.dfa1 = new DFA1(this);
    	this.dfa12 = new DFA12(this);
    	this.dfa14 = new DFA14(this);
    	this.dfa16 = new DFA16(this);
	    this.dfa1.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA1_SpecialStateTransition);
	    this.dfa12.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA12_SpecialStateTransition);
	    this.dfa14.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA14_SpecialStateTransition);
	    this.dfa16.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA16_SpecialStateTransition);
	}

    const string DFA1_eotS =
        "\x0a\uffff";
    const string DFA1_eofS =
        "\x0a\uffff";
    const string DFA1_minS =
        "\x01\x0d\x09\uffff";
    const string DFA1_maxS =
        "\x01\x23\x09\uffff";
    const string DFA1_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x02\x06\x02"+
        "\x07";
    const string DFA1_specialS =
        "\x01\x00\x09\uffff}>";
    static readonly string[] DFA1_transitionS = {
            "\x01\x06\x02\uffff\x02\x08\x01\uffff\x01\x01\x01\x02\x03\uffff"+
            "\x01\x05\x01\x09\x01\uffff\x01\x07\x03\uffff\x01\x03\x01\uffff"+
            "\x01\x04\x01\uffff\x01\x05",
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
            get { return "74:1: value : ( null_expr | boolean | integer | float_expr | string_expr | map | list );"; }
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

                   	else if ( (LA1_0 == QUOT || LA1_0 == UnQuotedString) ) { s = 5; }

                   	else if ( (LA1_0 == INDENT) && ((!IsInFlow)) ) { s = 6; }

                   	else if ( (LA1_0 == LBRACE) ) { s = 7; }

                   	else if ( ((LA1_0 >= INDENTATION && LA1_0 <= LI)) && ((!IsInFlow)) ) { s = 8; }

                   	else if ( (LA1_0 == LBRACKET) ) { s = 9; }

                   	 
                   	input.Seek(index1_0);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae1 =
            new NoViableAltException(dfa.Description, 1, _s, input);
        dfa.Error(nvae1);
        throw nvae1;
    }
    const string DFA12_eotS =
        "\x0d\uffff";
    const string DFA12_eofS =
        "\x0d\uffff";
    const string DFA12_minS =
        "\x01\x0d\x06\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA12_maxS =
        "\x01\x23\x06\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA12_acceptS =
        "\x01\uffff\x01\x02\x08\uffff\x02\x02\x01\x01";
    const string DFA12_specialS =
        "\x01\x00\x06\uffff\x01\x01\x01\uffff\x01\x02\x03\uffff}>";
    static readonly string[] DFA12_transitionS = {
            "\x01\x07\x01\x0c\x01\uffff\x01\x09\x01\x0a\x01\uffff\x02\x01"+
            "\x02\x0c\x01\uffff\x01\x01\x01\x0b\x01\uffff\x01\x01\x03\uffff"+
            "\x01\x01\x01\uffff\x01\x01\x01\uffff\x01\x01",
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
            get { return "()* loopback of 141:26: ( fskip )*"; }
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
                   	if ( ((LA12_0 >= NULL && LA12_0 <= Bool) || LA12_0 == QUOT || LA12_0 == LBRACE || LA12_0 == Integer || LA12_0 == Float || LA12_0 == UnQuotedString) ) { s = 1; }

                   	else if ( (LA12_0 == INDENT) ) { s = 7; }

                   	else if ( (LA12_0 == INDENTATION) ) { s = 9; }

                   	else if ( (LA12_0 == LI) && ((!IsInFlow)) ) { s = 10; }

                   	else if ( (LA12_0 == LBRACKET) ) { s = 11; }

                   	else if ( (LA12_0 == DEDENT || (LA12_0 >= NEWLINE && LA12_0 <= WS)) ) { s = 12; }

                   	 
                   	input.Seek(index12_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA12_7 = input.LA(1);

                   	 
                   	int index12_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 12; }

                   	else if ( ((!IsInFlow)) ) { s = 11; }

                   	 
                   	input.Seek(index12_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA12_9 = input.LA(1);

                   	 
                   	int index12_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 12; }

                   	else if ( ((!IsInFlow)) ) { s = 11; }

                   	 
                   	input.Seek(index12_9);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae12 =
            new NoViableAltException(dfa.Description, 12, _s, input);
        dfa.Error(nvae12);
        throw nvae12;
    }
    const string DFA14_eotS =
        "\x0d\uffff";
    const string DFA14_eofS =
        "\x0d\uffff";
    const string DFA14_minS =
        "\x01\x0d\x06\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA14_maxS =
        "\x01\x23\x06\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA14_acceptS =
        "\x01\uffff\x01\x02\x08\uffff\x02\x02\x01\x01";
    const string DFA14_specialS =
        "\x01\x00\x06\uffff\x01\x01\x01\uffff\x01\x02\x03\uffff}>";
    static readonly string[] DFA14_transitionS = {
            "\x01\x07\x01\x0c\x01\uffff\x01\x09\x01\x0a\x01\uffff\x02\x01"+
            "\x02\x0c\x01\uffff\x01\x01\x01\x0b\x01\uffff\x01\x01\x03\uffff"+
            "\x01\x01\x01\uffff\x01\x01\x01\uffff\x01\x01",
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
            get { return "()* loopback of 160:13: ( fskip )*"; }
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
                   	if ( ((LA14_0 >= NULL && LA14_0 <= Bool) || LA14_0 == QUOT || LA14_0 == LBRACE || LA14_0 == Integer || LA14_0 == Float || LA14_0 == UnQuotedString) ) { s = 1; }

                   	else if ( (LA14_0 == INDENT) ) { s = 7; }

                   	else if ( (LA14_0 == INDENTATION) ) { s = 9; }

                   	else if ( (LA14_0 == LI) && ((!IsInFlow)) ) { s = 10; }

                   	else if ( (LA14_0 == LBRACKET) ) { s = 11; }

                   	else if ( (LA14_0 == DEDENT || (LA14_0 >= NEWLINE && LA14_0 <= WS)) ) { s = 12; }

                   	 
                   	input.Seek(index14_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA14_7 = input.LA(1);

                   	 
                   	int index14_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 12; }

                   	else if ( ((!IsInFlow)) ) { s = 11; }

                   	 
                   	input.Seek(index14_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA14_9 = input.LA(1);

                   	 
                   	int index14_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 12; }

                   	else if ( ((!IsInFlow)) ) { s = 11; }

                   	 
                   	input.Seek(index14_9);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae14 =
            new NoViableAltException(dfa.Description, 14, _s, input);
        dfa.Error(nvae14);
        throw nvae14;
    }
    const string DFA16_eotS =
        "\x0d\uffff";
    const string DFA16_eofS =
        "\x0d\uffff";
    const string DFA16_minS =
        "\x01\x0d\x06\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA16_maxS =
        "\x01\x23\x06\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA16_acceptS =
        "\x01\uffff\x01\x02\x08\uffff\x02\x02\x01\x01";
    const string DFA16_specialS =
        "\x01\x00\x06\uffff\x01\x01\x01\uffff\x01\x02\x03\uffff}>";
    static readonly string[] DFA16_transitionS = {
            "\x01\x07\x01\x0c\x01\uffff\x01\x09\x01\x0a\x01\uffff\x02\x01"+
            "\x02\x0c\x01\uffff\x01\x01\x01\x0b\x01\uffff\x01\x01\x03\uffff"+
            "\x01\x01\x01\uffff\x01\x01\x01\uffff\x01\x01",
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

    static readonly short[] DFA16_eot = DFA.UnpackEncodedString(DFA16_eotS);
    static readonly short[] DFA16_eof = DFA.UnpackEncodedString(DFA16_eofS);
    static readonly char[] DFA16_min = DFA.UnpackEncodedStringToUnsignedChars(DFA16_minS);
    static readonly char[] DFA16_max = DFA.UnpackEncodedStringToUnsignedChars(DFA16_maxS);
    static readonly short[] DFA16_accept = DFA.UnpackEncodedString(DFA16_acceptS);
    static readonly short[] DFA16_special = DFA.UnpackEncodedString(DFA16_specialS);
    static readonly short[][] DFA16_transition = DFA.UnpackEncodedStringArray(DFA16_transitionS);

    protected class DFA16 : DFA
    {
        public DFA16(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 16;
            this.eot = DFA16_eot;
            this.eof = DFA16_eof;
            this.min = DFA16_min;
            this.max = DFA16_max;
            this.accept = DFA16_accept;
            this.special = DFA16_special;
            this.transition = DFA16_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 160:40: ( fskip )*"; }
        }

    }


    protected internal int DFA16_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA16_0 = input.LA(1);

                   	 
                   	int index16_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( ((LA16_0 >= NULL && LA16_0 <= Bool) || LA16_0 == QUOT || LA16_0 == LBRACE || LA16_0 == Integer || LA16_0 == Float || LA16_0 == UnQuotedString) ) { s = 1; }

                   	else if ( (LA16_0 == INDENT) ) { s = 7; }

                   	else if ( (LA16_0 == INDENTATION) ) { s = 9; }

                   	else if ( (LA16_0 == LI) && ((!IsInFlow)) ) { s = 10; }

                   	else if ( (LA16_0 == LBRACKET) ) { s = 11; }

                   	else if ( (LA16_0 == DEDENT || (LA16_0 >= NEWLINE && LA16_0 <= WS)) ) { s = 12; }

                   	 
                   	input.Seek(index16_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA16_7 = input.LA(1);

                   	 
                   	int index16_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 12; }

                   	else if ( ((!IsInFlow)) ) { s = 11; }

                   	 
                   	input.Seek(index16_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA16_9 = input.LA(1);

                   	 
                   	int index16_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 12; }

                   	else if ( ((!IsInFlow)) ) { s = 11; }

                   	 
                   	input.Seek(index16_9);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae16 =
            new NoViableAltException(dfa.Description, 16, _s, input);
        dfa.Error(nvae16);
        throw nvae16;
    }
 

    public static readonly BitSet FOLLOW_null_expr_in_value381 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_boolean_in_value386 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_integer_in_value391 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_float_expr_in_value397 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string_expr_in_value402 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_map_in_value407 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_list_in_value412 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Bool_in_boolean425 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_in_null_expr445 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Integer_in_integer456 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Float_in_float_expr478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QUOT_in_string_expr498 = new BitSet(new ulong[]{0x0000001001000000UL});
    public static readonly BitSet FOLLOW_QuotedStringChar_in_string_expr500 = new BitSet(new ulong[]{0x0000001001000000UL});
    public static readonly BitSet FOLLOW_QUOT_in_string_expr503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QUOT_in_string_expr520 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_UnQuotedString_in_string_expr522 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_QUOT_in_string_expr524 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QUOT_in_string_expr540 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_Integer_in_string_expr542 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_QUOT_in_string_expr544 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UnQuotedString_in_string_expr560 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACE_in_flow_map588 = new BitSet(new ulong[]{0x0000000801616000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_map590 = new BitSet(new ulong[]{0x0000000801616000UL});
    public static readonly BitSet FOLLOW_map_pair_in_flow_map593 = new BitSet(new ulong[]{0x0000000010E16000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_map595 = new BitSet(new ulong[]{0x0000000010E16000UL});
    public static readonly BitSet FOLLOW_COMMA_in_flow_map599 = new BitSet(new ulong[]{0x0000000801616000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_map601 = new BitSet(new ulong[]{0x0000000801616000UL});
    public static readonly BitSet FOLLOW_map_pair_in_flow_map604 = new BitSet(new ulong[]{0x0000000010E16000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_map606 = new BitSet(new ulong[]{0x0000000010E16000UL});
    public static readonly BitSet FOLLOW_RBRACE_in_flow_map612 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INDENT_in_block_map644 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_DENT_in_block_map646 = new BitSet(new ulong[]{0x0000000801616000UL});
    public static readonly BitSet FOLLOW_map_pair_in_block_map648 = new BitSet(new ulong[]{0x0000000000204000UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_block_map651 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_DENT_in_block_map653 = new BitSet(new ulong[]{0x0000000801616000UL});
    public static readonly BitSet FOLLOW_map_pair_in_block_map655 = new BitSet(new ulong[]{0x0000000000204000UL});
    public static readonly BitSet FOLLOW_DEDENT_in_block_map659 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_map_in_map690 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_flow_map_in_map695 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string_expr_in_map_pair707 = new BitSet(new ulong[]{0x0000000000656000UL});
    public static readonly BitSet FOLLOW_fskip_in_map_pair709 = new BitSet(new ulong[]{0x0000000000656000UL});
    public static readonly BitSet FOLLOW_MI_in_map_pair712 = new BitSet(new ulong[]{0x0000000A8B7B6000UL});
    public static readonly BitSet FOLLOW_fskip_in_map_pair714 = new BitSet(new ulong[]{0x0000000A8B7B6000UL});
    public static readonly BitSet FOLLOW_value_in_map_pair717 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_list_in_list745 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_flow_list_in_list750 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_fskip0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACKET_in_flow_list797 = new BitSet(new ulong[]{0x0000000A8B7B6000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_list799 = new BitSet(new ulong[]{0x0000000A8B7B6000UL});
    public static readonly BitSet FOLLOW_value_in_flow_list802 = new BitSet(new ulong[]{0x0000000004E16000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_list804 = new BitSet(new ulong[]{0x0000000004E16000UL});
    public static readonly BitSet FOLLOW_COMMA_in_flow_list808 = new BitSet(new ulong[]{0x0000000A8B7B6000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_list810 = new BitSet(new ulong[]{0x0000000A8B7B6000UL});
    public static readonly BitSet FOLLOW_value_in_flow_list813 = new BitSet(new ulong[]{0x0000000004E16000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_list815 = new BitSet(new ulong[]{0x0000000004E16000UL});
    public static readonly BitSet FOLLOW_RBRACKET_in_flow_list820 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INDENTATION_in_block_list853 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_INDENT_in_block_list855 = new BitSet(new ulong[]{0x0000000000030000UL});
    public static readonly BitSet FOLLOW_block_list_item_in_block_list857 = new BitSet(new ulong[]{0x0000000000030000UL});
    public static readonly BitSet FOLLOW_INDENTATION_in_block_list860 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DEDENT_in_block_list862 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_list_item_in_block_list880 = new BitSet(new ulong[]{0x0000000000030002UL});
    public static readonly BitSet FOLLOW_LI_in_block_list_item919 = new BitSet(new ulong[]{0x0000000A8B7B6000UL});
    public static readonly BitSet FOLLOW_WS_in_block_list_item921 = new BitSet(new ulong[]{0x0000000A8B7B6000UL});
    public static readonly BitSet FOLLOW_value_in_block_list_item924 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_block_list_item926 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}