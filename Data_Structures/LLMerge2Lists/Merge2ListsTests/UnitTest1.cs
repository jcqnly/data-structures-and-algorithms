using LLMerge2Lists;
using System;
using Xunit;

namespace Merge2ListsTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanMerge2Lists()
        {
            //Arrange
            LinkList llOne = new LinkList();

            llOne.Add(new Node(31));
            llOne.Add(new Node(8));
            llOne.Add(new Node(2));
            llOne.Add(new Node(19));

            LinkList llTwo = new LinkList();

            llTwo.Add(new Node(31));
            llTwo.Add(new Node(8));
            llTwo.Add(new Node(2));
            llTwo.Add(new Node(20));

            //Act
            llOne.Merge2(llOne, llTwo);
            //Node found = llThree.Find(value);

            //Assert (expected, actual)
            Assert.Equal(llOne.Head, llOne.Merge2(llOne, llTwo));
        }

        [Fact]
        public void CanMergeUnevenWhereFirstListIsShorter()
        {
            //Arrange
            LinkList llOne = new LinkList();

            llOne.Add(new Node(41));
            llOne.Add(new Node(8));


            LinkList llTwo = new LinkList();

            llTwo.Add(new Node(51));
            llTwo.Add(new Node(18));
            llTwo.Add(new Node(12));
            llTwo.Add(new Node(2));

            //Act
            llOne.Merge2(llOne, llTwo);
            //Node found = llThree.Find(value);

            //Assert (expected, actual)
            Assert.Equal(llOne.Head, llOne.Merge2(llOne, llTwo));
        }

        [Fact]
        public void CanMergeUnevenWhereSecondListIsShorter()
        {
            //Arrange
            LinkList llOne = new LinkList();

            llOne.Add(new Node(8));
            llOne.Add(new Node(2));
            llOne.Add(new Node(19));
            llOne.Add(new Node(19));

            LinkList llTwo = new LinkList();

            llTwo.Add(new Node(51));

            //Act
            llOne.Merge2(llOne, llTwo);
            //Node found = llThree.Find(value);

            //Assert (expected, actual)
            Assert.Equal(llOne.Head, llOne.Merge2(llOne, llTwo));
        }
    }
}