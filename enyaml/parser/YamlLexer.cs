using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;

namespace enyaml.parser
{
    public partial class YamlLexer
    {
        ///<summary>Tracks the current indentation level<summary>
        protected int Indentation { get; set; }

        /// <summary>Tracks how many spaces an indent is</summary>
        internal int indentSize = 0;
	
        internal int GetIndentationSize(string spaces)
        {
            int ret = 0;
            if (indentSize == 0 && spaces.Length > 0)
            {
                // This is the first time we're looking for indents
                indentSize = spaces.Length;
                ret = 1;
            }
            else if (indentSize > 0)
            {
                if (spaces.Length % indentSize != 0)
                    throw new FailedPredicateException(input, "Indentation Size Check", string.Format("Expecting indent size of {0} but was {1}", indentSize, spaces.Length % indentSize));
                ret = spaces.Length / indentSize;
            }
            return ret;
        }

        private void EmitIndentationTokens(string text)
        {
            try
            {
                int size = GetIndentationSize(text);
                if (size == Indentation + 1)
                    Emit(new CommonToken(INDENT));
                else if (size < Indentation)
                    Emit(new CommonToken(DEDENT));
            }
            catch (FailedPredicateException)
            {
                Skip();
            }
        }
    }
}
