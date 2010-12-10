using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using enyaml.parser;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace enyaml
{
    public class Yaml
    {

        internal static object Parse(string content)
        {
            var lexer = new YamlLexer(new ANTLRStringStream(content));
            var tokens = new CommonTokenStream(lexer);
            var parser = new YamlParser(tokens);
            var stream = new CommonTreeNodeStream(parser.quoted_string().Tree);
            stream.TokenStream = tokens;
            var tree = new YamlTree(stream);
            return tree.value();
        }

        public static Node Parse(StreamReader stream)
        {
            StringBuilder token = new StringBuilder();
            while (!stream.EndOfStream)
            {
            }
            return null;
        }
    }
}
