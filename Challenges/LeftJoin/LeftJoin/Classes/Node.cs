using System;
using System.Collections.Generic;
using System.Text;

namespace LeftJoin
{
    public class Node
    {
        public Node Next { get; set; }
        //Key can be anything, but we'll use a string for this implemenation
        public string Key { get; set; }
        public string Value { get; set; }

        public Node(string key, string value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
