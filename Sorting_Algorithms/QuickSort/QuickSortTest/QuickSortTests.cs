using System;
using Xunit;
using static QuickSort.Program;

namespace QuickSortTest
{
    public class QuickSortTests
    {
        [Theory]
        [InlineData(new int[] { 20, 4, 19, 21, 16, 1, 13 }, new int[] { 1, 4, 13, 16, 19, 20, 21 })]
        [InlineData(new int[] { 2, 9, 2, 7, 6, 12, 13, 8 }, new int[] { 2, 2, 6, 7, 8, 9, 12, 13 })]
        [InlineData(new int[] { 20, 40, 109, 201, 160, 100 }, new int[] { 20, 40, 100, 109, 160, 201 })]
        public void CanQuickSort(int[] value, int[] expected)
        {
            //arrange
            int[] unsortedArray = value;

            //act
            Quick_Sort(value, 0, value.Length - 1);

            //assert
            Assert.Equal(value, expected);
        }
    }
}
