using System;

namespace LeftJoin
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TryLeftJoin();
            Console.ReadLine();
        }

        public static void TryLeftJoin()
        {
            //instantiate new Hashtable ht1 and add contents
            HashTable ht1 = new HashTable();
            ht1.Add("fond","enamored");
            ht1.Add("wrath", "anger");
            ht1.Add("diligent", "employed");
            ht1.Add("outfit", "garb");
            ht1.Add("guide", "usher");

            //instantiate new Hashtable ht2 and add contents
            HashTable ht2 = new HashTable();
            ht2.Add("fond", "averse");
            ht2.Add("wrath", "delight");
            ht2.Add("diligent", "idle");
            ht2.Add("guide", "follow");
            ht2.Add("flow", "jam");

            //pass the 2 hashtables to the method to left join them
            HashTable ht3 = ht1.LeftJoinHashTable(ht1, ht2);

            //log to the view to prove it was returned
            for (int i = 0; i < ht3.HashArray.Length; i++)
            {
                if (ht3.HashArray[i] != null)
                {
                    Console.WriteLine($"{ht3.HashArray[i].Key} : {ht3.HashArray[i].Value}");
                    if (ht3.HashArray[i].Next != null)
                    {   //checks if there is another node at that key
                        //if there is another node, output that
                        //this means that there was another value for that key on the 2nd table
                        Console.WriteLine($"{ht3.HashArray[i].Next.Value}");
                    }
                }
            }
        }
    }
}
