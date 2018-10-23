using System;

namespace DetectCapital
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Detect Capital");
			string string1 = "C"; //true
			string string2 = "c"; //true
			string string3 = "Dot Net Rocks!"; //true
			string string4 = ".NET"; //true
			string string5 = "BeE"; //false

			Console.WriteLine($"{DetectCap(string1)}");
			Console.WriteLine($"{DetectCap(string2)}");
			Console.WriteLine($"{DetectCap(string3)}");
			Console.WriteLine($"{DetectCap(string4)}");
			Console.WriteLine($"{DetectCap(string5)}");
		}

		public static bool DetectCap(string input)
		{

			return true;
		}
	}
}
