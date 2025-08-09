using System;
using InheritanceandOverriding;
using AbstractClassesandMethods;
using Interface;

namespace DCIT318Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DCIT 318: PROGRAMMING II ASSIGNMENT 2");
            Console.WriteLine("Object-Oriented Programming Demonstrations");
            Console.WriteLine("Student ID: 11297686");
            Console.WriteLine("==========================================\n");

            // Demonstrate Inheritance and Overriding
            InheritanceDemo.DemonstrateInheritance();

            // Demonstrate Abstract Classes and Methods
            AbstractDemo.DemonstrateAbstractClasses();

            // Demonstrate Interfaces
            InterfaceDemo.DemonstrateInterfaces();

            Console.WriteLine("All OOP concepts demonstrated successfully!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
