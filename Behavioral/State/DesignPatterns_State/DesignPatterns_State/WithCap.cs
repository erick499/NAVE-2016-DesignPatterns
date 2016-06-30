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

        public override void capFoward(Person person)
        {
            person.ChangeState(CapFoward.Instance());
        }

        public override void capBack(Person person)
        {
            person.ChangeState(CapBack.Instance());
        }

        public override string WhoAmI()
        {
            return "Olha Eu com Boné!";
        }
    }
    public class CapFoward : StatePerson
    {
        private static CapFoward instance;

        protected CapFoward() { }
        public static CapFoward Instance()
        {
            if (instance == null)
                instance = new CapFoward();

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

        public override void capFoward(Person person)
        {
            Console.WriteLine("Meu Boné Já Está Para Frente!");
        }

        public override void capBack(Person person)
        {
            person.ChangeState(CapBack.Instance());
        }

        public override string WhoAmI()
        {
            return "Com o Boné Pra Frente!";
        }
    }
    public class CapBack : StatePerson
    {
        private static CapBack instance;

        protected CapBack() { }
        public static CapBack Instance()
        {
            if (instance == null)
                instance = new CapBack();

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

        public override void capFoward(Person person)
        {
            person.ChangeState(CapFoward.Instance());
        }

        public override void capBack(Person person)
        {
            Console.WriteLine("Meu Boné Já Está Para Trás!");
        }

        public override string WhoAmI()
        {
            return "Com o Boné Pra Trás!";
        }
    }
}
