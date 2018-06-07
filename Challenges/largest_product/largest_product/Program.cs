using System;

namespace largest_product
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] givenArray = new int[,] { { 1, 2, 1 }, { 2, 4, 2 }, { 3, 6, 8 }, { 7, 8, 1 } };

            AdjacentProduct(givenArray);
            Console.Read();
        }

        static void AdjacentProduct(int[,] givenArray)
        {
            for (var i = 0; i < givenArray.Length - 1; i++)
            {
                Console.WriteLine(givenArray[i, i]);
            }
        }
    }
}
