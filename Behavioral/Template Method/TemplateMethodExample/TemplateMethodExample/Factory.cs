using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodExample
{
    class Factory
    {
        static void Main(string[] args)
        {
            ConceptClass Car = null;
            Car = new GreenCar();
            Car.NewColors();

            Console.WriteLine();

            Car = new RedCar();
            Car.NewColors();
            Console.ReadLine();
        }
    }
}
