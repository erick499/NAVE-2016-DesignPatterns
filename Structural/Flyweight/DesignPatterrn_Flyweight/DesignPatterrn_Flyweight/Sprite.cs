using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DesignPatterrn_Flyweight
{
    //Esse é o nosso Flyweight de fato (ou concreto!)!
        //Aqui implementamos as operações da Interface.
    public class Sprite : ISpriteFlyweight //Em C# utilizamos ":" para indicar qual classe será implementada, que nesse caso é uma interface indicada pelo "I".
    {
        protected Imagem imagem;

        public Sprite(String nomeDaImagem)
        {
            imagem = new Imagem(nomeDaImagem);
        }


        public override void desenharImagem(Ponto ponto)
        {
            imagem.desenharImagem();
            Debug.WriteLine("no ponto (" + ponto.x + "," + ponto.y + ")!");
        }


        public override string desenharNoConsole(Ponto ponto)
        {
            string s = imagem.desenharNoConsole();
            return s + " no ponto (" + ponto.x + "," + ponto.y + ")!\n";
        }
    }
}
