using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_AbstractFactory
{
    class CarBuilding
    {
        public static Car buildCar(string tp)
        {
            CarFactory cf = null;

            switch (tp)
            {
                case "luxury":
                    cf = new LuxuryCarFactory();
                    break;
                case "normal":
                    cf = new NormalCarFactory();
                    break;
                default:
                    break;
            }

            Car car = new Car();
            car.setWheel(cf.buildWheel());
            car.setMotor(cf.buildMotor());
            return car;
        }
    }
}
