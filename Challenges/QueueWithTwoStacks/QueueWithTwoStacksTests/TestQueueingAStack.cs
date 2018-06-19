using QueueWithTwoStacks;
using System;
using Xunit;

namespace QueueWithTwoStacksTests
{
    public class TestQueueingAStack
    {
        [Fact]
        public void CanEnqueueAStack()
        {
            //Act
            StackStack stack1 = new StackStack()
            {
                Top = new Node(30) //this is the 1st node in
            };
            stack1.Push(new Node(555));
            stack1.Push(new Node(333));

            //Arrange


            //Assert
        }
    }
}
