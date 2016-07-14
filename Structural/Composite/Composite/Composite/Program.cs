using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Patrick Motta Aragão Pissurno
 * Luiz Roberto Almas Sirica
 * Daniel Kropf
*/

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo(ConsoleColor.Red);
            Linha lin = new Linha(ConsoleColor.Green);
            Ponto pon = new Ponto(ConsoleColor.Cyan);

            Console.WriteLine("                            Demonstracao do Composite\n-------------------------------------------------------------------------------\n");

            Console.WriteLine("Retangulo");
            ret.Paint();

            Console.WriteLine("\nLinha");
            lin.Paint();

            Console.WriteLine("\nPonto");
            pon.Paint();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n                         Aperte qualquer tecla para sair");
            Console.ReadKey();
        }
    }
    interface IGraphic
    {
	    void Paint();
	    void Add(IGraphic g);
	    void Remove(IGraphic g);
    }

    //Objeto composto
    class Retangulo : IGraphic
    {
	    private List<IGraphic> components = new List<IGraphic>();

	    public Retangulo(ConsoleColor color)
        {
		    for(int i=0; i<4; i++)
		    {
                Add(new Linha(color));
		    }
	    }

	    public void Paint()
        {
		    foreach(IGraphic g in components)
            {
			    g.Paint();
		    }
	    }

	    public void Add(IGraphic g)
        {
            components.Add(g);
        }
	    public void Remove(IGraphic g){ /*...*/ }
    };

    //Objeto composto
    class Linha : IGraphic
    {
        private List<IGraphic> components = new List<IGraphic>();

        public Linha(ConsoleColor color)
        {
            for (int i = 0; i < 15; i++)
            {
                Add(new Ponto(color));
            }
        }

        public void Paint()
        {
            foreach (IGraphic g in components)
            {
                g.Paint();
            }
            Console.WriteLine();
        }

        public void Add(IGraphic g)
        {
            components.Add(g);
        }
        public void Remove(IGraphic g) { /*...*/ }
    };

    //Objeto simples
    class Ponto : IGraphic
    {
        private ConsoleColor color;
        public Ponto(ConsoleColor color)
        {
            this.color = color;
        }
	    public void Paint()
        {
            Console.ForegroundColor = color;
            Console.Write("█");
            Console.ResetColor();
	    }
	    public void Add(IGraphic g){ /*...*/ }
	    public void Remove(IGraphic g){ /*...*/ }
    }
}
