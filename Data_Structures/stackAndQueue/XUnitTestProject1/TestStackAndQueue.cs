using stackAndQueue;
using System;
using Xunit;

namespace TestStackAndQueue
{
    public class TestStackAndQueue
    {
        [Fact]
        public void CanPushStack()
        {
            //Act
            Stacks stacks = new Stacks(new Node(10));
            stacks.Push(new Node(1));
            stacks.Push(new Node(12));
            stacks.Push(new Node(91));
            stacks.Push(new Node(33));

            //Arrange
            stacks.Push(new Node(60));

            //Assert
            Assert.Equal(60, stacks.Top.Value);
        }

        [Fact]
        public void CanPopStack()
        {
            //Act
            Stacks stacks = new Stacks(new Node(10));
            stacks.Push(new Node(1));
            stacks.Push(new Node(12));
            stacks.Push(new Node(91));
            stacks.Push(new Node(33));

            //Arrange
            stacks.Pop();

            //Assert
            Assert.Equal(91, stacks.Top.Value);
        }

        [Fact]
        public void CanPeekAtStack()
        {
            //Act
            Stacks stacks = new Stacks(new Node(10));
            stacks.Push(new Node(1));
            stacks.Push(new Node(12));
            stacks.Push(new Node(91));
            stacks.Push(new Node(33));

            //Arrange
            stacks.Peek();

            //Assert
            Assert.Equal(33, stacks.Top.Value);
        }

        [Fact]
        public void CanEnqueueQueue()
        {
            //Act
            Queue queue = new Queue(new Node(10));
            queue.Enqueue(new Node(111));
            queue.Enqueue(new Node(0));
            queue.Enqueue(new Node(22));
            queue.Enqueue(new Node(39));

            //Arrange
            queue.Enqueue(new Node(666));

            //Assert
            Assert.Equal(666, queue.Rear.Value);
        }

        [Fact]
        public void CanDequeueQueue()
        {
            //Act
            Queue queue = new Queue(new Node(10));
            queue.Enqueue(new Node(111));
            queue.Enqueue(new Node(0));
            queue.Enqueue(new Node(22));
            queue.Enqueue(new Node(39));

            //Arrange
            queue.Dequeue();

            //Assert
            Assert.Equal(111, queue.Front.Value);
        }

        [Fact]
        public void CanPeekAtQueue()
        {
            //Act
            Queue queue = new Queue(new Node(10));
            queue.Enqueue(new Node(111));
            queue.Enqueue(new Node(0));
            queue.Enqueue(new Node(22));
            queue.Enqueue(new Node(39));

            //Arrange
            queue.Peek();

            //Assert
            Assert.Equal(10, queue.Front.Value);
        }
    }
}
