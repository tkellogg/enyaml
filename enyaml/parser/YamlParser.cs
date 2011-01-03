using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace enyaml.parser
{
    public partial class YamlParser
    {
        /// <summary>
        /// The number of blocks deep that we have parsed into
        /// </summary>
        public int BlockLevel { get; protected set; }

        protected int flowLvl = 0;
        protected bool IsInFlow { get { return flowLvl > 0; } }

        /// <summary>
        /// A syntactic predicate that tests if the last token is "true" or "false"
        /// </summary>
        /// <returns></returns>
        protected bool IsBooleanToken()
        {
            if (IsReservedIdentifier("true") || IsReservedIdentifier("false"))
            {
                input.LT(1).Type = BOOL;
                return true;
            }
            else if (input.LA(1) == BOOL)
                return true;
            else return false;
        }

        private bool IsReservedIdentifier(string identifier)
        {
            return input.LA(1) == UnQuotedString && input.LT(1).Text == identifier;
        }
    }
}
