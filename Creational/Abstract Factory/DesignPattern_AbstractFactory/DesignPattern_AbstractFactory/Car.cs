using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_AbstractFactory
{
    class Car
    {
        Motor motor;
        Wheel wheel;

        public Wheel getWheel()
        {
            return wheel;
        }
        public void setWheel(Wheel wheel)
        {
            this.wheel = wheel;
        }
        public Motor getMotor()
        {
            return motor;
        }
        public void setMotor(Motor motor)
        {
            this.motor = motor;
        }

        public void information()
        {
            Console.WriteLine("Wheel: " + wheel.type + " || " + "Motor: " + motor.type);
        }
    }
}
