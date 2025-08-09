using System;

namespace OOPDemo.Interface
{
    // INTERFACES
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

    public class InterfaceDemo
    {
        public static void DemonstrateInterfaces()
        {
            Console.WriteLine("3. INTERFACES");
            Console.WriteLine("-------------");
            
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            Console.WriteLine("Car movement:");
            car.Move();
            
            Console.WriteLine("Bicycle movement:");
            bicycle.Move();
            Console.WriteLine();
        }
    }
}