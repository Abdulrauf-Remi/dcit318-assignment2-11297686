using System;

namespace OOPDemo.InheritanceandOverriding
{
    // INHERITANCE AND METHOD OVERRIDING
    // Base class Animal
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    public class InheritanceDemo
    {
        public static void DemonstrateInheritance()
        {
            Console.WriteLine("1. INHERITANCE AND METHOD OVERRIDING");
            Console.WriteLine("-----------------------------------");
            
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            Console.WriteLine("Animal sound:");
            animal.MakeSound();
            
            Console.WriteLine("Dog sound:");
            dog.MakeSound();
            
            Console.WriteLine("Cat sound:");
            cat.MakeSound();
            Console.WriteLine();
        }
    }
}