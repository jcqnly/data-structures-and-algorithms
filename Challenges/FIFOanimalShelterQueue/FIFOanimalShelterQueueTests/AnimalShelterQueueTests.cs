using FIFOanimalShelterQueue;
using System;
using Xunit;

namespace FIFOanimalShelterQueueTests
{
    public class TestingAnimalShelterQueue
    {
        [Theory]
        [InlineData("catcat", "catcat")]
        [InlineData("doggy", "doggy")]
        [InlineData("kitty", "kitty")]
        public void CanEnqueueAnimal(string animal, string expected)
        {
            //Act
            //create a queue of animals to work with
            Queue queue = new Queue(new Node("cat"));

            Node node2 = new Node("cat");
            Node node3 = new Node("cat");
            Node node4 = new Node("dog");
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Enqueue(node4);

            //Arrange
            Node node5 = new Node(animal);
            queue.Enqueue(node5);

            //Asert
            Assert.Equal(expected, queue.Rear.AnimalType);
        }

        [Theory]
        [InlineData("parrot", "dog")]
        [InlineData("dog", "dog")]
        [InlineData("cat", "dog")]
        public void CanDequeueAnimal(string pref, string expected)
        {
            //Act
            //create a queue of animals to work with
            Queue queue = new Queue(new Node("dog"));

            Node node2 = new Node("dog");
            Node node3 = new Node("dog");
            Node node4 = new Node("dog");
            Node node5 = new Node("dog");
            Node node6 = new Node("dog");
            Node node7 = new Node("dog");
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Enqueue(node4);
            queue.Enqueue(node5);
            queue.Enqueue(node6);
            queue.Enqueue(node7);

            //Arrange
            Node foundAnimal = queue.Dequeue(pref);

            //Assert
            Assert.Equal(expected, foundAnimal.AnimalType);
        }
    }
}
