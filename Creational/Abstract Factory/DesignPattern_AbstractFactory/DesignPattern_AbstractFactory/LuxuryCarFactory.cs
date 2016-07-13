using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_AbstractFactory
{
    class LuxuryCarFactory : CarFactory
    {
        public override Motor buildMotor()
        {
            return new DeluxeMotor();
        }

        public override Wheel buildWheel()
        {
            return new AlloyWheel();
        }
    }
}
