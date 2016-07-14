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
            Retangulo ret = new Retangulo();
            ret.Paint();
            Console.ReadKey();
        }
    }
    interface Graphic
    {
	    void Paint();
	    void Add(Graphic g);
	    void Remove(Graphic g);
    }

    //Objeto composto
    class Retangulo : Graphic
    {
	    List<Graphic> components = new List<Graphic>();

	    public Retangulo()
        {
		    for(int i=0; i<4; i++)
		    {
			    components.Add(new Linha());
		    }
	    }

	    public void Paint()
        {
		    foreach(Graphic g in components)
            {
			    g.Paint();
		    }
	    }
	    public void Add(Graphic g){ /*...*/ }
	    public void Remove(Graphic g){ /*...*/ }
    };

    //Objeto simples
    class Linha : Graphic
    {
	    public void Paint()
        {
            Console.WriteLine("███████████████");
	    }
	    public void Add(Graphic g){ /*...*/ }
	    public void Remove(Graphic g){ /*...*/ }
    }
}
