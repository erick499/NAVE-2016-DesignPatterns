using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_State
{
    public class WithCap : StatePerson
    {
        private static WithCap instance;

        protected WithCap() { }
        public static WithCap Instance()
        {
            if (instance == null)
                instance = new WithCap();

            return instance;
        }
        public override void takeCap(Person person) 
        {
            person.ChangeState(WithoutCap.Instance());
        }

        public override void putCap(Person person)
        {
            Console.WriteLine("Ja Estou com Boné!");
        }

        public override string WhoAmI()
        {
            return "Olha Eu com Boné!";
        }
    }
}
