using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOanimalShelterQueue
{
    public class Node
    {
        //establish the properties of the node
        public string AnimalType { get; set; }
        public Node Next { get; set; }
        
        //requirements for the instantiation of a node
        public Node(string animalType)
        {
            AnimalType = animalType;
            Next = null;
        }
    }
}
