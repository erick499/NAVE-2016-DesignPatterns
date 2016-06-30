using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_State
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Carinha");
            p1.PutCap();
            p1.TakeCap();
            p1.PutCap();
            p1.PutCap();
            p1.CapFoward();
            p1.CapBack();
            p1.CapBack();
            p1.TakeCap();
            p1.CapFoward();
            Console.Read();
        }
    }
}
