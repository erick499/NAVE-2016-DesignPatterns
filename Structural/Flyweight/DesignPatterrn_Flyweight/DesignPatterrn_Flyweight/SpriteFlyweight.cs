using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterrn_Flyweight
{
    //Na verdade, essa é só a interface para o nosso Flyweight!
        //Essa classe fornece a a interface para desenho da imagem em um ponto.
    public abstract class ISpriteFlyweight //Em C#, utilizamos "I" antes do nome da classe para indicar que ela é uma Interface!
    {
        public abstract void desenharImagem(Ponto ponto);
        public abstract string desenharNoConsole(Ponto ponto);
    }
}
