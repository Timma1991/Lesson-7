using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoder
{
    interface ICoder
    {
        string Encode(string value);

        string Decode(string value);
                
    }
}
