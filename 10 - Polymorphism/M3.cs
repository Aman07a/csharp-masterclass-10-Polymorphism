using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Polymorphism
{
    internal class M3 : BMW
    {
        public M3(int hp, string color, string model) : base(hp, color, model)
        {
            this.HP = hp;
            this.Color = color;
            this.Model = model;
        }

        /*
        public override void Repair()
        {
            base.Repair();
        }*/
    }
}
