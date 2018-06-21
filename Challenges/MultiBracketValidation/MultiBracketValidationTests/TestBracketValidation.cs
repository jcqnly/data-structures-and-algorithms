using System;
using Xunit;
using static MultiBracketValidation.Program;

namespace MultiBracketValidationTests
{
    public class TestBracketValidation
    {
        [Theory]
        [InlineData("{}(){}", true)]
        [InlineData("[({}]", false)]
        [InlineData("(](", false)]
        [InlineData("", false)]
        public void CanValidateBrackets(string stringToTest, bool expected)
        {
            //Act
            string testThisString = stringToTest;

            //Arrange
            ValidateBracket(testThisString);

            //Assert
            Assert.Equal(expected, ValidateBracket(testThisString));
        }
    }
}
