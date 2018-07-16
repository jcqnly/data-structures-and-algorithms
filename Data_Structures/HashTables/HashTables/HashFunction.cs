using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{
    public class HashFunction
    {
        public int ConvertWord(string word)
        {
            int total = 0;
            foreach (char c in word) total += c;
            return total;
        }
    }
}
