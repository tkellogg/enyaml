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
            var stream = new CommonTreeNodeStream(parser.value().Tree);
            stream.TokenStream = tokens;
            var tree = new YamlTree(stream);
            return tree.value();
        }

    }
}
