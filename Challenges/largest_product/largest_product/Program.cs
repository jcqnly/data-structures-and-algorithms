using System;

namespace largest_product
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[][] 
            { 
                new int[]{ 1, 3, 19 }, 
                new int[]{ 5, 7, 23 }, 
                new int[]{ 11, 13, 17 }
            };

            int[,] numbers = new int[,]
                {
                    { 1, 2, 1 },
                    { 2, 4, 2 },
                    { 3, 6, 8 },
                    { 7, 8, 1 }
                };
            //will attempt one day
            //LargestProduct(numbers);
            Console.Read();
        }

        static void LargestProduct(int[][] matrix)
        {
            for (var i = 0; i < givenArray.Length - 1; i++)
            {
                Console.WriteLine(givenArray[i, i]);
            }
        }
    }
}
