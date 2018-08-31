using System;
using System.Text;

namespace CapitalizeLetter
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string stringToCapitalize = "apple @pple aPPLES dog";
			//CapitalizeLetterInString(stringToCapitalize);
			Console.WriteLine(CapitalizeLetterWithStringBuilder(stringToCapitalize));
			//try this in Regex

		}

		public static string CapitalizeLetterWithStringBuilder(string stringToCapitalize)
		{
			string[] newString = stringToCapitalize.Split(" ");
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < newString.Length; i++)
			{
				string temp = newString[i];

				if (char.IsLetter(temp[0]))
				{
					sb.Append(char.ToUpper(temp[0]));
					sb.Append(temp.Substring(1, temp.Length-1));
				}
				else
				{
					sb.Append(temp);
				}

				if (i != newString.Length-1)
				{
					sb.Append(" ");
				}
			}

			return sb.ToString();
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
