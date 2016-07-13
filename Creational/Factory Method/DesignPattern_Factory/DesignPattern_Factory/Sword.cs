using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Factory
{
    class Sword : Weapon
    {
        public override int attackSpeed
        {
            get { return 20; }
        }
        public override int damage
        {
            get { return 20; }
        }
    }
}
