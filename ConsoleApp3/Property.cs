using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Property
    {
        protected double worth;

        public Property(double worth)
        {
            this.worth = worth;
        }

        public abstract double CalculateTax();

        public override string ToString()
        {
            return $"Стоимость - {worth}, налог - {CalculateTax()}";
        }
    }
}
