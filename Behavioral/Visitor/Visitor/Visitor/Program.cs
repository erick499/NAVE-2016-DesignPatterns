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
            cart.Add(new Book(9f, 1f));
            cart.Add(new Book(4f, .2f));
            Console.WriteLine("Total Postage for Cart: " + cart.CalculatePostage());
            Console.ReadKey();
        }
    }

    //Interface dos Elementos
    public interface Visitable{
        void Accept(Visitor visitor);
    }

    //Elemento
    public class Book : Visitable{
        private float price;
        private float weight;
    
        public Book(float price, float weight){
            this.price = price;
            this.weight = weight;
        }
    
        //Aceita o Visitor
        public void Accept(Visitor visitor) {
            visitor.Visit(this);
        }
        public float GetPrice() {
            return price;
        }
        public float GetWeight() {
            return weight;
        }
    }

    public interface Visitor{
        //Visita os Elementos (um overload para cada)
        void Visit(Book book);
    }

    public class PostageVisitor : Visitor{
        private float price;
    
        //Calcula o frete do livro
        public void Visit(Book book) {
            //Frete grátis para preços maiores que 10
            if(book.GetPrice() < 10f) {
                price += book.GetWeight() * 2;
            }
        }
    
        //Retorna o valor do frete
        public float GetTotalPostage() {
            return price;
        }
    }

    public class ShoppingCart{
        public List<Visitable> items = new List<Visitable>();

        public void Add(Visitable item)
        {
            items.Add(item);
        }

        public float CalculatePostage() {
            //Cria um visitor
            PostageVisitor visitor = new PostageVisitor();
        
            //Calcula o frete de cada item
            foreach(Visitable item in items) {
                item.Accept(visitor);
            }
        
            float postage = visitor.GetTotalPostage();
            return postage;
        }
    }
}
