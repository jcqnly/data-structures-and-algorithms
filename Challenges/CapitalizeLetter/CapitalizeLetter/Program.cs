using System;

namespace CapitalizeLetter
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string stringToCapitalize = "apple @pple aPPLES dog";
			CapitalizeLetterInString(stringToCapitalize);
		}

		/// <summary>
		/// Brute force way to capitalize the first letter of a word if it is
		/// a letter in the alphabet
		/// </summary>
		/// <param name="stringToCapitalize"></param>
		public static void CapitalizeLetterInString(string stringToCapitalize)
		{
			string NewString = "";
			if (!char.IsUpper(stringToCapitalize[0]))
			{
				NewString += char.ToUpper(stringToCapitalize[0]);
			}

			for (int i = 1; i < stringToCapitalize.Length; i++)
			{
				if (char.IsWhiteSpace(stringToCapitalize[i]))
				{
					NewString += stringToCapitalize[i];
					i++;

					if (char.IsLower(stringToCapitalize[i]))
					{
						NewString += char.ToUpper(stringToCapitalize[i]);
						i++;
					}
				}
				NewString += stringToCapitalize[i];
			}
			Console.WriteLine(NewString);
		}
	}
}
