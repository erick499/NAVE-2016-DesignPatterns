using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Factory
{
    abstract class Weapon
    {
        public abstract int damage { get; }
        public abstract int attackSpeed { get; }

	    public void returnInformation() {
		    Console.WriteLine("Dano: " + damage + " || DPS: " + attackSpeed);
	    }
    }
}
