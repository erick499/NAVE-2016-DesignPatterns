using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodExample
{
    class RedCar:ConceptClass
    {
        public override void Colors()
        {
            Console.WriteLine("Cor:Vermelha");
        }
    }
}
