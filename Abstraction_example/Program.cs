using System;

namespace Abstraction_example
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("Printing info for dog:");
            Console.WriteLine(dog.GetSpecies() + " says " + dog.Speak());
            Cat cat = new Cat();
            Console.WriteLine("\nPrinting info for cat:");
            Console.WriteLine(cat.GetSpecies() + " says " + cat.Speak());

            Animal animal = dog;
            Console.WriteLine("\nPrinting info for animal when animal=dog:");
            Console.WriteLine(animal.GetSpecies() + " says " + animal.Speak());

            animal = cat;
            Console.WriteLine("\nPrinting info for animal when animal=cat:");
            Console.WriteLine(animal.GetSpecies() + " says " + animal.Speak());

            RedRose rose = new RedRose();
            Console.WriteLine("\nPrinting info for rose:");
            Console.WriteLine("I am a " + rose.GetColorOfFlower() + " " + rose.GetSpecies());

            Plant plant = rose;
            Console.WriteLine("\nPrinting info for plant when plant=rose:");
            Console.WriteLine("I am a " + plant.GetColorOfFlower() + " " + plant.GetSpecies());
        }
    }
}