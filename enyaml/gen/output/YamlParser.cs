// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g 2011-01-02 20:27:45

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:76:1: value : ( null_expr | boolean | integer | float_expr | string_expr | map | list );
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:77:2: ( null_expr | boolean | integer | float_expr | string_expr | map | list )
            int alt1 = 7;
            alt1 = dfa1.Predict(input);
            switch (alt1) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:77:4: null_expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_null_expr_in_value384);
                    	null_expr1 = null_expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, null_expr1.Tree);

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:78:4: boolean
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_boolean_in_value389);
                    	boolean2 = boolean();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolean2.Tree);

                    }
                    break;
                case 3 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:79:4: integer
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_integer_in_value394);
                    	integer3 = integer();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, integer3.Tree);

                    }
                    break;
                case 4 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:80:4: float_expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_float_expr_in_value400);
                    	float_expr4 = float_expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, float_expr4.Tree);

                    }
                    break;
                case 5 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:81:4: string_expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_string_expr_in_value405);
                    	string_expr5 = string_expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, string_expr5.Tree);

                    }
                    break;
                case 6 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:82:4: map
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_map_in_value410);
                    	map6 = map();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, map6.Tree);

                    }
                    break;
                case 7 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:83:4: list
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_list_in_value415);
                    	list7 = list();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, list7.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:86:1: boolean : Bool -> ^( BOOL Bool ) ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:87:2: ( Bool -> ^( BOOL Bool ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:87:4: Bool
            {
            	Bool8=(IToken)Match(input,Bool,FOLLOW_Bool_in_boolean428); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Bool.Add(Bool8);



            	// AST REWRITE
            	// elements:          Bool
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 87:9: -> ^( BOOL Bool )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:87:12: ^( BOOL Bool )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BOOL, "BOOL"), root_1);

            	    adaptor.AddChild(root_1, stream_Bool.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:90:1: null_expr : NULL ;
    public YamlParser.null_expr_return null_expr() // throws RecognitionException [1]
    {   
        YamlParser.null_expr_return retval = new YamlParser.null_expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NULL9 = null;

        object NULL9_tree=null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:91:2: ( NULL )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:91:4: NULL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	NULL9=(IToken)Match(input,NULL,FOLLOW_NULL_in_null_expr448); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NULL9_tree = (object)adaptor.Create(NULL9);
            		adaptor.AddChild(root_0, NULL9_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:94:1: integer : Integer -> ^( INTEGER Integer ) ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:95:2: ( Integer -> ^( INTEGER Integer ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:95:4: Integer
            {
            	Integer10=(IToken)Match(input,Integer,FOLLOW_Integer_in_integer459); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Integer.Add(Integer10);



            	// AST REWRITE
            	// elements:          Integer
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 95:12: -> ^( INTEGER Integer )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:95:15: ^( INTEGER Integer )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(INTEGER, "INTEGER"), root_1);

            	    adaptor.AddChild(root_1, stream_Integer.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:99:1: float_expr : Float -> ^( FLOAT Float ) ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:100:2: ( Float -> ^( FLOAT Float ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:100:4: Float
            {
            	Float11=(IToken)Match(input,Float,FOLLOW_Float_in_float_expr481); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Float.Add(Float11);



            	// AST REWRITE
            	// elements:          Float
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 100:10: -> ^( FLOAT Float )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:100:13: ^( FLOAT Float )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FLOAT, "FLOAT"), root_1);

            	    adaptor.AddChild(root_1, stream_Float.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:103:1: string_expr : ( ( UnQuotedString )=> ( ({...}?b= UnQuotedString -> ^( BOOL $b) ) | ({...}?n= UnQuotedString -> $n) ) | QUOT ( QuotedStringChar )* QUOT -> ^( QUOTED_STRING ( QuotedStringChar )* ) | QUOT UnQuotedString QUOT -> ^( QUOTED_STRING UnQuotedString ) | QUOT Integer QUOT -> ^( QUOTED_STRING Integer ) | UnQuotedString -> ^( UNQUOTED_STRING UnQuotedString ) );
    public YamlParser.string_expr_return string_expr() // throws RecognitionException [1]
    {   
        YamlParser.string_expr_return retval = new YamlParser.string_expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken b = null;
        IToken n = null;
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

        object b_tree=null;
        object n_tree=null;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:104:2: ( ( UnQuotedString )=> ( ({...}?b= UnQuotedString -> ^( BOOL $b) ) | ({...}?n= UnQuotedString -> $n) ) | QUOT ( QuotedStringChar )* QUOT -> ^( QUOTED_STRING ( QuotedStringChar )* ) | QUOT UnQuotedString QUOT -> ^( QUOTED_STRING UnQuotedString ) | QUOT Integer QUOT -> ^( QUOTED_STRING Integer ) | UnQuotedString -> ^( UNQUOTED_STRING UnQuotedString ) )
            int alt4 = 5;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == UnQuotedString) )
            {
                int LA4_1 = input.LA(2);

                if ( (((synpred1_Yaml() && ( input.LT(1).Text=="true" || input.LT(1).Text=="false" ))|| (synpred1_Yaml() && ( input.LT(1).Text == "null" )))) )
                {
                    alt4 = 1;
                }
                else if ( (true) )
                {
                    alt4 = 5;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d4s1 =
                        new NoViableAltException("", 4, 1, input);

                    throw nvae_d4s1;
                }
            }
            else if ( (LA4_0 == QUOT) )
            {
                switch ( input.LA(2) ) 
                {
                case UnQuotedString:
                	{
                    alt4 = 3;
                    }
                    break;
                case Integer:
                	{
                    alt4 = 4;
                    }
                    break;
                case QUOT:
                case QuotedStringChar:
                	{
                    alt4 = 2;
                    }
                    break;
                	default:
                	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                	    NoViableAltException nvae_d4s2 =
                	        new NoViableAltException("", 4, 2, input);

                	    throw nvae_d4s2;
                }

            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d4s0 =
                    new NoViableAltException("", 4, 0, input);

                throw nvae_d4s0;
            }
            switch (alt4) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:104:4: ( UnQuotedString )=> ( ({...}?b= UnQuotedString -> ^( BOOL $b) ) | ({...}?n= UnQuotedString -> $n) )
                    {
                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:105:2: ( ({...}?b= UnQuotedString -> ^( BOOL $b) ) | ({...}?n= UnQuotedString -> $n) )
                    	int alt2 = 2;
                    	int LA2_0 = input.LA(1);

                    	if ( (LA2_0 == UnQuotedString) )
                    	{
                    	    int LA2_1 = input.LA(2);

                    	    if ( (( input.LT(1).Text=="true" || input.LT(1).Text=="false" )) )
                    	    {
                    	        alt2 = 1;
                    	    }
                    	    else if ( (( input.LT(1).Text == "null" )) )
                    	    {
                    	        alt2 = 2;
                    	    }
                    	    else 
                    	    {
                    	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	        NoViableAltException nvae_d2s1 =
                    	            new NoViableAltException("", 2, 1, input);

                    	        throw nvae_d2s1;
                    	    }
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d2s0 =
                    	        new NoViableAltException("", 2, 0, input);

                    	    throw nvae_d2s0;
                    	}
                    	switch (alt2) 
                    	{
                    	    case 1 :
                    	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:106:3: ({...}?b= UnQuotedString -> ^( BOOL $b) )
                    	        {
                    	        	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:106:3: ({...}?b= UnQuotedString -> ^( BOOL $b) )
                    	        	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:107:4: {...}?b= UnQuotedString
                    	        	{
                    	        		if ( !(( input.LT(1).Text=="true" || input.LT(1).Text=="false" )) ) 
                    	        		{
                    	        		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	        		    throw new FailedPredicateException(input, "string_expr", " input.LT(1).Text==\"true\" || input.LT(1).Text==\"false\" ");
                    	        		}
                    	        		b=(IToken)Match(input,UnQuotedString,FOLLOW_UnQuotedString_in_string_expr524); if (state.failed) return retval; 
                    	        		if ( (state.backtracking==0) ) stream_UnQuotedString.Add(b);

                    	        		if ( (state.backtracking==0) )
                    	        		{
                    	        		  b.Type = Bool;
                    	        		}


                    	        		// AST REWRITE
                    	        		// elements:          b
                    	        		// token labels:      b
                    	        		// rule labels:       retval
                    	        		// token list labels: 
                    	        		// rule list labels:  
                    	        		// wildcard labels: 
                    	        		if ( (state.backtracking==0) ) {
                    	        		retval.Tree = root_0;
                    	        		RewriteRuleTokenStream stream_b = new RewriteRuleTokenStream(adaptor, "token b", b);
                    	        		RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	        		root_0 = (object)adaptor.GetNilNode();
                    	        		// 108:39: -> ^( BOOL $b)
                    	        		{
                    	        		    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:108:42: ^( BOOL $b)
                    	        		    {
                    	        		    object root_1 = (object)adaptor.GetNilNode();
                    	        		    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BOOL, "BOOL"), root_1);

                    	        		    adaptor.AddChild(root_1, stream_b.NextNode());

                    	        		    adaptor.AddChild(root_0, root_1);
                    	        		    }

                    	        		}

                    	        		retval.Tree = root_0;retval.Tree = root_0;}
                    	        	}


                    	        }
                    	        break;
                    	    case 2 :
                    	        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:110:5: ({...}?n= UnQuotedString -> $n)
                    	        {
                    	        	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:110:5: ({...}?n= UnQuotedString -> $n)
                    	        	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:111:4: {...}?n= UnQuotedString
                    	        	{
                    	        		if ( !(( input.LT(1).Text == "null" )) ) 
                    	        		{
                    	        		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	        		    throw new FailedPredicateException(input, "string_expr", " input.LT(1).Text == \"null\" ");
                    	        		}
                    	        		n=(IToken)Match(input,UnQuotedString,FOLLOW_UnQuotedString_in_string_expr557); if (state.failed) return retval; 
                    	        		if ( (state.backtracking==0) ) stream_UnQuotedString.Add(n);

                    	        		if ( (state.backtracking==0) )
                    	        		{
                    	        		   n.Type = NULL; 
                    	        		}


                    	        		// AST REWRITE
                    	        		// elements:          n
                    	        		// token labels:      n
                    	        		// rule labels:       retval
                    	        		// token list labels: 
                    	        		// rule list labels:  
                    	        		// wildcard labels: 
                    	        		if ( (state.backtracking==0) ) {
                    	        		retval.Tree = root_0;
                    	        		RewriteRuleTokenStream stream_n = new RewriteRuleTokenStream(adaptor, "token n", n);
                    	        		RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	        		root_0 = (object)adaptor.GetNilNode();
                    	        		// 112:41: -> $n
                    	        		{
                    	        		    adaptor.AddChild(root_0, stream_n.NextNode());

                    	        		}

                    	        		retval.Tree = root_0;retval.Tree = root_0;}
                    	        	}


                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:115:4: QUOT ( QuotedStringChar )* QUOT
                    {
                    	QUOT12=(IToken)Match(input,QUOT,FOLLOW_QUOT_in_string_expr576); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_QUOT.Add(QUOT12);

                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:115:9: ( QuotedStringChar )*
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);

                    	    if ( (LA3_0 == QuotedStringChar) )
                    	    {
                    	        alt3 = 1;
                    	    }


                    	    switch (alt3) 
                    		{
                    			case 1 :
                    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:115:9: QuotedStringChar
                    			    {
                    			    	QuotedStringChar13=(IToken)Match(input,QuotedStringChar,FOLLOW_QuotedStringChar_in_string_expr578); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_QuotedStringChar.Add(QuotedStringChar13);


                    			    }
                    			    break;

                    			default:
                    			    goto loop3;
                    	    }
                    	} while (true);

                    	loop3:
                    		;	// Stops C# compiler whining that label 'loop3' has no statements

                    	QUOT14=(IToken)Match(input,QUOT,FOLLOW_QUOT_in_string_expr581); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_QUOT.Add(QUOT14);



                    	// AST REWRITE
                    	// elements:          QuotedStringChar
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 116:3: -> ^( QUOTED_STRING ( QuotedStringChar )* )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:116:6: ^( QUOTED_STRING ( QuotedStringChar )* )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(QUOTED_STRING, "QUOTED_STRING"), root_1);

                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:116:22: ( QuotedStringChar )*
                    	    while ( stream_QuotedStringChar.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_QuotedStringChar.NextNode());

                    	    }
                    	    stream_QuotedStringChar.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:117:4: QUOT UnQuotedString QUOT
                    {
                    	QUOT15=(IToken)Match(input,QUOT,FOLLOW_QUOT_in_string_expr598); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_QUOT.Add(QUOT15);

                    	UnQuotedString16=(IToken)Match(input,UnQuotedString,FOLLOW_UnQuotedString_in_string_expr600); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_UnQuotedString.Add(UnQuotedString16);

                    	QUOT17=(IToken)Match(input,QUOT,FOLLOW_QUOT_in_string_expr602); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_QUOT.Add(QUOT17);



                    	// AST REWRITE
                    	// elements:          UnQuotedString
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 118:3: -> ^( QUOTED_STRING UnQuotedString )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:118:6: ^( QUOTED_STRING UnQuotedString )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(QUOTED_STRING, "QUOTED_STRING"), root_1);

                    	    adaptor.AddChild(root_1, stream_UnQuotedString.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 4 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:119:4: QUOT Integer QUOT
                    {
                    	QUOT18=(IToken)Match(input,QUOT,FOLLOW_QUOT_in_string_expr618); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_QUOT.Add(QUOT18);

                    	Integer19=(IToken)Match(input,Integer,FOLLOW_Integer_in_string_expr620); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_Integer.Add(Integer19);

                    	QUOT20=(IToken)Match(input,QUOT,FOLLOW_QUOT_in_string_expr622); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_QUOT.Add(QUOT20);



                    	// AST REWRITE
                    	// elements:          Integer
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 120:3: -> ^( QUOTED_STRING Integer )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:120:6: ^( QUOTED_STRING Integer )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(QUOTED_STRING, "QUOTED_STRING"), root_1);

                    	    adaptor.AddChild(root_1, stream_Integer.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 5 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:121:4: UnQuotedString
                    {
                    	UnQuotedString21=(IToken)Match(input,UnQuotedString,FOLLOW_UnQuotedString_in_string_expr638); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_UnQuotedString.Add(UnQuotedString21);



                    	// AST REWRITE
                    	// elements:          UnQuotedString
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 121:19: -> ^( UNQUOTED_STRING UnQuotedString )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:121:22: ^( UNQUOTED_STRING UnQuotedString )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(UNQUOTED_STRING, "UNQUOTED_STRING"), root_1);

                    	    adaptor.AddChild(root_1, stream_UnQuotedString.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:124:1: flow_map : LBRACE ( fskip )* map_pair ( fskip )* ( COMMA ( fskip )* map_pair ( fskip )* )* RBRACE -> ^( MAP ( map_pair )+ ) ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:129:2: ( LBRACE ( fskip )* map_pair ( fskip )* ( COMMA ( fskip )* map_pair ( fskip )* )* RBRACE -> ^( MAP ( map_pair )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:129:4: LBRACE ( fskip )* map_pair ( fskip )* ( COMMA ( fskip )* map_pair ( fskip )* )* RBRACE
            {
            	LBRACE22=(IToken)Match(input,LBRACE,FOLLOW_LBRACE_in_flow_map666); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LBRACE.Add(LBRACE22);

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:129:11: ( fskip )*
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
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:129:11: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_flow_map668);
            			    	fskip23 = fskip();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_fskip.Add(fskip23.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	PushFollow(FOLLOW_map_pair_in_flow_map671);
            	map_pair24 = map_pair();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_map_pair.Add(map_pair24.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:129:27: ( fskip )*
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
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:129:27: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_flow_map673);
            			    	fskip25 = fskip();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_fskip.Add(fskip25.Tree);

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:129:34: ( COMMA ( fskip )* map_pair ( fskip )* )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == COMMA) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:129:35: COMMA ( fskip )* map_pair ( fskip )*
            			    {
            			    	COMMA26=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_flow_map677); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA26);

            			    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:129:41: ( fskip )*
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
            			    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:129:41: fskip
            			    			    {
            			    			    	PushFollow(FOLLOW_fskip_in_flow_map679);
            			    			    	fskip27 = fskip();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( (state.backtracking==0) ) stream_fskip.Add(fskip27.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop7;
            			    	    }
            			    	} while (true);

            			    	loop7:
            			    		;	// Stops C# compiler whining that label 'loop7' has no statements

            			    	PushFollow(FOLLOW_map_pair_in_flow_map682);
            			    	map_pair28 = map_pair();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_map_pair.Add(map_pair28.Tree);
            			    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:129:57: ( fskip )*
            			    	do 
            			    	{
            			    	    int alt8 = 2;
            			    	    int LA8_0 = input.LA(1);

            			    	    if ( ((LA8_0 >= INDENT && LA8_0 <= DEDENT) || LA8_0 == INDENTATION || (LA8_0 >= NEWLINE && LA8_0 <= WS)) )
            			    	    {
            			    	        alt8 = 1;
            			    	    }


            			    	    switch (alt8) 
            			    		{
            			    			case 1 :
            			    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:129:57: fskip
            			    			    {
            			    			    	PushFollow(FOLLOW_fskip_in_flow_map684);
            			    			    	fskip29 = fskip();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( (state.backtracking==0) ) stream_fskip.Add(fskip29.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop8;
            			    	    }
            			    	} while (true);

            			    	loop8:
            			    		;	// Stops C# compiler whining that label 'loop8' has no statements


            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	RBRACE30=(IToken)Match(input,RBRACE,FOLLOW_RBRACE_in_flow_map690); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RBRACE.Add(RBRACE30);



            	// AST REWRITE
            	// elements:          map_pair
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 130:3: -> ^( MAP ( map_pair )+ )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:130:6: ^( MAP ( map_pair )+ )
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

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:137:1: block_map : INDENT DENT map_pair ( NEWLINE DENT map_pair )* DEDENT -> ^( MAP ( map_pair )+ ) ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:2: ( INDENT DENT map_pair ( NEWLINE DENT map_pair )* DEDENT -> ^( MAP ( map_pair )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:4: INDENT DENT map_pair ( NEWLINE DENT map_pair )* DEDENT
            {
            	INDENT31=(IToken)Match(input,INDENT,FOLLOW_INDENT_in_block_map722); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_INDENT.Add(INDENT31);

            	DENT32=(IToken)Match(input,DENT,FOLLOW_DENT_in_block_map724); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_DENT.Add(DENT32);

            	PushFollow(FOLLOW_map_pair_in_block_map726);
            	map_pair33 = map_pair();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_map_pair.Add(map_pair33.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:25: ( NEWLINE DENT map_pair )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == NEWLINE) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:141:26: NEWLINE DENT map_pair
            			    {
            			    	NEWLINE34=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_block_map729); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_NEWLINE.Add(NEWLINE34);

            			    	DENT35=(IToken)Match(input,DENT,FOLLOW_DENT_in_block_map731); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_DENT.Add(DENT35);

            			    	PushFollow(FOLLOW_map_pair_in_block_map733);
            			    	map_pair36 = map_pair();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_map_pair.Add(map_pair36.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	DEDENT37=(IToken)Match(input,DEDENT,FOLLOW_DEDENT_in_block_map737); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_DEDENT.Add(DEDENT37);



            	// AST REWRITE
            	// elements:          map_pair
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 142:3: -> ^( MAP ( map_pair )+ )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:142:6: ^( MAP ( map_pair )+ )
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

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:148:1: map : ({...}? => block_map | flow_map );
    public YamlParser.map_return map() // throws RecognitionException [1]
    {   
        YamlParser.map_return retval = new YamlParser.map_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        YamlParser.block_map_return block_map38 = default(YamlParser.block_map_return);

        YamlParser.flow_map_return flow_map39 = default(YamlParser.flow_map_return);



        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:149:2: ({...}? => block_map | flow_map )
            int alt11 = 2;
            int LA11_0 = input.LA(1);

            if ( (LA11_0 == INDENT) && ((!IsInFlow)) )
            {
                alt11 = 1;
            }
            else if ( (LA11_0 == LBRACE) )
            {
                alt11 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d11s0 =
                    new NoViableAltException("", 11, 0, input);

                throw nvae_d11s0;
            }
            switch (alt11) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:149:4: {...}? => block_map
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	if ( !((!IsInFlow)) ) 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    throw new FailedPredicateException(input, "map", "!IsInFlow");
                    	}
                    	PushFollow(FOLLOW_block_map_in_map768);
                    	block_map38 = block_map();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block_map38.Tree);

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:150:4: flow_map
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_flow_map_in_map773);
                    	flow_map39 = flow_map();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, flow_map39.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:153:1: map_pair : string_expr ( fskip )* MI ( fskip )* value -> ^( MI string_expr value ) ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:154:2: ( string_expr ( fskip )* MI ( fskip )* value -> ^( MI string_expr value ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:154:4: string_expr ( fskip )* MI ( fskip )* value
            {
            	PushFollow(FOLLOW_string_expr_in_map_pair785);
            	string_expr40 = string_expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_string_expr.Add(string_expr40.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:154:16: ( fskip )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= INDENT && LA12_0 <= DEDENT) || LA12_0 == INDENTATION || (LA12_0 >= NEWLINE && LA12_0 <= WS)) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:154:16: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_map_pair787);
            			    	fskip41 = fskip();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_fskip.Add(fskip41.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	MI42=(IToken)Match(input,MI,FOLLOW_MI_in_map_pair790); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_MI.Add(MI42);

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:154:26: ( fskip )*
            	do 
            	{
            	    int alt13 = 2;
            	    alt13 = dfa13.Predict(input);
            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:154:26: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_map_pair792);
            			    	fskip43 = fskip();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_fskip.Add(fskip43.Tree);

            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements

            	PushFollow(FOLLOW_value_in_map_pair795);
            	value44 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_value.Add(value44.Tree);


            	// AST REWRITE
            	// elements:          string_expr, value, MI
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 155:3: -> ^( MI string_expr value )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:155:6: ^( MI string_expr value )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_MI.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_string_expr.NextTree());
            	    adaptor.AddChild(root_1, stream_value.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:158:1: list : ({...}? => block_list | flow_list );
    public YamlParser.list_return list() // throws RecognitionException [1]
    {   
        YamlParser.list_return retval = new YamlParser.list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        YamlParser.block_list_return block_list45 = default(YamlParser.block_list_return);

        YamlParser.flow_list_return flow_list46 = default(YamlParser.flow_list_return);



        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:159:2: ({...}? => block_list | flow_list )
            int alt14 = 2;
            int LA14_0 = input.LA(1);

            if ( ((LA14_0 >= INDENTATION && LA14_0 <= LI)) && ((!IsInFlow)) )
            {
                alt14 = 1;
            }
            else if ( (LA14_0 == LBRACKET) )
            {
                alt14 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d14s0 =
                    new NoViableAltException("", 14, 0, input);

                throw nvae_d14s0;
            }
            switch (alt14) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:159:4: {...}? => block_list
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	if ( !((!IsInFlow)) ) 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    throw new FailedPredicateException(input, "list", "!IsInFlow");
                    	}
                    	PushFollow(FOLLOW_block_list_in_list823);
                    	block_list45 = block_list();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block_list45.Tree);

                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:160:4: flow_list
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_flow_list_in_list828);
                    	flow_list46 = flow_list();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, flow_list46.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:164:1: fskip : ( NEWLINE | INDENTATION | INDENT | DEDENT | WS );
    public YamlParser.fskip_return fskip() // throws RecognitionException [1]
    {   
        YamlParser.fskip_return retval = new YamlParser.fskip_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set47 = null;

        object set47_tree=null;

        try 
    	{
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:165:2: ( NEWLINE | INDENTATION | INDENT | DEDENT | WS )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set47 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= INDENT && input.LA(1) <= DEDENT) || input.LA(1) == INDENTATION || (input.LA(1) >= NEWLINE && input.LA(1) <= WS) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set47));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:168:1: flow_list : LBRACKET ( fskip )* value ( fskip )* ( COMMA ( fskip )* value ( fskip )* )* RBRACKET -> ^( LIST ( value )+ ) ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:173:2: ( LBRACKET ( fskip )* value ( fskip )* ( COMMA ( fskip )* value ( fskip )* )* RBRACKET -> ^( LIST ( value )+ ) )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:173:4: LBRACKET ( fskip )* value ( fskip )* ( COMMA ( fskip )* value ( fskip )* )* RBRACKET
            {
            	LBRACKET48=(IToken)Match(input,LBRACKET,FOLLOW_LBRACKET_in_flow_list875); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LBRACKET.Add(LBRACKET48);

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:173:13: ( fskip )*
            	do 
            	{
            	    int alt15 = 2;
            	    alt15 = dfa15.Predict(input);
            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:173:13: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_flow_list877);
            			    	fskip49 = fskip();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_fskip.Add(fskip49.Tree);

            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements

            	PushFollow(FOLLOW_value_in_flow_list880);
            	value50 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_value.Add(value50.Tree);
            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:173:26: ( fskip )*
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( ((LA16_0 >= INDENT && LA16_0 <= DEDENT) || LA16_0 == INDENTATION || (LA16_0 >= NEWLINE && LA16_0 <= WS)) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:173:26: fskip
            			    {
            			    	PushFollow(FOLLOW_fskip_in_flow_list882);
            			    	fskip51 = fskip();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_fskip.Add(fskip51.Tree);

            			    }
            			    break;

            			default:
            			    goto loop16;
            	    }
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:173:33: ( COMMA ( fskip )* value ( fskip )* )*
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( (LA19_0 == COMMA) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:173:34: COMMA ( fskip )* value ( fskip )*
            			    {
            			    	COMMA52=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_flow_list886); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_COMMA.Add(COMMA52);

            			    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:173:40: ( fskip )*
            			    	do 
            			    	{
            			    	    int alt17 = 2;
            			    	    alt17 = dfa17.Predict(input);
            			    	    switch (alt17) 
            			    		{
            			    			case 1 :
            			    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:173:40: fskip
            			    			    {
            			    			    	PushFollow(FOLLOW_fskip_in_flow_list888);
            			    			    	fskip53 = fskip();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( (state.backtracking==0) ) stream_fskip.Add(fskip53.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop17;
            			    	    }
            			    	} while (true);

            			    	loop17:
            			    		;	// Stops C# compiler whining that label 'loop17' has no statements

            			    	PushFollow(FOLLOW_value_in_flow_list891);
            			    	value54 = value();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_value.Add(value54.Tree);
            			    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:173:53: ( fskip )*
            			    	do 
            			    	{
            			    	    int alt18 = 2;
            			    	    int LA18_0 = input.LA(1);

            			    	    if ( ((LA18_0 >= INDENT && LA18_0 <= DEDENT) || LA18_0 == INDENTATION || (LA18_0 >= NEWLINE && LA18_0 <= WS)) )
            			    	    {
            			    	        alt18 = 1;
            			    	    }


            			    	    switch (alt18) 
            			    		{
            			    			case 1 :
            			    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:173:53: fskip
            			    			    {
            			    			    	PushFollow(FOLLOW_fskip_in_flow_list893);
            			    			    	fskip55 = fskip();
            			    			    	state.followingStackPointer--;
            			    			    	if (state.failed) return retval;
            			    			    	if ( (state.backtracking==0) ) stream_fskip.Add(fskip55.Tree);

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop18;
            			    	    }
            			    	} while (true);

            			    	loop18:
            			    		;	// Stops C# compiler whining that label 'loop18' has no statements


            			    }
            			    break;

            			default:
            			    goto loop19;
            	    }
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whining that label 'loop19' has no statements

            	RBRACKET56=(IToken)Match(input,RBRACKET,FOLLOW_RBRACKET_in_flow_list898); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_RBRACKET.Add(RBRACKET56);



            	// AST REWRITE
            	// elements:          value
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 174:3: -> ^( LIST ( value )+ )
            	{
            	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:174:6: ^( LIST ( value )+ )
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

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:181:1: block_list : ( INDENTATION INDENT ( block_list_item )+ INDENTATION DEDENT -> ^( LIST ( block_list_item )+ ) | {...}? ( block_list_item )+ -> ^( LIST ( block_list_item )+ ) );
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:185:2: ( INDENTATION INDENT ( block_list_item )+ INDENTATION DEDENT -> ^( LIST ( block_list_item )+ ) | {...}? ( block_list_item )+ -> ^( LIST ( block_list_item )+ ) )
            int alt22 = 2;
            int LA22_0 = input.LA(1);

            if ( (LA22_0 == INDENTATION) )
            {
                alt22 = 1;
            }
            else if ( (LA22_0 == LI) )
            {
                alt22 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d22s0 =
                    new NoViableAltException("", 22, 0, input);

                throw nvae_d22s0;
            }
            switch (alt22) 
            {
                case 1 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:185:4: INDENTATION INDENT ( block_list_item )+ INDENTATION DEDENT
                    {
                    	INDENTATION57=(IToken)Match(input,INDENTATION,FOLLOW_INDENTATION_in_block_list931); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_INDENTATION.Add(INDENTATION57);

                    	INDENT58=(IToken)Match(input,INDENT,FOLLOW_INDENT_in_block_list933); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_INDENT.Add(INDENT58);

                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:185:23: ( block_list_item )+
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
                    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:185:23: block_list_item
                    			    {
                    			    	PushFollow(FOLLOW_block_list_item_in_block_list935);
                    			    	block_list_item59 = block_list_item();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_block_list_item.Add(block_list_item59.Tree);

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt20 >= 1 ) goto loop20;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee20 =
                    		                new EarlyExitException(20, input);
                    		            throw eee20;
                    	    }
                    	    cnt20++;
                    	} while (true);

                    	loop20:
                    		;	// Stops C# compiler whining that label 'loop20' has no statements

                    	INDENTATION60=(IToken)Match(input,INDENTATION,FOLLOW_INDENTATION_in_block_list938); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_INDENTATION.Add(INDENTATION60);

                    	DEDENT61=(IToken)Match(input,DEDENT,FOLLOW_DEDENT_in_block_list940); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_DEDENT.Add(DEDENT61);



                    	// AST REWRITE
                    	// elements:          block_list_item
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 186:3: -> ^( LIST ( block_list_item )+ )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:186:6: ^( LIST ( block_list_item )+ )
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

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:187:4: {...}? ( block_list_item )+
                    {
                    	if ( !((flowLvl == 0)) ) 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    throw new FailedPredicateException(input, "block_list", "flowLvl == 0");
                    	}
                    	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:187:20: ( block_list_item )+
                    	int cnt21 = 0;
                    	do 
                    	{
                    	    int alt21 = 2;
                    	    int LA21_0 = input.LA(1);

                    	    if ( (LA21_0 == LI) )
                    	    {
                    	        alt21 = 1;
                    	    }


                    	    switch (alt21) 
                    		{
                    			case 1 :
                    			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:187:20: block_list_item
                    			    {
                    			    	PushFollow(FOLLOW_block_list_item_in_block_list958);
                    			    	block_list_item62 = block_list_item();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( (state.backtracking==0) ) stream_block_list_item.Add(block_list_item62.Tree);

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt21 >= 1 ) goto loop21;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    		            EarlyExitException eee21 =
                    		                new EarlyExitException(21, input);
                    		            throw eee21;
                    	    }
                    	    cnt21++;
                    	} while (true);

                    	loop21:
                    		;	// Stops C# compiler whining that label 'loop21' has no statements



                    	// AST REWRITE
                    	// elements:          block_list_item
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 188:3: -> ^( LIST ( block_list_item )+ )
                    	{
                    	    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:188:6: ^( LIST ( block_list_item )+ )
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

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:194:1: block_list_item : {...}? LI ( WS )* value NEWLINE -> value ;
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
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:201:2: ({...}? LI ( WS )* value NEWLINE -> value )
            // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:201:4: {...}? LI ( WS )* value NEWLINE
            {
            	if ( !((((block_list_item_scope)block_list_item_stack.Peek()).lvl == BlockLevel)) ) 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    throw new FailedPredicateException(input, "block_list_item", "$block_list_item::lvl == BlockLevel");
            	}
            	LI63=(IToken)Match(input,LI,FOLLOW_LI_in_block_list_item997); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_LI.Add(LI63);

            	// C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:201:46: ( WS )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( (LA23_0 == WS) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:201:46: WS
            			    {
            			    	WS64=(IToken)Match(input,WS,FOLLOW_WS_in_block_list_item999); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_WS.Add(WS64);


            			    }
            			    break;

            			default:
            			    goto loop23;
            	    }
            	} while (true);

            	loop23:
            		;	// Stops C# compiler whining that label 'loop23' has no statements

            	PushFollow(FOLLOW_value_in_block_list_item1002);
            	value65 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_value.Add(value65.Tree);
            	NEWLINE66=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_block_list_item1004); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_NEWLINE.Add(NEWLINE66);



            	// AST REWRITE
            	// elements:          value
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 202:3: -> value
            	{
            	    adaptor.AddChild(root_0, stream_value.NextTree());

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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

    // $ANTLR start "synpred1_Yaml"
    public void synpred1_Yaml_fragment() {
        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:104:4: ( UnQuotedString )
        // C:\\dev\\enyaml\\enyaml\\gen\\Yaml.g:104:5: UnQuotedString
        {
        	Match(input,UnQuotedString,FOLLOW_UnQuotedString_in_synpred1_Yaml502); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_Yaml"

    // Delegated rules

   	public bool synpred1_Yaml() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_Yaml_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA1 dfa1;
   	protected DFA13 dfa13;
   	protected DFA15 dfa15;
   	protected DFA17 dfa17;
	private void InitializeCyclicDFAs()
	{
    	this.dfa1 = new DFA1(this);
    	this.dfa13 = new DFA13(this);
    	this.dfa15 = new DFA15(this);
    	this.dfa17 = new DFA17(this);
	    this.dfa1.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA1_SpecialStateTransition);
	    this.dfa13.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA13_SpecialStateTransition);
	    this.dfa15.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA15_SpecialStateTransition);
	    this.dfa17.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA17_SpecialStateTransition);
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
            get { return "76:1: value : ( null_expr | boolean | integer | float_expr | string_expr | map | list );"; }
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
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae1 =
            new NoViableAltException(dfa.Description, 1, _s, input);
        dfa.Error(nvae1);
        throw nvae1;
    }
    const string DFA13_eotS =
        "\x0d\uffff";
    const string DFA13_eofS =
        "\x0d\uffff";
    const string DFA13_minS =
        "\x01\x0d\x06\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA13_maxS =
        "\x01\x23\x06\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA13_acceptS =
        "\x01\uffff\x01\x02\x08\uffff\x02\x02\x01\x01";
    const string DFA13_specialS =
        "\x01\x00\x06\uffff\x01\x01\x01\uffff\x01\x02\x03\uffff}>";
    static readonly string[] DFA13_transitionS = {
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
            get { return "()* loopback of 154:26: ( fskip )*"; }
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
                   	if ( ((LA13_0 >= NULL && LA13_0 <= Bool) || LA13_0 == QUOT || LA13_0 == LBRACE || LA13_0 == Integer || LA13_0 == Float || LA13_0 == UnQuotedString) ) { s = 1; }

                   	else if ( (LA13_0 == INDENT) ) { s = 7; }

                   	else if ( (LA13_0 == INDENTATION) ) { s = 9; }

                   	else if ( (LA13_0 == LI) && ((!IsInFlow)) ) { s = 10; }

                   	else if ( (LA13_0 == LBRACKET) ) { s = 11; }

                   	else if ( (LA13_0 == DEDENT || (LA13_0 >= NEWLINE && LA13_0 <= WS)) ) { s = 12; }

                   	 
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
        if (state.backtracking > 0) {state.failed = true; return -1;}
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
        "\x01\x23\x06\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA15_acceptS =
        "\x01\uffff\x01\x02\x08\uffff\x02\x02\x01\x01";
    const string DFA15_specialS =
        "\x01\x00\x06\uffff\x01\x01\x01\uffff\x01\x02\x03\uffff}>";
    static readonly string[] DFA15_transitionS = {
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
            get { return "()* loopback of 173:13: ( fskip )*"; }
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
                   	if ( ((LA15_0 >= NULL && LA15_0 <= Bool) || LA15_0 == QUOT || LA15_0 == LBRACE || LA15_0 == Integer || LA15_0 == Float || LA15_0 == UnQuotedString) ) { s = 1; }

                   	else if ( (LA15_0 == INDENT) ) { s = 7; }

                   	else if ( (LA15_0 == INDENTATION) ) { s = 9; }

                   	else if ( (LA15_0 == LI) && ((!IsInFlow)) ) { s = 10; }

                   	else if ( (LA15_0 == LBRACKET) ) { s = 11; }

                   	else if ( (LA15_0 == DEDENT || (LA15_0 >= NEWLINE && LA15_0 <= WS)) ) { s = 12; }

                   	 
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
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae15 =
            new NoViableAltException(dfa.Description, 15, _s, input);
        dfa.Error(nvae15);
        throw nvae15;
    }
    const string DFA17_eotS =
        "\x0d\uffff";
    const string DFA17_eofS =
        "\x0d\uffff";
    const string DFA17_minS =
        "\x01\x0d\x06\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA17_maxS =
        "\x01\x23\x06\uffff\x01\x00\x01\uffff\x01\x00\x03\uffff";
    const string DFA17_acceptS =
        "\x01\uffff\x01\x02\x08\uffff\x02\x02\x01\x01";
    const string DFA17_specialS =
        "\x01\x00\x06\uffff\x01\x01\x01\uffff\x01\x02\x03\uffff}>";
    static readonly string[] DFA17_transitionS = {
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

    static readonly short[] DFA17_eot = DFA.UnpackEncodedString(DFA17_eotS);
    static readonly short[] DFA17_eof = DFA.UnpackEncodedString(DFA17_eofS);
    static readonly char[] DFA17_min = DFA.UnpackEncodedStringToUnsignedChars(DFA17_minS);
    static readonly char[] DFA17_max = DFA.UnpackEncodedStringToUnsignedChars(DFA17_maxS);
    static readonly short[] DFA17_accept = DFA.UnpackEncodedString(DFA17_acceptS);
    static readonly short[] DFA17_special = DFA.UnpackEncodedString(DFA17_specialS);
    static readonly short[][] DFA17_transition = DFA.UnpackEncodedStringArray(DFA17_transitionS);

    protected class DFA17 : DFA
    {
        public DFA17(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 17;
            this.eot = DFA17_eot;
            this.eof = DFA17_eof;
            this.min = DFA17_min;
            this.max = DFA17_max;
            this.accept = DFA17_accept;
            this.special = DFA17_special;
            this.transition = DFA17_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 173:40: ( fskip )*"; }
        }

    }


    protected internal int DFA17_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA17_0 = input.LA(1);

                   	 
                   	int index17_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( ((LA17_0 >= NULL && LA17_0 <= Bool) || LA17_0 == QUOT || LA17_0 == LBRACE || LA17_0 == Integer || LA17_0 == Float || LA17_0 == UnQuotedString) ) { s = 1; }

                   	else if ( (LA17_0 == INDENT) ) { s = 7; }

                   	else if ( (LA17_0 == INDENTATION) ) { s = 9; }

                   	else if ( (LA17_0 == LI) && ((!IsInFlow)) ) { s = 10; }

                   	else if ( (LA17_0 == LBRACKET) ) { s = 11; }

                   	else if ( (LA17_0 == DEDENT || (LA17_0 >= NEWLINE && LA17_0 <= WS)) ) { s = 12; }

                   	 
                   	input.Seek(index17_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA17_7 = input.LA(1);

                   	 
                   	int index17_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 12; }

                   	else if ( ((!IsInFlow)) ) { s = 11; }

                   	 
                   	input.Seek(index17_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA17_9 = input.LA(1);

                   	 
                   	int index17_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (!(((!IsInFlow)))) ) { s = 12; }

                   	else if ( ((!IsInFlow)) ) { s = 11; }

                   	 
                   	input.Seek(index17_9);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae17 =
            new NoViableAltException(dfa.Description, 17, _s, input);
        dfa.Error(nvae17);
        throw nvae17;
    }
 

    public static readonly BitSet FOLLOW_null_expr_in_value384 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_boolean_in_value389 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_integer_in_value394 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_float_expr_in_value400 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string_expr_in_value405 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_map_in_value410 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_list_in_value415 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Bool_in_boolean428 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_in_null_expr448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Integer_in_integer459 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Float_in_float_expr481 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UnQuotedString_in_string_expr524 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UnQuotedString_in_string_expr557 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QUOT_in_string_expr576 = new BitSet(new ulong[]{0x0000001001000000UL});
    public static readonly BitSet FOLLOW_QuotedStringChar_in_string_expr578 = new BitSet(new ulong[]{0x0000001001000000UL});
    public static readonly BitSet FOLLOW_QUOT_in_string_expr581 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QUOT_in_string_expr598 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_UnQuotedString_in_string_expr600 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_QUOT_in_string_expr602 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QUOT_in_string_expr618 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_Integer_in_string_expr620 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_QUOT_in_string_expr622 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UnQuotedString_in_string_expr638 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACE_in_flow_map666 = new BitSet(new ulong[]{0x0000000801616000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_map668 = new BitSet(new ulong[]{0x0000000801616000UL});
    public static readonly BitSet FOLLOW_map_pair_in_flow_map671 = new BitSet(new ulong[]{0x0000000010E16000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_map673 = new BitSet(new ulong[]{0x0000000010E16000UL});
    public static readonly BitSet FOLLOW_COMMA_in_flow_map677 = new BitSet(new ulong[]{0x0000000801616000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_map679 = new BitSet(new ulong[]{0x0000000801616000UL});
    public static readonly BitSet FOLLOW_map_pair_in_flow_map682 = new BitSet(new ulong[]{0x0000000010E16000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_map684 = new BitSet(new ulong[]{0x0000000010E16000UL});
    public static readonly BitSet FOLLOW_RBRACE_in_flow_map690 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INDENT_in_block_map722 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_DENT_in_block_map724 = new BitSet(new ulong[]{0x0000000801616000UL});
    public static readonly BitSet FOLLOW_map_pair_in_block_map726 = new BitSet(new ulong[]{0x0000000000204000UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_block_map729 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_DENT_in_block_map731 = new BitSet(new ulong[]{0x0000000801616000UL});
    public static readonly BitSet FOLLOW_map_pair_in_block_map733 = new BitSet(new ulong[]{0x0000000000204000UL});
    public static readonly BitSet FOLLOW_DEDENT_in_block_map737 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_map_in_map768 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_flow_map_in_map773 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_string_expr_in_map_pair785 = new BitSet(new ulong[]{0x0000000000656000UL});
    public static readonly BitSet FOLLOW_fskip_in_map_pair787 = new BitSet(new ulong[]{0x0000000000656000UL});
    public static readonly BitSet FOLLOW_MI_in_map_pair790 = new BitSet(new ulong[]{0x0000000A8B7B6000UL});
    public static readonly BitSet FOLLOW_fskip_in_map_pair792 = new BitSet(new ulong[]{0x0000000A8B7B6000UL});
    public static readonly BitSet FOLLOW_value_in_map_pair795 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_list_in_list823 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_flow_list_in_list828 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_fskip0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LBRACKET_in_flow_list875 = new BitSet(new ulong[]{0x0000000A8B7B6000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_list877 = new BitSet(new ulong[]{0x0000000A8B7B6000UL});
    public static readonly BitSet FOLLOW_value_in_flow_list880 = new BitSet(new ulong[]{0x0000000004E16000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_list882 = new BitSet(new ulong[]{0x0000000004E16000UL});
    public static readonly BitSet FOLLOW_COMMA_in_flow_list886 = new BitSet(new ulong[]{0x0000000A8B7B6000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_list888 = new BitSet(new ulong[]{0x0000000A8B7B6000UL});
    public static readonly BitSet FOLLOW_value_in_flow_list891 = new BitSet(new ulong[]{0x0000000004E16000UL});
    public static readonly BitSet FOLLOW_fskip_in_flow_list893 = new BitSet(new ulong[]{0x0000000004E16000UL});
    public static readonly BitSet FOLLOW_RBRACKET_in_flow_list898 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INDENTATION_in_block_list931 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_INDENT_in_block_list933 = new BitSet(new ulong[]{0x0000000000030000UL});
    public static readonly BitSet FOLLOW_block_list_item_in_block_list935 = new BitSet(new ulong[]{0x0000000000030000UL});
    public static readonly BitSet FOLLOW_INDENTATION_in_block_list938 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DEDENT_in_block_list940 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_block_list_item_in_block_list958 = new BitSet(new ulong[]{0x0000000000030002UL});
    public static readonly BitSet FOLLOW_LI_in_block_list_item997 = new BitSet(new ulong[]{0x0000000A8B7B6000UL});
    public static readonly BitSet FOLLOW_WS_in_block_list_item999 = new BitSet(new ulong[]{0x0000000A8B7B6000UL});
    public static readonly BitSet FOLLOW_value_in_block_list_item1002 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_block_list_item1004 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UnQuotedString_in_synpred1_Yaml502 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}