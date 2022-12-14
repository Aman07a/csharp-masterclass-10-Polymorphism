using System;
using System.Collections.Generic;

namespace _10___Polymorphism
{
    internal class Program
    {
        // Create a base class Car with two properties HP and Color.
        // Create a Constructor setting those two properties.
        // Create a Method called ShowDetails() which shows the HP and Color of the car on the console.
        // Create a Repair Method which writes "Car was repaired!" onto the console.
        // Create two deriving classes, BMW and Audi, which have their own constructor and have an additional property called Model.
        // Also a private member called brand. Brand should be different in each of the two classes.
        // Create the two methods ShowDetails() and Repair in them as well. Adjust those methods accordingly.
        static void Main(string[] args)
        {
            // // A car can be a BMW, an Audi, a Porsche etc.
            // // Polymorphism at work.
            // // #1: An Audi, BMW, Porsche can all be used wherever a Car is expected.
            // // No cast is required because an implicit conversion exists from a derived class to it's base class.
            // var cars = new List<Car>
            // {
            //     new Audi(200, "blue", "A4"),
            //     new BMW(250, "red", "M3"),
            // };

            // // Polymorphism at work.
            // // #2: The virtual method Repair is invoked on each of the derived classes, not the base class.
            // foreach(var car in cars)
            // {
            //     car.Repair();
            // }

            // Car bmwZ3 = new BMW(200, "Black", "Z3");
            // Car audiA3= new Audi(100, "Green", "A3");
            // bmwZ3.ShowDetails();
            // audiA3.ShowDetails();

            // bmwZ3.SetCarIDInfo(1234, "Denis");
            // audiA3.SetCarIDInfo(1235, "Aman");
            // bmwZ3.GetCarIDInfo();
            // audiA3.GetCarIDInfo();

            // BMW bmwM5 = new BMW(330, "White", "M5");
            // bmwM5.ShowDetails();

            // Car carB = (Car)bmwM5;
            // carB.ShowDetails();

            // M3 myM3 = new M3(260, "Red", "M3 Super Turbo");
            // myM3.Repair();

            // Shape[] shapes = { new Sphere(4), new Cube(3) };

            // foreach (Shape shape in shapes)
            // {
            //     shape.GetInfo();
            //     Console.WriteLine("{0} has a Volume of {1}", shape.Name, shape.Volume());

            //     Cube iceCube = shape as Cube;

            //     if (iceCube == null)
            //     {
            //         Console.WriteLine("This shape is no cube");
            //     }

            //     if (shape is Cube)
            //     {
            //         Console.WriteLine("This shape is a cube");
            //     }

            //     object cube1 = new Cube(7);
            //     Cube cube2 = (Cube)cube1;

            //     Console.WriteLine("{0} has a Volume of {1}", cube2.Name, cube2.Volume());
            // }

            Console.ReadKey();
        }
    }
}
