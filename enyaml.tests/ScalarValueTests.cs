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
        public void ParseUnQuotedString()
        {
            var result = Yaml.Parse("line 1");
            Assert.AreEqual("line 1", result);
        }
        [Test]
        [Ignore]
        public void ParseInt()
        {
            var result = Yaml.Parse("42");
            Assert.AreEqual(42, result);
        }
        [Test]
        [Ignore]
        public void ParseDouble()
        {
            var result = Yaml.Parse("3.1415");
            Assert.AreEqual(3.1415, result);
        }
    }
}
