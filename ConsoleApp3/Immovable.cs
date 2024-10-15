using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Immovable : Property
    {
        protected double area;

        public Immovable(double worth, double area) : base(worth)
        {
            this.area = area;
        }

        public double CostPerSquareMeter()
        {
            return worth / area;
        }

        public override string ToString()
        {
            return base.ToString() + $", площадь - {area} кв.м";
        }
    }
}
