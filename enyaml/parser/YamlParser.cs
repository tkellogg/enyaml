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
    }
}
