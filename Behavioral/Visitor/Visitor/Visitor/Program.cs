using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Patrick Motta Aragão Pissurno
 * Luiz Roberto Almas Sirica
 * Daniel Kropf
*/

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            Console.WriteLine("Shopping Cart created\n---------------------");

            cart.Add(new Book(9f, 3f));
            cart.Add(new Book(4f, 1f));

            Console.WriteLine("\nTotal Postage for Cart: " + cart.CalculatePostage());
            Console.ReadKey();
        }
    }

    //Interface dos Elementos
    public interface IVisitable{
        void Accept(IVisitor visitor);
    }

    //Elemento
    public class Book : IVisitable{
        private float price;
        private float weight;
    
        public Book(float price, float weight){
            this.price = price;
            this.weight = weight;
        }
    
        //Aceita o Visitor
        public void Accept(IVisitor visitor) {
            visitor.Visit(this);
        }
        public float GetPrice() {
            return price;
        }
        public float GetWeight() {
            return weight;
        }
    }

    public interface IVisitor{
        //Visita os Elementos (um overload para cada)
        void Visit(Book book);
    }

    public class PostageVisitor : IVisitor{
        private float price;
    
        //Calcula o frete do livro
        public void Visit(Book book) {
            //Frete grátis para preços maiores que 10
            float postage = 0;
            if(book.GetPrice() < 10f) {
                postage = book.GetWeight() * 2;
            }
            price += postage;
            Console.WriteLine("Book Postage --> $" + postage);
        }
    
        //Retorna o valor do frete
        public float GetTotalPostage() {
            return price;
        }
    }

    public class ShoppingCart{
        public List<IVisitable> items = new List<IVisitable>();

        public void Add(IVisitable item)
        {
            if (item.GetType().Equals(typeof(Book)))
                Console.WriteLine("Added Book to Cart --> Price: $" + (item as Book).GetPrice() + " | Weight: " + ((item as Book).GetWeight() * 100) + "g");
            items.Add(item);
        }

        public float CalculatePostage() {
            Console.WriteLine("\nCalculating Postage\n-------------------");
            //Cria um visitor
            PostageVisitor visitor = new PostageVisitor();
        
            //Calcula o frete de cada item
            foreach(IVisitable item in items) {
                item.Accept(visitor);
            }
        
            float postage = visitor.GetTotalPostage();
            return postage;
        }
    }
}
