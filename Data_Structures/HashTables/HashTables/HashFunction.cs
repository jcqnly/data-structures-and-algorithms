using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{
    public class HashFunction
    {
        /// <summary>
        /// Loop through given word and add its ASCII value to
        /// a running total
        /// </summary>
        /// <param name="word"></param>
        /// <returns>ASCII value of word</returns>
        public int ConvertWord(string word)
        {
            int total = 0;
            foreach (char c in word) total += c;
            return total;
        }
    }
}
