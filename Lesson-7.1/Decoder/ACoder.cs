using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoder
{
    internal class ACoder : ICoder
    {
        public string Decode(string value)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char ch in value)
            {
                builder.Append((char)(ch - 1));
            }
            return builder.ToString();
        }

        public string Encode(string value)
        {
            StringBuilder builder = new StringBuilder();
            foreach(char ch in value)
            {
                builder.Append((char)(ch + 1));
            }
            return builder.ToString();
        }
    }
}
