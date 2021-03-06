using KthElementFromEnd;
using System;
using Xunit;

namespace KthElementFromEndTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 4)]//test that this works if k = 0
        [InlineData(1, 8)]
        [InlineData(4, 23)]
        public void CanSearchForK(int value, int expected)
        {
            //arrange
            LinkList ll = new LinkList();
            Node node = new Node(4);
            Node node2 = new Node(8);
            Node node3 = new Node(15);
            Node node4 = new Node(16);
            Node node5 = new Node(23);

            ll.Add(node);
            ll.Add(node2);
            ll.Add(node3);
            ll.Add(node4);
            ll.Add(node5);

            //act
            Node found = ll.KthElementFromEnd(value);

            //assert
            Assert.Equal(expected, found.Value);
        }
    }
}
