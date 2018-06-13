using System;
using Xunit;
using SinglyLinkList;

namespace LinkListTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNode()
        {
            //Arrange
            LinkListTests ll = new LinkList(new Node(4));
            Node node = node(8);
            //Act
            //Assert
        }

        [Theory]
        [InlineData()]
        public void CanFindNodeThatExists(int value, int expected)
        {

        }
    }
}
