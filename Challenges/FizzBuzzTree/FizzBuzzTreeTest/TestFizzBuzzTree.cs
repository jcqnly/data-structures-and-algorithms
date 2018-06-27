using FizzBuzzTree;
using Xunit;

namespace FizzBuzzTreeTest
{
    public class TestFizzBuzzTree
    {
        [Theory]
        [InlineData("FizzBuzz", "45")]
        [InlineData("Buzz", "5")]
        [InlineData("Fizz", "9")]
        public void CanFizzBuzzTree(string expected, string value)
        {
            //act
            BinaryTree binaryTree = new BinaryTree();

            Node nodeA = new Node(value);
            Node nodeB = new Node("23");
            Node nodeC = new Node("57");
            Node nodeD = new Node("45");
            Node nodeE = new Node("50");
            Node nodeF = new Node("63");

            //setting the values of left and right child of each node
            nodeA.LeftChild = nodeB;
            nodeA.RightChild = nodeC;
            nodeB.LeftChild = nodeD;
            nodeB.RightChild = nodeE;
            nodeC.LeftChild = nodeF;

            //arrange
            Node found = binaryTree.FBTree(nodeA);

            //assert
            Assert.Equal(expected, found.Value);
        }
    }
}
