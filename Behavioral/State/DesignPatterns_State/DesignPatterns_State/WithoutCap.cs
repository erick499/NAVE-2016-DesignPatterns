using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_State
{
    public class WithoutCap : StatePerson
    {
        private static WithoutCap instance;

        protected WithoutCap() { }
        public static WithoutCap Instance()
        {
            if (instance == null)
                instance = new WithoutCap();

            return instance;
        }
        public override void takeCap(Person person)
        {
            Console.WriteLine("Ja Estou sem Boné!");
        }

        public override void putCap(Person person)
        {
            person.ChangeState(WithCap.Instance());
        }

        public override string WhoAmI()
        {
            return "Olha Eu sem Boné!";
        }
    }
}
