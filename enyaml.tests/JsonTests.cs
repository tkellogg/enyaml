using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace enyaml.tests
{
    /// <summary>
    /// Tests regarding JSON compatibility. YAML 1.2 is supposed to be a complete supeset of JSON, so these tests
    /// verify that that part of the spec isn't broken
    /// </summary>
    [TestFixture]
    public class JsonTests
    {
        #region Structural tests (regarding general structure, not whitespace nitpicking)
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
        public void ListOfStringAndInt()
        {
            var result = Yaml.Parse("[\"1\",2]");
            Assert.That(result, Is.EquivalentTo(new object[] { "1", 2 }));
        }
        [Test]
        public void ListOfListAndInt()
        {
            var result = (List<object>)Yaml.Parse("[[1,2],3]");
            Assert.AreEqual(2, result.Count);
            Assert.That(result[0], Is.EquivalentTo(new[] { 1, 2 }));
            Assert.AreEqual(3, result[1]);
        }
        [Test]
        public void ObjectWithOneScalar()
        {
            var result = (IDictionary<string, object>)Yaml.Parse("{\"key\":\"value\"}");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("value", result["key"]);
        }
        [Test]
        public void ObjectWithTwoScalars()
        {
            var result = (IDictionary<string, object>)Yaml.Parse("{\"key\":\"value\", \"key2\":2}");
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("value", result["key"]);
            Assert.AreEqual(2, result["key2"]);
        }
        [Test]
        public void ObjectWithObjectListAndScalar()
        {
            var result = (IDictionary<string, object>)Yaml.Parse("{\"key\":\"value\", \"list\":[1,2],\"obj\":{\"key\":3}}");
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("value", result["key"]);
            var list = (List<object>)result["list"];
            Assert.That(list, Is.EquivalentTo(new[] { 1, 2 }));
            var obj = (IDictionary<string, object>)result["obj"];
            Assert.AreEqual(1, obj.Count);
            Assert.AreEqual(3, obj["key"]);
        }
        #endregion

        #region Nitpicky tests
        [Test]
        public void ListWithSpaces()
        {
            var result = Yaml.Parse("[ 1 ,      2   ]");
            Assert.That(result, Is.EquivalentTo(new[] { 1, 2 }));
        }
        [Test]
        public void ListWithTabs()
        {
            var result = Yaml.Parse("[\t1\t,\t\t\t\t\t2\t\t\t]");
            Assert.That(result, Is.EquivalentTo(new[] { 1, 2 }));
        }
        [Test]
        public void ListWithNewlines()
        {
            var result = Yaml.Parse("[\r\n  1\n,\r\n   2\n]");
            Assert.That(result, Is.EquivalentTo(new[] { 1, 2 }));
        }
        [Test]
        public void ObjectWithSpaces()
        {
            var result = (IDictionary<string, object>)Yaml.Parse("{  \"key\"  :  \"value\"  ,  \"key2\"  :  2  }");
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("value", result["key"]);
            Assert.AreEqual(2, result["key2"]);
        }
        [Test]
        public void ObjectWithTabs()
        {
            var result = (IDictionary<string, object>)Yaml.Parse("{\t\t\"key\"\t\t:\t\t\"value\"\t\t,\t\t\"key2\"\t\t:\t\t2\t\t}");
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("value", result["key"]);
            Assert.AreEqual(2, result["key2"]);
        }
        [Test]
        public void ObjectWithNewlines()
        {
            var result = (IDictionary<string, object>)Yaml.Parse("{\r\n  \"key\" \r\n    :\r\n  \"value\"\n ,  \"key2\"\n  :  2  }");
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("value", result["key"]);
            Assert.AreEqual(2, result["key2"]);
        }
        #endregion
    }
}
