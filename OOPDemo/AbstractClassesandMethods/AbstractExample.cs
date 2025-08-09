using System;

namespace OOPDemo.AbstractClassesandMethods
{
    // ABSTRACT CLASSES AND METHODS
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

    public class AbstractDemo
    {
        public static void DemonstrateAbstractClasses()
        {
            Console.WriteLine("2. ABSTRACT CLASSES AND METHODS");
            Console.WriteLine("-------------------------------");
            
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            Console.WriteLine($"Circle with radius 5.0: Area = {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle with length 4.0 and width 6.0: Area = {rectangle.GetArea():F2}");
            Console.WriteLine();
        }
    }
}