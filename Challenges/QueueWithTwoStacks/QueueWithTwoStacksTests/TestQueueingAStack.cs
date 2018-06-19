using QueueWithTwoStacks;
using System;
using Xunit;

namespace QueueWithTwoStacksTests
{
    public class TestQueueingAStack
    {
        [Theory]
        [InlineData(666, 666)]
        [InlineData(4, 4)]
        [InlineData(11111, 11111)]
        public void CanEnqueueAStack(int value, int expected)
        {
            //Act
            //instantiate stack1 with values
            StackStack stack1 = new StackStack()
            {
                Top = new Node(30) //this is the 1st node in
            };
            Node node = new Node(555);
            Node node2 = new Node(333);
            Node node3 = new Node(4);
            stack1.Push(node);
            stack1.Push(node2);
            stack1.Push(node3);
            //stack is 4   333   555   30

            //instantiate stack2 with no value
            StackStack stack2 = new StackStack();
            //instantiate new queue with the 2 stacks passed in
            Queue queue = new Queue(stack1, stack2);

            //Arrange
            Node node4 = new Node(value);
            queue.Enqueue(node4);

            //Assert
            Assert.Equal(expected, stack1.Top.Value);
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(24, 24)]
        [InlineData(42, 42)]
        public void CanDequeueAStack(int value, int expected)
        {
            //Act
            //instantiate stack1 with values
            Node node = new Node(value);
            StackStack stack1 = new StackStack()
            {
                Top = new Node(value) //this is the 1st node in
            };
            stack1.Push(new Node(20));
            stack1.Push(new Node(87));
            //instantiate stack2 with no value
            StackStack stack2 = new StackStack();
            //instantiate new queue with 2 stacks passed in
            Queue queue = new Queue(stack1, stack2);

            //Arrange
            Node foundNode = queue.Dequeue();

            //Assert
            Assert.Equal(value, foundNode.Value);
            Assert.NotEqual(stack1.Top.Value, foundNode.Value);
        }
    }
}
