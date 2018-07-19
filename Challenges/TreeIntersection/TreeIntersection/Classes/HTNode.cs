using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersection
{
    public class HTNode
    {
        public HTNode Next { get; set; }
        public string Key { get; set; }
        public int Value { get; set; }

        public HTNode(string key, int value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
