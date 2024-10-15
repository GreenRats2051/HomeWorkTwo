using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Car : Vehicle
    {
        public Car(double worth, double engineVolume) : base(worth, engineVolume) { }

        public override string ToString()
        {
            return "Автомобиль: " + base.ToString();
        }
    }
}
