using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using enyaml;

namespace enyaml.tests
{
    [TestFixture]
    class YamlTests
    {
        [Test]
        public void ParseString()
        {
            var result = Yaml.Parse("\"line 1\"");
            Assert.AreEqual("line 1", result);
        }
        [Test]
        public void ParseInt()
        {
            var result = Yaml.Parse("42");
            Assert.AreEqual(42, result);
        }
        [Test]
        public void ParseDouble()
        {
            var result = Yaml.Parse("3.1415");
            Assert.AreEqual(3.1415, result);
        }
    }
}
