using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicia um novo cliente para calcular os dois valores
            calculocliente subtracao = new calculocliente(new subtracao());
            calculocliente adicao = new calculocliente(new adicao());
            Console.WriteLine("subtracao: " + subtracao.cauculo(10,1) + " adicao: " + adicao.cauculo(10,1));
            Console.Read();
        }
    }
    // Interface para estrategia
    public interface Strategy
    {
        //Define o metodo
        int calculo( int valor1, int valor2);
    }
    //Primeira estrategia
    class subtracao : Strategy
    {
        public int calculo(int valor1, int valor2)
        {
            //Define a lógica 
            return valor1 - valor2;
        }
    }
    //Segunda estrategia
    class adicao : Strategy
    {
        public int calculo(int valor1, int valor2)
        {
            //Define a lógica
            return valor1 + valor2;
        }
    }
    //Cliente(Executa a estrategia)
    class calculocliente
    {
        private Strategy strategy;
        //Construtor atibui a estrategia para fazer a interface
        public calculocliente(Strategy calculate)
        {
            strategy = calculate;
        }
        //Executa a estrategia
        public int cauculo(int valor1, int valor2)
        {
            return strategy.calculo(valor1,valor2);
        }
    }
}
