using System;
using Xunit;
using static ReverseWordsInString.Program;

namespace TestReverseString
{
	public class UnitTest1
	{
		[Theory]
		[InlineData("Hello world", "world Hello")]
		[InlineData("Green eggs and ham", "ham and eggs Green")]
		[InlineData("1 cup of coffee", "coffee of cup 1")]
		public void CanReverseString(string input, string expected)
		{
			//assert
			Assert.Equal(expected, ReverseWordsStringBuilder(input));
		}
	}
}
