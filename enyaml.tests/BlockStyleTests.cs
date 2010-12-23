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
            var txt = "- \"line 1\"\n-\"line 2\"";
            var result = Yaml.Parse(txt);
            var list = (List<object>)result;
            Assert.That(list, Is.EquivalentTo(new[] { "line 1", "line 2" }));
        }
    }
}
