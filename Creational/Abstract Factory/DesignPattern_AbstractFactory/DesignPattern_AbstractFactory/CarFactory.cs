using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_AbstractFactory
{
    abstract class CarFactory
    {
        public abstract Wheel buildWheel();
        public abstract Motor buildMotor();
    }
}
