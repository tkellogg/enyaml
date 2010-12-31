using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Antlr.Runtime.Tree;

namespace enyaml.parser
{
    public partial class YamlTree
    {

        private string ExtractString(CommonTree token)
        {
            var text = token.Text;
            if (text.StartsWith("\""))
                text = text.Substring(1, text.Length - 2);
            return Regex.Replace(text, "\\\\([btnfr'\"\\\\])", x =>
            {
                switch (x.Groups[1].Value)
                {
                    case "b": return "\b";
                    case "t": return "\t";
                    case "n": return "\n";
                    case "f": return "\f";
                    case "r": return "\r";
                    case "'": return "'";
                    case "\"": return "\"";
                    case "\\": return "\\";
                    default: throw new InvalidOperationException("Can't ever get here");
                }
            });
        }
	
    }
}
