using System;

namespace FIFOanimalShelterQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("G'day! Welcome to the shelter");
            FIFOanimalShelter();
        }

        public static void FIFOanimalShelter()
        {
            //create a queue of animals to work with
            Queue queue = new Queue(new Node("cat"));
            queue.Enqueue(new Node("cat"));
            queue.Enqueue(new Node("cat"));
            queue.Enqueue(new Node("dog"));
            queue.Enqueue(new Node("dog"));

            //output will be  cat  cat  cat  dog  dog (rear)
            Console.WriteLine("Animal queue we're working with: ");
            queue.Print();

            //Enqueue another animal to the queue
            queue.Enqueue(new Node("dog"));
            Console.WriteLine("Let's add another dog to the queue: ");
            //output will be  cat  cat  cat  dog  dog  dog (rear)
            queue.Print();

            //Dequeue an animal based on preference of the adopter
            //accounting for when they want something other than a dog or cat
            Console.WriteLine("Someone wants to adopt a PARROT today!");
            Node chosenAnimal = queue.Dequeue("parrot");
            Console.WriteLine($"but they're gonna get a: {chosenAnimal.AnimalType}");
            queue.Print();
            Console.WriteLine("------------------------");
            Console.WriteLine("Next person wants a DOG: ");
            Node chosenAnimalDog = queue.Dequeue("dog");
            Console.WriteLine($"...and they'll get a: {chosenAnimalDog.AnimalType}");
            queue.Print();
            Console.WriteLine("------------------------");
            Console.WriteLine("And someone else wants a CAT: ");
            Node chosenAnimalCat = queue.Dequeue("cat");
            Console.WriteLine($"...and they'll get a: {chosenAnimalCat.AnimalType}");
            queue.Print();
        }
    }
}
