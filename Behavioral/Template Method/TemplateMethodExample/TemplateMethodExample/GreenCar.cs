using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodExample
{
    public class GreenCar:ConceptClass
    {
        public override void Colors()
        {
            Console.WriteLine("Cor: Verde");
        }
    }
}
