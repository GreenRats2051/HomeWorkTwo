using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Vehicle : Property
    {
        protected double engineVolume;

        public Vehicle(double worth, double engineVolume) : base(worth)
        {
            this.engineVolume = engineVolume;
        }

        public override double CalculateTax()
        {
            return worth * engineVolume / 3000;
        }

        public override string ToString()
        {
            return base.ToString() + $", объём двигателя - {engineVolume} см.куб";
        }
    }
}
