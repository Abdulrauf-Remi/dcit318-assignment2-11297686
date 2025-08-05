using System;

namespace OOPDemo
{
    // 1. INHERITANCE AND METHOD OVERRIDING
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

    // 2. ABSTRACT CLASSES AND METHODS
    // Abstract base class Shape
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    // Derived class Circle
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return length * width;
        }
    }

    // 3. INTERFACES
    // Interface IMovable
    public interface IMovable
    {
        void Move();
    }

    // Class Car implementing IMovable
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Class Bicycle implementing IMovable
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DCIT 318: PROGRAMMING II ASSIGNMENT 2");
            Console.WriteLine("Object-Oriented Programming Demonstrations");
            Console.WriteLine("==========================================\n");

            // 1. INHERITANCE AND METHOD OVERRIDING DEMONSTRATION
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

            // 2. ABSTRACT CLASSES AND METHODS DEMONSTRATION
            Console.WriteLine("2. ABSTRACT CLASSES AND METHODS");
            Console.WriteLine("-------------------------------");
            
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            Console.WriteLine($"Circle with radius 5.0: Area = {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle with length 4.0 and width 6.0: Area = {rectangle.GetArea():F2}");
            Console.WriteLine();

            // 3. INTERFACES DEMONSTRATION
            Console.WriteLine("3. INTERFACES");
            Console.WriteLine("-------------");
            
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            Console.WriteLine("Car movement:");
            car.Move();
            
            Console.WriteLine("Bicycle movement:");
            bicycle.Move();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
