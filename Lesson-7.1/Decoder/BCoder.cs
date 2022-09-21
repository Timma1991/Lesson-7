using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoder
{
    internal class BCoder : ICoder
    {
        private readonly Dictionary<char, Tuple<int, int>> _letters = new Dictionary<char, Tuple<int, int>>();//  символ, начальный диапазон, конечный 

        private readonly char[]? _inputCharArray;

        private const int _rAlphabetLength = 32;
        private const int _eAlphabetLength = 26;
        

        public string Encode(string value)
        {
            for (int i = 0; i < _inputCharArray.Length; i++)
            {
                if (_letters.ContainsKey(_inputCharArray[i]))
                {
                    var el = _letters[_inputCharArray[i]];
                    _inputCharArray[i] = (char)(el.Item2 - (_inputCharArray[i] - el.Item1));
                }
                else
                {
                    _inputCharArray[i] = _inputCharArray[i];
                }
            }
            return string.Concat(_inputCharArray);
        }
        public string Decode(string value)
        {

            for (int i = 0; i < _inputCharArray.Length; i++)
            {
                if (_letters.ContainsKey(_inputCharArray[i]))
                {
                    var el = _letters[_inputCharArray[i]];
                    _inputCharArray[i] = (char)(el.Item2 - (_inputCharArray[i] - el.Item1));
                }
                else
                {
                    _inputCharArray[i] = _inputCharArray[i];
                }

            }
            return string.Concat(_inputCharArray);
        }
    }
}
