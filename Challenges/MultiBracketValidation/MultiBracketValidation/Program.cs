using System;

namespace MultiBracketValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string stringToTest = "{}";//output true
            string stringToTest2 = "[({}]";//output false
            string stringToTest3 = "()[[Extra Characters]]";//output true
            string stringToTest4 = "(](";//output false
            string stringToTest5 = "";//output false

            Console.WriteLine(ValidateBracket(stringToTest));
            Console.WriteLine(ValidateBracket(stringToTest2));
            Console.WriteLine(ValidateBracket(stringToTest3));
            Console.WriteLine(ValidateBracket(stringToTest4));
            Console.WriteLine(ValidateBracket(stringToTest5));
        }

        /// <summary>
        /// Validate that the brackets a given string is balanced
        /// </summary>
        /// <param name="stringToTest"></param>
        /// <returns></returns>
        public static bool ValidateBracket(string stringToTest)
        {
            //convert the strings so that each character in the string
            string leftBrackets = "({[";
            //is now separated into chars and is in an array of chars
            char[] leftBracketChars = leftBrackets.ToCharArray();

            string rightBrackets = ")}]";
            char[] rightBracketChars = rightBrackets.ToCharArray();

            //convert the given string so that each of its characters
            //is now separated into chars and is in an array of chars
            char[] charToTest = stringToTest.ToCharArray();

            int counter = 0, counter2 = 0, counter3;

            for (int i = 0; i < charToTest.Length; i++)
            {
                for (int j = 0; j < leftBracketChars.Length; j++)
                {   //if any chars at the index in the given string matches
                    //either something in the left or right brackets
                    if (charToTest[i] == leftBracketChars[j]) counter++;
                    //increase their respective counters
                    if (charToTest[i] == rightBracketChars[j]) counter2++;
                }
            }
            counter3 = counter + counter2;
            //this means there were no brackets, so evaluate to false;
            if (counter3 == 0) return false;
            
            //since there are 2 brackets in a pair and both are counted,
            //then they're balanced if both exist
            if (counter3 % 2 == 0)
            {   //counter3 should then be even and return true
                return true;
            }
            return false;
        }
    }
}
