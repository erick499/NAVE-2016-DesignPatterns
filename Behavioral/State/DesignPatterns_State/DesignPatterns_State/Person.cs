using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_State
{
    public class Person
    {
        private StatePerson state;
        private string name;

        public Person(string name)
        {
            this.name = name;
            this.state = WithoutCap.Instance();

        }
        public string WhoAmI()
        {
            return (this.name + "com" + this.state);
        }

        public void ChangeState(StatePerson state)
        {
            this.state = state;
            Console.WriteLine(this.state.WhoAmI());
        }

        public void TakeCap()
        {
            this.state.takeCap(this);
        }
        public void PutCap()
        {
            this.state.putCap(this);
        }
        public void CapBack()
        {
            this.state.capBack(this);
        }
        public void CapFoward()
        {
            this.state.capFoward(this);
        }
    }
}
