using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodExample
{
    public abstract class ConceptClass
    {
        public void Car()
        {
            Console.WriteLine("Construindo novo carro...");
            Console.WriteLine("Lataria e Rodas adicionadas.");
        }
        public abstract void Colors();
        public void NewColors()
        {
            this.Car();
            this.Colors();
        }
    }
}
