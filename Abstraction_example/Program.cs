using System;

namespace Abstraction_example
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Console.WriteLine("Printing info for dog:");
            Console.WriteLine(dog.GetSpecies() + " says " + dog.Speak());
            Console.WriteLine("\nPrinting info for cat:");
            Console.WriteLine(cat.GetSpecies() + " says " + cat.Speak());
            
            
            Animal animal = dog;
            Console.WriteLine("\nPrinting info for animal when animal=dog:");
            Console.WriteLine(animal.GetSpecies() + " says " + animal.Speak());
            animal = cat;
            Console.WriteLine("\nPrinting info for animal when animal=cat:");
            Console.WriteLine(animal.GetSpecies() + " says " + animal.Speak());
        }
    }
}