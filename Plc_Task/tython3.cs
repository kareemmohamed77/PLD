
using System;
using System.IO;
using System.Runtime.Serialization;
using com.calitha.goldparser.lalr;
using com.calitha.commons;

namespace com.calitha.goldparser
{

    [Serializable()]
    public class SymbolException : System.Exception
    {
        public SymbolException(string message) : base(message)
        {
        }

        public SymbolException(string message,
            Exception inner) : base(message, inner)
        {
        }

        protected SymbolException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }

    }

    [Serializable()]
    public class RuleException : System.Exception
    {

        public RuleException(string message) : base(message)
        {
        }

        public RuleException(string message,
                             Exception inner) : base(message, inner)
        {
        }

        protected RuleException(SerializationInfo info,
                                StreamingContext context) : base(info, context)
        {
        }

    }

    enum SymbolConstants : int
    {
        SYMBOL_EOF                  =  0, // (EOF)
        SYMBOL_ERROR                =  1, // (Error)
        SYMBOL_WHITESPACE           =  2, // Whitespace
        SYMBOL_MINUS                =  3, // '-'
        SYMBOL_MINUSMINUS           =  4, // '--'
        SYMBOL_EXCLAMEQ             =  5, // '!='
        SYMBOL_PERCENT              =  6, // '%'
        SYMBOL_LPAREN               =  7, // '('
        SYMBOL_RPAREN               =  8, // ')'
        SYMBOL_TIMES                =  9, // '*'
        SYMBOL_TIMESTIMES           = 10, // '**'
        SYMBOL_COMMA                = 11, // ','
        SYMBOL_DIV                  = 12, // '/'
        SYMBOL_COLON                = 13, // ':'
        SYMBOL_SEMI                 = 14, // ';'
        SYMBOL_LBRACKET             = 15, // '['
        SYMBOL_RBRACKET             = 16, // ']'
        SYMBOL_LBRACE               = 17, // '{'
        SYMBOL_LBRACERBRACE         = 18, // '{}'
        SYMBOL_RBRACE               = 19, // '}'
        SYMBOL_PLUS                 = 20, // '+'
        SYMBOL_PLUSPLUS             = 21, // '++'
        SYMBOL_LT                   = 22, // '<'
        SYMBOL_LTEQ                 = 23, // '<='
        SYMBOL_EQ                   = 24, // '='
        SYMBOL_EQEQ                 = 25, // '=='
        SYMBOL_GT                   = 26, // '>'
        SYMBOL_GTEQ                 = 27, // '>='
        SYMBOL_CASE                 = 28, // case
        SYMBOL_DEFAULT              = 29, // default
        SYMBOL_DIGIT                = 30, // Digit
        SYMBOL_ELSE                 = 31, // else
        SYMBOL_FOR                  = 32, // for
        SYMBOL_FUN                  = 33, // fun
        SYMBOL_IDENTIFIER           = 34, // Identifier
        SYMBOL_IF                   = 35, // if
        SYMBOL_NEWLINE              = 36, // NewLine
        SYMBOL_PRINT                = 37, // print
        SYMBOL_RET                  = 38, // ret
        SYMBOL_STOP                 = 39, // stop
        SYMBOL_STRINGLITERAL        = 40, // StringLiteral
        SYMBOL_SWITCH               = 41, // switch
        SYMBOL_TYTHON3              = 42, // 'Tython3'
        SYMBOL_WHILE                = 43, // while
        SYMBOL_ARRAY                = 44, // <Array>
        SYMBOL_ARRAY_INITIALIZATION = 45, // <Array_initialization>
        SYMBOL_ASSIGN               = 46, // <Assign>
        SYMBOL_BLOCK_FUNCTION       = 47, // <Block_function>
        SYMBOL_CALL_FUNCTION        = 48, // <Call_function>
        SYMBOL_CASE_BLOCK           = 49, // <Case_block>
        SYMBOL_CONCEPT              = 50, // <Concept>
        SYMBOL_COND                 = 51, // <cond>
        SYMBOL_DIGIT2               = 52, // <Digit>
        SYMBOL_EXPRESSION           = 53, // <Expression>
        SYMBOL_FACTOR               = 54, // <Factor>
        SYMBOL_FOR_STMT             = 55, // <For_stmt>
        SYMBOL_FUNCTION             = 56, // <Function>
        SYMBOL_ID                   = 57, // <ID>
        SYMBOL_IF_STMT              = 58, // <If_stmt>
        SYMBOL_LITERAL              = 59, // <Literal>
        SYMBOL_NAME                 = 60, // <Name>
        SYMBOL_NL                   = 61, // <nl>
        SYMBOL_NLOPT                = 62, // <nl Opt>
        SYMBOL_OP                   = 63, // <Op>
        SYMBOL_PARAMETER            = 64, // <Parameter>
        SYMBOL_PRINT2               = 65, // <Print>
        SYMBOL_PROGRAM              = 66, // <Program>
        SYMBOL_STEP                 = 67, // <Step>
        SYMBOL_STMT_LIST            = 68, // <Stmt_list>
        SYMBOL_SWITCH_STMT          = 69, // <Switch_stmt>
        SYMBOL_TERM                 = 70, // <Term>
        SYMBOL_VALUE                = 71, // <Value>
        SYMBOL_VARIABLE             = 72, // <Variable>
        SYMBOL_WHILE_STMT           = 73  // <While_stmt>
    };

    enum RuleConstants : int
    {
        RULE_NL_NEWLINE                                                                                    =  0, // <nl> ::= NewLine <nl>
        RULE_NL_NEWLINE2                                                                                   =  1, // <nl> ::= NewLine
        RULE_NLOPT_NEWLINE                                                                                 =  2, // <nl Opt> ::= NewLine <nl Opt>
        RULE_NLOPT                                                                                         =  3, // <nl Opt> ::= 
        RULE_PROGRAM_TYTHON3_TYTHON3                                                                       =  4, // <Program> ::= 'Tython3' <nl Opt> <Stmt_list> 'Tython3' <Function>
        RULE_STMT_LIST                                                                                     =  5, // <Stmt_list> ::= <nl Opt> <Concept> <nl Opt>
        RULE_STMT_LIST2                                                                                    =  6, // <Stmt_list> ::= <nl Opt> <Concept> <nl Opt> <Stmt_list>
        RULE_CONCEPT                                                                                       =  7, // <Concept> ::= <Variable>
        RULE_CONCEPT2                                                                                      =  8, // <Concept> ::= <If_stmt>
        RULE_CONCEPT3                                                                                      =  9, // <Concept> ::= <Switch_stmt>
        RULE_CONCEPT4                                                                                      = 10, // <Concept> ::= <For_stmt>
        RULE_CONCEPT5                                                                                      = 11, // <Concept> ::= <While_stmt>
        RULE_CONCEPT6                                                                                      = 12, // <Concept> ::= <Array>
        RULE_CONCEPT7                                                                                      = 13, // <Concept> ::= <Call_function>
        RULE_CONCEPT8                                                                                      = 14, // <Concept> ::= <Print>
        RULE_VARIABLE                                                                                      = 15, // <Variable> ::= <Name>
        RULE_VARIABLE2                                                                                     = 16, // <Variable> ::= <Assign>
        RULE_ASSIGN_EQ                                                                                     = 17, // <Assign> ::= <Name> '=' <Expression>
        RULE_NAME                                                                                          = 18, // <Name> ::= <ID>
        RULE_ID_IDENTIFIER                                                                                 = 19, // <ID> ::= Identifier
        RULE_EXPRESSION_PLUS                                                                               = 20, // <Expression> ::= <Expression> '+' <Term>
        RULE_EXPRESSION_MINUS                                                                              = 21, // <Expression> ::= <Expression> '-' <Term>
        RULE_EXPRESSION                                                                                    = 22, // <Expression> ::= <Term>
        RULE_TERM_TIMES                                                                                    = 23, // <Term> ::= <Term> '*' <Factor>
        RULE_TERM_DIV                                                                                      = 24, // <Term> ::= <Term> '/' <Factor>
        RULE_TERM_PERCENT                                                                                  = 25, // <Term> ::= <Term> '%' <Factor>
        RULE_TERM                                                                                          = 26, // <Term> ::= <Factor>
        RULE_FACTOR_TIMESTIMES                                                                             = 27, // <Factor> ::= <Factor> '**' <Value>
        RULE_FACTOR                                                                                        = 28, // <Factor> ::= <Value>
        RULE_VALUE_LPAREN_RPAREN                                                                           = 29, // <Value> ::= '(' <Expression> ')'
        RULE_VALUE                                                                                         = 30, // <Value> ::= <ID>
        RULE_VALUE2                                                                                        = 31, // <Value> ::= <Digit>
        RULE_VALUE3                                                                                        = 32, // <Value> ::= <Array>
        RULE_VALUE4                                                                                        = 33, // <Value> ::= <Call_function>
        RULE_DIGIT_DIGIT                                                                                   = 34, // <Digit> ::= Digit
        RULE_IF_STMT_IF_LPAREN_RPAREN_LBRACE_RBRACE                                                        = 35, // <If_stmt> ::= if '(' <cond> ')' '{' <Stmt_list> '}'
        RULE_IF_STMT_IF_LPAREN_RPAREN_LBRACE_RBRACE_ELSE_LBRACE_RBRACE                                     = 36, // <If_stmt> ::= if '(' <cond> ')' '{' <Stmt_list> '}' else '{' <Stmt_list> '}'
        RULE_IF_STMT_IF_LPAREN_RPAREN_LBRACE_RBRACE_ELSE_IF_LPAREN_RPAREN_LBRACE_RBRACE_ELSE_LBRACE_RBRACE = 37, // <If_stmt> ::= if '(' <cond> ')' '{' <Stmt_list> '}' else if '(' <cond> ')' '{' <Stmt_list> '}' else '{' <Stmt_list> '}'
        RULE_COND                                                                                          = 38, // <cond> ::= <Expression> <Op> <Expression>
        RULE_OP_LT                                                                                         = 39, // <Op> ::= '<'
        RULE_OP_LTEQ                                                                                       = 40, // <Op> ::= '<='
        RULE_OP_GT                                                                                         = 41, // <Op> ::= '>'
        RULE_OP_GTEQ                                                                                       = 42, // <Op> ::= '>='
        RULE_OP_EQEQ                                                                                       = 43, // <Op> ::= '=='
        RULE_OP_EXCLAMEQ                                                                                   = 44, // <Op> ::= '!='
        RULE_SWITCH_STMT_SWITCH_LPAREN_RPAREN_LBRACE                                                       = 45, // <Switch_stmt> ::= switch '(' <Expression> ')' '{' <nl Opt> <Case_block> <nl Opt>
        RULE_SWITCH_STMT_SWITCH_LPAREN_RPAREN_LBRACE2                                                      = 46, // <Switch_stmt> ::= switch '(' <cond> ')' '{' <nl Opt> <Case_block> <nl Opt>
        RULE_CASE_BLOCK_CASE_COLON_STOP                                                                    = 47, // <Case_block> ::= <nl Opt> case <Expression> ':' <Stmt_list> stop <Case_block>
        RULE_CASE_BLOCK_CASE_COLON_STOP2                                                                   = 48, // <Case_block> ::= <nl Opt> case <Literal> ':' <Stmt_list> stop <Case_block>
        RULE_CASE_BLOCK_DEFAULT_COLON_STOP                                                                 = 49, // <Case_block> ::= <nl Opt> default ':' <Stmt_list> stop <Case_block>
        RULE_CASE_BLOCK_RBRACE                                                                             = 50, // <Case_block> ::= <nl Opt> '}'
        RULE_LITERAL_STRINGLITERAL                                                                         = 51, // <Literal> ::= StringLiteral
        RULE_FOR_STMT_FOR_LPAREN_SEMI_SEMI_RPAREN_LBRACE_RBRACE                                            = 52, // <For_stmt> ::= for '(' <Variable> ';' <cond> ';' <Step> ')' '{' <Stmt_list> '}'
        RULE_STEP_MINUSMINUS                                                                               = 53, // <Step> ::= '--' <Name>
        RULE_STEP_MINUSMINUS2                                                                              = 54, // <Step> ::= <Name> '--'
        RULE_STEP_PLUSPLUS                                                                                 = 55, // <Step> ::= '++' <Name>
        RULE_STEP_PLUSPLUS2                                                                                = 56, // <Step> ::= <Name> '++'
        RULE_STEP                                                                                          = 57, // <Step> ::= <Assign>
        RULE_WHILE_STMT_WHILE_LPAREN_RPAREN_LBRACE_RBRACE                                                  = 58, // <While_stmt> ::= while '(' <cond> ')' '{' <Stmt_list> '}'
        RULE_ARRAY_LBRACKET_RBRACKET                                                                       = 59, // <Array> ::= '[' <Array_initialization> ']'
        RULE_ARRAY_INITIALIZATION_COMMA                                                                    = 60, // <Array_initialization> ::= <Expression> ',' <Array_initialization>
        RULE_ARRAY_INITIALIZATION                                                                          = 61, // <Array_initialization> ::= <Expression>
        RULE_FUNCTION_FUN_LPAREN_RPAREN_LBRACE_RBRACE                                                      = 62, // <Function> ::= <nl Opt> fun <Name> '(' <Parameter> ')' <nl Opt> '{' <Block_function> '}'
        RULE_FUNCTION_LBRACERBRACE                                                                         = 63, // <Function> ::= <nl Opt> '{}'
        RULE_BLOCK_FUNCTION_RET                                                                            = 64, // <Block_function> ::= <Stmt_list> <nl Opt> ret <Variable>
        RULE_BLOCK_FUNCTION                                                                                = 65, // <Block_function> ::= <Stmt_list>
        RULE_PARAMETER_COMMA                                                                               = 66, // <Parameter> ::= <Variable> ',' <Parameter>
        RULE_PARAMETER_COMMA2                                                                              = 67, // <Parameter> ::= <Array> ',' <Parameter>
        RULE_PARAMETER                                                                                     = 68, // <Parameter> ::= 
        RULE_CALL_FUNCTION_LPAREN_RPAREN                                                                   = 69, // <Call_function> ::= <Name> '(' <Parameter> ')'
        RULE_PRINT_PRINT_LPAREN_RPAREN                                                                     = 70, // <Print> ::= print '(' <Literal> ')'
        RULE_PRINT_PRINT_LPAREN_RPAREN2                                                                    = 71, // <Print> ::= print '(' <Digit> ')'
        RULE_PRINT_PRINT_LPAREN_RPAREN3                                                                    = 72  // <Print> ::= print '(' <Name> ')'
    };

    public class MyParser
    {
        private LALRParser parser;
        ListBox list;

        public MyParser(string filename,ListBox list)
        {
            FileStream stream = new FileStream(filename,
                                               FileMode.Open, 
                                               FileAccess.Read, 
                                               FileShare.Read);
            this.list = list;
            Init(stream);
            stream.Close();
        }

        public MyParser(string baseName, string resourceName)
        {
            byte[] buffer = ResourceUtil.GetByteArrayResource(
                System.Reflection.Assembly.GetExecutingAssembly(),
                baseName,
                resourceName);
            MemoryStream stream = new MemoryStream(buffer);
            Init(stream);
            stream.Close();
        }

        public MyParser(Stream stream)
        {
            Init(stream);
        }

        private void Init(Stream stream)
        {
            CGTReader reader = new CGTReader(stream);
            parser = reader.CreateNewParser();
            parser.TrimReductions = false;
            parser.StoreTokens = LALRParser.StoreTokensMode.NoUserObject;

            parser.OnTokenError += new LALRParser.TokenErrorHandler(TokenErrorEvent);
            parser.OnParseError += new LALRParser.ParseErrorHandler(ParseErrorEvent);
        }

        public void Parse(string source)
        {
            NonterminalToken token = parser.Parse(source);
            if (token != null)
            {
                Object obj = CreateObject(token);
                //todo: Use your object any way you like
            }
        }

        private Object CreateObject(Token token)
        {
            if (token is TerminalToken)
                return CreateObjectFromTerminal((TerminalToken)token);
            else
                return CreateObjectFromNonterminal((NonterminalToken)token);
        }

        private Object CreateObjectFromTerminal(TerminalToken token)
        {
            switch (token.Symbol.Id)
            {
                case (int)SymbolConstants.SYMBOL_EOF :
                //(EOF)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ERROR :
                //(Error)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHITESPACE :
                //Whitespace
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MINUS :
                //'-'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MINUSMINUS :
                //'--'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXCLAMEQ :
                //'!='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PERCENT :
                //'%'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LPAREN :
                //'('
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RPAREN :
                //')'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TIMES :
                //'*'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TIMESTIMES :
                //'**'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMMA :
                //','
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DIV :
                //'/'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COLON :
                //':'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SEMI :
                //';'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LBRACKET :
                //'['
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RBRACKET :
                //']'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LBRACE :
                //'{'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LBRACERBRACE :
                //'{}'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RBRACE :
                //'}'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PLUS :
                //'+'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PLUSPLUS :
                //'++'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LT :
                //'<'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LTEQ :
                //'<='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQ :
                //'='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQEQ :
                //'=='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GT :
                //'>'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GTEQ :
                //'>='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CASE :
                //case
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DEFAULT :
                //default
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DIGIT :
                //Digit
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ELSE :
                //else
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FOR :
                //for
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FUN :
                //fun
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IDENTIFIER :
                //Identifier
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IF :
                //if
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NEWLINE :
                //NewLine
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PRINT :
                //print
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RET :
                //ret
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STOP :
                //stop
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STRINGLITERAL :
                //StringLiteral
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SWITCH :
                //switch
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TYTHON3 :
                //'Tython3'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHILE :
                //while
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ARRAY :
                //<Array>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ARRAY_INITIALIZATION :
                //<Array_initialization>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ASSIGN :
                //<Assign>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BLOCK_FUNCTION :
                //<Block_function>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CALL_FUNCTION :
                //<Call_function>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CASE_BLOCK :
                //<Case_block>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CONCEPT :
                //<Concept>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COND :
                //<cond>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DIGIT2 :
                //<Digit>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXPRESSION :
                //<Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FACTOR :
                //<Factor>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FOR_STMT :
                //<For_stmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FUNCTION :
                //<Function>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ID :
                //<ID>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IF_STMT :
                //<If_stmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LITERAL :
                //<Literal>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NAME :
                //<Name>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NL :
                //<nl>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NLOPT :
                //<nl Opt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OP :
                //<Op>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PARAMETER :
                //<Parameter>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PRINT2 :
                //<Print>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PROGRAM :
                //<Program>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STEP :
                //<Step>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STMT_LIST :
                //<Stmt_list>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SWITCH_STMT :
                //<Switch_stmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TERM :
                //<Term>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_VALUE :
                //<Value>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_VARIABLE :
                //<Variable>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHILE_STMT :
                //<While_stmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

            }
            throw new SymbolException("Unknown symbol");
        }

        public Object CreateObjectFromNonterminal(NonterminalToken token)
        {
            switch (token.Rule.Id)
            {
                case (int)RuleConstants.RULE_NL_NEWLINE :
                //<nl> ::= NewLine <nl>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_NL_NEWLINE2 :
                //<nl> ::= NewLine
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_NLOPT_NEWLINE :
                //<nl Opt> ::= NewLine <nl Opt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_NLOPT :
                //<nl Opt> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PROGRAM_TYTHON3_TYTHON3 :
                //<Program> ::= 'Tython3' <nl Opt> <Stmt_list> 'Tython3' <Function>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STMT_LIST :
                //<Stmt_list> ::= <nl Opt> <Concept> <nl Opt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STMT_LIST2 :
                //<Stmt_list> ::= <nl Opt> <Concept> <nl Opt> <Stmt_list>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CONCEPT :
                //<Concept> ::= <Variable>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CONCEPT2 :
                //<Concept> ::= <If_stmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CONCEPT3 :
                //<Concept> ::= <Switch_stmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CONCEPT4 :
                //<Concept> ::= <For_stmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CONCEPT5 :
                //<Concept> ::= <While_stmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CONCEPT6 :
                //<Concept> ::= <Array>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CONCEPT7 :
                //<Concept> ::= <Call_function>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CONCEPT8 :
                //<Concept> ::= <Print>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VARIABLE :
                //<Variable> ::= <Name>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VARIABLE2 :
                //<Variable> ::= <Assign>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGN_EQ :
                //<Assign> ::= <Name> '=' <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_NAME :
                //<Name> ::= <ID>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ID_IDENTIFIER :
                //<ID> ::= Identifier
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRESSION_PLUS :
                //<Expression> ::= <Expression> '+' <Term>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRESSION_MINUS :
                //<Expression> ::= <Expression> '-' <Term>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRESSION :
                //<Expression> ::= <Term>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TERM_TIMES :
                //<Term> ::= <Term> '*' <Factor>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TERM_DIV :
                //<Term> ::= <Term> '/' <Factor>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TERM_PERCENT :
                //<Term> ::= <Term> '%' <Factor>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TERM :
                //<Term> ::= <Factor>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FACTOR_TIMESTIMES :
                //<Factor> ::= <Factor> '**' <Value>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FACTOR :
                //<Factor> ::= <Value>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VALUE_LPAREN_RPAREN :
                //<Value> ::= '(' <Expression> ')'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VALUE :
                //<Value> ::= <ID>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VALUE2 :
                //<Value> ::= <Digit>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VALUE3 :
                //<Value> ::= <Array>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VALUE4 :
                //<Value> ::= <Call_function>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_DIGIT_DIGIT :
                //<Digit> ::= Digit
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_IF_STMT_IF_LPAREN_RPAREN_LBRACE_RBRACE :
                //<If_stmt> ::= if '(' <cond> ')' '{' <Stmt_list> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_IF_STMT_IF_LPAREN_RPAREN_LBRACE_RBRACE_ELSE_LBRACE_RBRACE :
                //<If_stmt> ::= if '(' <cond> ')' '{' <Stmt_list> '}' else '{' <Stmt_list> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_IF_STMT_IF_LPAREN_RPAREN_LBRACE_RBRACE_ELSE_IF_LPAREN_RPAREN_LBRACE_RBRACE_ELSE_LBRACE_RBRACE :
                //<If_stmt> ::= if '(' <cond> ')' '{' <Stmt_list> '}' else if '(' <cond> ')' '{' <Stmt_list> '}' else '{' <Stmt_list> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COND :
                //<cond> ::= <Expression> <Op> <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OP_LT :
                //<Op> ::= '<'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OP_LTEQ :
                //<Op> ::= '<='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OP_GT :
                //<Op> ::= '>'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OP_GTEQ :
                //<Op> ::= '>='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OP_EQEQ :
                //<Op> ::= '=='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OP_EXCLAMEQ :
                //<Op> ::= '!='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SWITCH_STMT_SWITCH_LPAREN_RPAREN_LBRACE :
                //<Switch_stmt> ::= switch '(' <Expression> ')' '{' <nl Opt> <Case_block> <nl Opt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SWITCH_STMT_SWITCH_LPAREN_RPAREN_LBRACE2 :
                //<Switch_stmt> ::= switch '(' <cond> ')' '{' <nl Opt> <Case_block> <nl Opt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CASE_BLOCK_CASE_COLON_STOP :
                //<Case_block> ::= <nl Opt> case <Expression> ':' <Stmt_list> stop <Case_block>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CASE_BLOCK_CASE_COLON_STOP2 :
                //<Case_block> ::= <nl Opt> case <Literal> ':' <Stmt_list> stop <Case_block>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CASE_BLOCK_DEFAULT_COLON_STOP :
                //<Case_block> ::= <nl Opt> default ':' <Stmt_list> stop <Case_block>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CASE_BLOCK_RBRACE :
                //<Case_block> ::= <nl Opt> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LITERAL_STRINGLITERAL :
                //<Literal> ::= StringLiteral
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FOR_STMT_FOR_LPAREN_SEMI_SEMI_RPAREN_LBRACE_RBRACE :
                //<For_stmt> ::= for '(' <Variable> ';' <cond> ';' <Step> ')' '{' <Stmt_list> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STEP_MINUSMINUS :
                //<Step> ::= '--' <Name>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STEP_MINUSMINUS2 :
                //<Step> ::= <Name> '--'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STEP_PLUSPLUS :
                //<Step> ::= '++' <Name>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STEP_PLUSPLUS2 :
                //<Step> ::= <Name> '++'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STEP :
                //<Step> ::= <Assign>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_WHILE_STMT_WHILE_LPAREN_RPAREN_LBRACE_RBRACE :
                //<While_stmt> ::= while '(' <cond> ')' '{' <Stmt_list> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ARRAY_LBRACKET_RBRACKET :
                //<Array> ::= '[' <Array_initialization> ']'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ARRAY_INITIALIZATION_COMMA :
                //<Array_initialization> ::= <Expression> ',' <Array_initialization>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ARRAY_INITIALIZATION :
                //<Array_initialization> ::= <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FUNCTION_FUN_LPAREN_RPAREN_LBRACE_RBRACE :
                //<Function> ::= <nl Opt> fun <Name> '(' <Parameter> ')' <nl Opt> '{' <Block_function> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FUNCTION_LBRACERBRACE :
                //<Function> ::= <nl Opt> '{}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BLOCK_FUNCTION_RET :
                //<Block_function> ::= <Stmt_list> <nl Opt> ret <Variable>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BLOCK_FUNCTION :
                //<Block_function> ::= <Stmt_list>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PARAMETER_COMMA :
                //<Parameter> ::= <Variable> ',' <Parameter>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PARAMETER_COMMA2 :
                //<Parameter> ::= <Array> ',' <Parameter>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PARAMETER :
                //<Parameter> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CALL_FUNCTION_LPAREN_RPAREN :
                //<Call_function> ::= <Name> '(' <Parameter> ')'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PRINT_PRINT_LPAREN_RPAREN :
                //<Print> ::= print '(' <Literal> ')'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PRINT_PRINT_LPAREN_RPAREN2 :
                //<Print> ::= print '(' <Digit> ')'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PRINT_PRINT_LPAREN_RPAREN3 :
                //<Print> ::= print '(' <Name> ')'
                //todo: Create a new object using the stored tokens.
                return null;

            }
            throw new RuleException("Unknown rule");
        }

        private void TokenErrorEvent(LALRParser parser, TokenErrorEventArgs args)
        {
            string message = "Token error with input: '"+args.Token.ToString()+"'";
            //todo: Report message to UI?
        }

        private void ParseErrorEvent(LALRParser parser, ParseErrorEventArgs args)
        {
            string message = "Parse error caused by token: '"+args.UnexpectedToken.ToString()+"in line"+args.UnexpectedToken.Location.LineNr;
            list.Items.Add(message);
            //todo: Report message to UI?
            String message2 = "ExpectedToken" + args.ExpectedTokens.ToString();
            list.Items.Add(message2);
        }

    }
}
