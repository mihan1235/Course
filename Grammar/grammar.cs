using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Grammar
{
    public class FunctionGrammar
    {
        AntlrInputStream input = null;
        functionLexer lexer;
        CommonTokenStream tokens;
        functionParser parser;

        string input_str;

        public string Input
        {
            private get
            {
                return input_str;
            }
            set
            {
                input_str = value;
                // В качестве входного потока символов устанавливаем полученную строку
                input = new AntlrInputStream(input_str);
                // Настраиваем лексер на этот поток
                lexer = new functionLexer(input);
                // Создаем поток токенов на основе лексера
                tokens = new CommonTokenStream(lexer);
                // Создаем парсер
                parser = new functionParser(tokens);
            }
        }

        public double Func(double x)
        {
            if (input == null)
            {
                throw (new ArgumentNullException("input"));
            }
            // И запускаем первое правило грамматики!!!
            parser.Var = x;
            parser.function();
            return parser.Ans;
        }
    }
}
