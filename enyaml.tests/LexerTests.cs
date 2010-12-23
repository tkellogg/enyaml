using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using enyaml.parser;

namespace enyaml.tests
{
    [TestFixture]
    public class LexerTests
    {

        #region GetIndentationSize
        [Test]
        public void GetIndentationSize_BlankString()
        {
            var l = new YamlLexer();
            int actual = l.GetIndentationSize("");
            Assert.AreEqual(0, actual);
        }
        [Test]
        public void GetIndentationSize_Spaces1Then2()
        {
            var l = new YamlLexer();
            int actual = l.GetIndentationSize(" ");
            Assert.AreEqual(1, actual);
            actual = l.GetIndentationSize("  ");
            Assert.AreEqual(2, actual);
        }
        [Test]
        public void GetIndentationSize_Spaces3Then6()
        {
            var l = new YamlLexer();
            int actual = l.GetIndentationSize("   ");
            Assert.AreEqual(1, actual);
            actual = l.GetIndentationSize("      ");
            Assert.AreEqual(2, actual);
        }
        [Test]
        public void GetIndentationSize_Spaces1Then0()
        {
            var l = new YamlLexer();
            int actual = l.GetIndentationSize(" ");
            Assert.AreEqual(1, actual);
            actual = l.GetIndentationSize("");
            Assert.AreEqual(0, actual);
        }
        [Test]
        public void GetIndentationSize_Spaces1Then1()
        {
            var l = new YamlLexer();
            int actual = l.GetIndentationSize(" ");
            Assert.AreEqual(1, actual);
            actual = l.GetIndentationSize(" ");
            Assert.AreEqual(1, actual);
        }
        [Test]
        public void GetIndentationSize_Spaces1Then2Then1()
        {
            var l = new YamlLexer();
            int actual = l.GetIndentationSize(" ");
            Assert.AreEqual(1, actual);
            actual = l.GetIndentationSize("  ");
            Assert.AreEqual(2, actual);
            actual = l.GetIndentationSize(" ");
            Assert.AreEqual(1, actual);
        }
        [Test]
        public void GetIndentationSize_Spaces1Then2Then0()
        {
            var l = new YamlLexer();
            int actual = l.GetIndentationSize(" ");
            Assert.AreEqual(1, actual);
            actual = l.GetIndentationSize("  ");
            Assert.AreEqual(2, actual);
            actual = l.GetIndentationSize("");
            Assert.AreEqual(0, actual);
        }
#endregion
    }
}
