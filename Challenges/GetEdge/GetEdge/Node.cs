using System;
using System.Collections.Generic;
using System.Text;

namespace GetEdge
{
    public class Node
    {
        public bool Visited { get; set; }
        public string CityName { get; set; }
        public Dictionary<Node, decimal> Edges { get; set; }

        /// <summary>
        /// Grabs the info for every Node instantiated with a value for value
        /// and a new list of Edges
        /// </summary>
        /// <param name="value"></param>
        public Node(string cityName)
        {
            CityName = cityName;
            Edges = new Dictionary<Node, decimal>();
        }
    }
}
