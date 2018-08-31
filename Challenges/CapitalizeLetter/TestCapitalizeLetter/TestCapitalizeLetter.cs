using System;
using Xunit;
using static CapitalizeLetter.Program;

namespace TestCapitalizeLetter
{
	public class TestCapitalizeLetter
	{
		[Theory]
		[InlineData("$loppy joe","$loppy Joe")]
		[InlineData("4@ppy dog 1s BEST dOG", "4@ppy Dog 1s BEST DOG")]
		[InlineData("1234", "1234")]
		public void CanCapitalizeLetterWithStringBuilder(string input, string expected)
		{
			Assert.Equal(expected, CapitalizeLetterWithStringBuilder(input));
		}

		[Theory]
		[InlineData("$loppy joe", "$loppy Joe")]
		[InlineData("4@ppy dog 1s BEST dOG", "4@ppy Dog 1s BEST DOG")]
		[InlineData("1234", "1234")]
		public void CanCapitalizeLetterBruteForce(string input, string expected)
		{
			Assert.Equal(expected, CapitalizeLetterInString(input));
		}
	}
}
