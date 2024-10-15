using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class CountryHouse : Immovable
    {
        public CountryHouse(double worth, double area) : base(worth, area) { }

        public override double CalculateTax()
        {
            if (area < 100)
            {
                return worth / 500;
            }
            else if (area >= 100 && area < 300)
            {
                return worth / 350;
            }
            else
            {
                return worth / 250;
            }
        }

        public override string ToString()
        {
            return "Дача: " + base.ToString();
        }
    }
}
