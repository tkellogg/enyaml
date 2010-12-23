using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using enyaml;

namespace enyaml.tests
{
    [TestFixture(Description="Testing scalars alone - no maps")]
    class ScalarValueTests
    {
        [Test]
        public void ParseQuotedString()
        {
            var result = Yaml.Parse("\"line 1\"");
            Assert.AreEqual("line 1", result);
        }
        [Test]
        public void ParseQuotedString_withEscapedNewline()
        {
            var result = Yaml.Parse("\"line\\n 1\"");
            Assert.AreEqual("line\n 1", result);
        }
        [Test]
        public void ParseQuotedString_withEscapedReturn()
        {
            var result = Yaml.Parse("\"line\\r 1\"");
            Assert.AreEqual("line\r 1", result);
        }
        [Test]
        public void ParseQuotedString_withEscapedTab()
        {
            var result = Yaml.Parse("\"line\\t 1\"");
            Assert.AreEqual("line\t 1", result);
        }
        [Test]
        public void ParseQuotedString_withEscapedBackslash()
        {
            var result = Yaml.Parse("\"line\\\\ 1\"");
            Assert.AreEqual("line\\ 1", result);
        }
        [Test]
        public void ParseInt()
        {
            var result = Yaml.Parse("42");
            Assert.AreEqual(42, result);
            Assert.AreEqual(typeof(int), result.GetType());
        }
        [Test]
        public void ParseNegativeInt()
        {
            var result = Yaml.Parse("-42");
            Assert.AreEqual(-42, result);
            Assert.AreEqual(typeof(int), result.GetType());
        }
        [Test]
        public void ParseZero()
        {
            var result = Yaml.Parse("0");
            Assert.AreEqual(0, result);
            Assert.AreEqual(typeof(int), result.GetType());
        }
        [Test]
        public void ParseDouble()
        {
            var result = Yaml.Parse("3.1415");
            Assert.AreEqual(3.1415, result);
        }
        [Test]
        public void ParseNegativeDouble()
        {
            var result = Yaml.Parse("-3.1415");
            Assert.AreEqual(-3.1415, result);
        }
        [Test]
        public void ParseNegativeExponent()
        {
            var result = Yaml.Parse("-3.1415E12");
            Assert.AreEqual(-3.1415e12, result);
        }
        [Test]
        public void ParseExponent()
        {
            var result = Yaml.Parse("3.1415e12");
            Assert.AreEqual(3.1415e12, result);
        }
        [Test]
        public void ParseBigExponent()
        {
            var result = Yaml.Parse("3.1415e+12");
            Assert.AreEqual(3.1415e12, result);
        }
        [Test]
        public void ParseSmallExponent()
        {
            var result = Yaml.Parse("3.1415e-12");
            Assert.AreEqual(3.1415e-12, result);
        }
        [Test]
        public void ParseZeroDouble()
        {
            var result = Yaml.Parse("0.0");
            Assert.AreEqual(0.0, result);
            Assert.AreEqual(typeof(double), result.GetType());
        }
        [Test]
        public void ParseTrue()
        {
            var result = Yaml.Parse("true");
            Assert.AreEqual(true, result);
        }
        [Test]
        public void ParseFalse()
        {
            var result = Yaml.Parse("false");
            Assert.AreEqual(false, result);
        }
        [Test]
        public void ParseNull()
        {
            var result = Yaml.Parse("null");
            Assert.AreEqual(null, result);
        }
    }
}
