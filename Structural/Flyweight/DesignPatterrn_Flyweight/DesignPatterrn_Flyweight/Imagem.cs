using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DesignPatterrn_Flyweight
{
    //Uma classe para a "imagem".
        //Este é o nosso "Estado Intrísseco",  que consiste de uma informação que não depende de um contexto externo. 
    public class Imagem
    {
        protected String nomeDaImagem;

        public Imagem(String imagem)
        {
            nomeDaImagem = imagem;
        }

        public void desenharImagem()
        {
            Debug.WriteLine(nomeDaImagem + " desenhada!");
        }

        //Operação para desenhar a "imagem".
        public string desenharNoConsole()
        {
            return "Imagem " + nomeDaImagem + " desenhada";
        }
    }
}
