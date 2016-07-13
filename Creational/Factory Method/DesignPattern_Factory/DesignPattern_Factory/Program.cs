using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Blacksmith jack = new Blacksmith();

		    Weapon w1 = jack.buildWeapon("sword");
		    Weapon w2 = jack.buildWeapon("lance");

            w1.returnInformation();
            w2.returnInformation();
        }
    }
}
