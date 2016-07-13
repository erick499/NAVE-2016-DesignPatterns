using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Factory
{
    class Dagger : Weapon
    {
        public override int attackSpeed
        {
            get { return 30;}
        }
        public override int damage
        {
            get { return 10; }
        }
    }
}
