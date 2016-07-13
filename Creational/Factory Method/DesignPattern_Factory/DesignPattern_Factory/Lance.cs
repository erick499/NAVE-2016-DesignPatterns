using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Factory
{
    class Lance : Weapon
    {
        public override int attackSpeed
        {
            get { return 10; }
        }
        public override int damage
        {
            get { return 30; }
        }
    }
}
