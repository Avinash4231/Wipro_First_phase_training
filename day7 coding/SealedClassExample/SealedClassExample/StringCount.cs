using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    static class StringCount
    {
        public static int GetWordCouted(this string inputstring)
        {
            if (!string.IsNullOrEmpty(inputstring))
            {
                string[] words = inputstring.Split(' ');
                return words.Count();
            }
            else
            {
                return 0;
            }
        }
    }
}
