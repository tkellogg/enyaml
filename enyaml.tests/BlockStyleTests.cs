using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace enyaml.tests
{
    [TestFixture]
    public class BlockStyleTests
    {
        [Test]
        public void ListOfQuotedStrings()
        {
            var txt = "- \"line 1\"\n-\"line 2\"\n";
            var result = Yaml.Parse(txt);
            var list = (List<object>)result;
            Assert.That(list, Is.EquivalentTo(new[] { "line 1", "line 2" }));
        }
        [Test]
        public void ListOfUnQuotedStrings()
        {
            var txt = "- line 1\n-line 2\n";
            var result = Yaml.Parse(txt);
            var list = (List<object>)result;
            Assert.That(list, Is.EquivalentTo(new[] { "line 1", "line 2" }));
        }
        [Test]
        public void SingleLevelMap()
        {
            var txt = "one: 1\ntwo: 2\nthree: 3\n";
            var result = Yaml.Parse(txt);
            var map = (IDictionary<string, object>)result;
            Assert.AreEqual(3, map.Count);
            Assert.AreEqual(1, map["one"]);
            Assert.AreEqual(2, map["two"]);
            Assert.AreEqual(3, map["three"]);
        }
        [Test]
        public void MapWithMap()
        {
            var txt = "one:\n  two: 2\n  three: 3\n";
            var result = Yaml.Parse(txt);
            var map = (IDictionary<string, object>)result;
            Assert.AreEqual(1, map.Count);
            var submap = (IDictionary<string, object>)map["one"];
            Assert.AreEqual(2, submap.Count);
            Assert.AreEqual(2, submap["two"]);
            Assert.AreEqual(3, submap["three"]);
        }
        [Test]
        public void MapWithList()
        {
            var txt = "one:\n  - 2\n  - 3\n";
            var result = Yaml.Parse(txt);
            var map = (IDictionary<string, object>)result;
            Assert.AreEqual(1, map.Count);
            var sublist = (IList<object>)map["one"];
            Assert.AreEqual(2, sublist.Count);
            Assert.AreEqual(2, sublist[0]);
            Assert.AreEqual(3, sublist[1]);
        }
        [Test]
        public void ListWithMap()
        {
            var txt = "-\n  two: 2\n  three: 3\n";
            var result = Yaml.Parse(txt);
            var list = (IList<object>)result;
            Assert.AreEqual(1, list.Count);
            var map = (IDictionary<string, object>)list[0];
            Assert.AreEqual(2, map.Count);
            Assert.AreEqual(2, map["two"]);
            Assert.AreEqual(3, map["three"]);
        }
        [Test]
        public void ListWithList()
        {
            var txt = "-\n  - 2\n  - 3\n";
            var result = Yaml.Parse(txt);
            var list = (IList<object>)result;
            Assert.AreEqual(1, list.Count);
            var sublist = (IList<object>)list[0];
            Assert.AreEqual(2, sublist.Count);
            Assert.AreEqual(2, sublist[0]);
            Assert.AreEqual(3, sublist[1]);
        }
        [Test]
        public void ListWithList_extended()
        {
            var txt = "-\n  - 2\n  - 3\n- \n  - 4\n";
            var result = Yaml.Parse(txt);
            var list = (IList<object>)result;
            Assert.AreEqual(2, list.Count);
            var sublist = (IList<object>)list[0];
            Assert.AreEqual(2, sublist.Count);
            Assert.AreEqual(2, sublist[0]);
            Assert.AreEqual(3, sublist[1]);
            sublist = (IList<object>)list[1];
            Assert.AreEqual(1, sublist.Count);
            Assert.AreEqual(4, sublist[0]);
        }
        [Test]
        public void ListsWith2LevelIndentationdrop()
        {
            var txt = "-\n  -\n    - 1\n- 2\n";
            var result = Yaml.Parse(txt);
            var list = (IList<object>)result;
            Assert.AreEqual(2, list.Count);
            var sublist = (IList<object>)list[0];
            Assert.AreEqual(1, sublist.Count);
            var subsublist = (IList<object>)sublist[0];
            Assert.AreEqual(1, subsublist.Count);
            Assert.AreEqual(1, subsublist[0]);
            Assert.AreEqual(2, list[0]);
        }
    }
}
