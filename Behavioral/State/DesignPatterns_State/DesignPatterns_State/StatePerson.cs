using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_State
{
    public abstract class StatePerson
    {
        public abstract void takeCap(Person person);
        public abstract void putCap(Person person);
        public abstract void capFoward(Person person);
        public abstract void capBack(Person person);

        public abstract string WhoAmI();
    }
}
