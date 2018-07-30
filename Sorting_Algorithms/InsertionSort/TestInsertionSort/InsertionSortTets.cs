using InsertionSort.Classes;
using System;
using Xunit;

namespace TestInsertionSort
{
    public class InsertionSortTets
    {
        [Theory]
        [InlineData(new int[] { 20, 4, 19, 21, 72, 16, 1, 51, 13, 800 }, 1)]
        [InlineData(new int[] { 2, 9, 2, 7, 6, 12, 51, 13, 8 }, 2)]
        [InlineData(new int[] { 20, 40, 109, 201, 702, 160, 100}, 20)]
        public void CanSortArray(int[] value, int expected)
        {
            //arrange
            int[] unsortedArray = value;

            Sort insertionSort = new Sort();

            //act
            int[] sortedArray = insertionSort.InsertionSort(unsortedArray);

            //assert
            Assert.Equal(expected, unsortedArray[0]);
        }
    }
}
