using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_AbstractFactory
{
    class NormalCarFactory : CarFactory
    {
        public override Motor buildMotor()
        {
            return new NormalMotor();
        }

        public override Wheel buildWheel()
        {
            return new NormalWheel();
        }
    }
}
