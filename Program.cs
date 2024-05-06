using System;
namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Scooter scooter = new Scooter();
            Car car = new Car();
            Console.WriteLine("Scooter started:");
            scooter.display();
            Console.WriteLine("\nCar started:");
            car.display();
        }
    }
    public class Vehicle
    {
        public void tyre()
        {
            Console.WriteLine("It is a tubeless tyre");
        }
    }
    class Scooter : Vehicle
    {
        public void display() 
        {
            base.tyre();
            Console.WriteLine("It is a scooter class");
        }
    }
    class Car : Vehicle
    {
        public  void display() 
        {
            base.tyre();
            Console.WriteLine("It is a car class");
        }
    }
}

