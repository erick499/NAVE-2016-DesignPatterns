using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
		    Car c1 = CarBuilding.buildCar("luxury");
            Car c2 = CarBuilding.buildCar("normal");

            c1.information();
            c2.information();
        }
    }
}
