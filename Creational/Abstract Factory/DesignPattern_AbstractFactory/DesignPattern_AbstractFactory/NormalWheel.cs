using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_AbstractFactory
{
    class NormalWheel : Wheel
    {
        public override string type
        {
            get { return "normalWheel"; }
        }
    }
}
