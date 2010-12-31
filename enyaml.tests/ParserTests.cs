using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Antlr.Runtime;
using enyaml.parser;
using Antlr.Runtime.Tree;

namespace enyaml.tests
{
    /// <summary>
    /// These tests are specifically just for checing tokens between the parser and
    /// tree parser. Sometimes some weird things happen and the high-level unit tests
    /// are more integration-ish
    /// </summary>
    [TestFixture]
    public class ParserTests
    {
        private CommonTree GetParser(string content)
        {
            var lexer = new YamlLexer(new ANTLRStringStream(content));
            var tokens = new CommonTokenStream(lexer);
            return (CommonTree)new YamlParser(tokens).value().Tree;
        }

        [Test]
        public void FlowList()
        {
            string content = "[ 1, 2, 3]";
            var p = GetParser(content);
            Assert.AreEqual(YamlParser.LIST, p.Type);
            Assert.AreEqual(3, p.ChildCount);
            Assert.AreEqual(YamlParser.INTEGER, ((CommonTree)p.Children[1]).Type);
            Assert.AreEqual("2", (((CommonTree)p.Children[1]).Children[0]).ToString());
        }
        [Test]
        public void BlockList()
        {
            string content = "- 1\n- 2\n- 3";
            var p = GetParser(content);
            Assert.AreEqual(YamlParser.LIST, p.Type);
            Assert.AreEqual(3, p.ChildCount);
            Assert.AreEqual(YamlParser.INTEGER, ((CommonTree)p.Children[1]).Type);
            Assert.AreEqual("2", (((CommonTree)p.Children[1]).Children[0]).ToString());
        }
    }
}
