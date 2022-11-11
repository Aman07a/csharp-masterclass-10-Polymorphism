using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Polymorphism
{
    // An Audi is a Car
    internal class Audi : Car
    {
        private string brand = "Audi";
        public string Model { get; set; }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            Model = model;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Brand: {brand}. Model: {Model}. HP: {HP}. Color: {Color}.");
        }

        public override void Repair()
        {
            Console.WriteLine("The Audi {0} was repaired.", Model);
        }
    }
}
