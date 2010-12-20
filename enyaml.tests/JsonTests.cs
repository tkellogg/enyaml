using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace enyaml.tests
{
    [TestFixture]
    public class JsonTests
    {
        [Test]
        public void ListOfOneInt()
        {
            var result = Yaml.Parse("[1]");
            Assert.That(result, Is.EquivalentTo(new[] { 1 }));
        }
        [Test]
        public void ListOfOneString()
        {
            var result = Yaml.Parse("[\"1\"]");
            Assert.That(result, Is.EquivalentTo(new[] { "1" }));
        }
        [Test]
        public void ListOfTwoInts()
        {
            var result = Yaml.Parse("[1,2]");
            Assert.That(result, Is.EquivalentTo(new[] { 1, 2 }));
        }
        [Test]
        public void ObjectWithOneScalar()
        {
            var result = (SortedDictionary<string, object>)Yaml.Parse("{\"key\":\"value\"}");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("value", result["key"]);
        }
        [Test]
        public void ObjectWithTwoScalars()
        {
            var result = (SortedDictionary<string, object>)Yaml.Parse("{\"key\":\"value\", \"key2\":2}");
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("value", result["key"]);
            Assert.AreEqual(2, result["key2"]);
        }
    }
}
