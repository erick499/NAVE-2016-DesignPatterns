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
            Console.WriteLine("Ja Estou Sem Boné!");
        }

        public override void putCap(Person person)
        {
            person.ChangeState(WithCap.Instance());
        }

        public override void capFoward(Person person)
        {
            Console.WriteLine("To Sem Boné, Não da pra virar!");
        }

        public override void capBack(Person person)
        {
            Console.WriteLine("To Sem Boné, Não da pra virar!");

        }
        public override string WhoAmI()
        {
            return "Olha Eu sem Boné!";
        }
    }
}
