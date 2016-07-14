using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterrn_Flyweight
{
    //O ponto será passado como parâmetro.
        //Ele é o "Estado Extrínseco", que varia de acordo com o contexto.
        //Ele é uma classe para as coordenadas/Vetor da nossa imagem.
    public class Ponto
    {
        public int x, y;

        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
