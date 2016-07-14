using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterrn_Flyweight
{
    //Essa nossa classe "fábrica" é a Flyweight Factory.
    //Ela cria os vários objetos flyweight que serão compartilhados.
    public class FlyweightFactory
    {
        protected List<ISpriteFlyweight> flyweights;

        public enum Sprites{
            JOGADOR, INIMIGO_1, INIMIGO_2, INIMIGO_3, CENARIO_1, CENARIO_2
        }

        public FlyweightFactory()
        {
            flyweights = new List<ISpriteFlyweight>();
            flyweights.Add(new Sprite("jogador.png"));
            flyweights.Add(new Sprite("inimigo1.png"));
            flyweights.Add(new Sprite("inimigo2.png"));
            flyweights.Add(new Sprite("inimigo3.png"));
            flyweights.Add(new Sprite("cenario1.png"));
            flyweights.Add(new Sprite("cenario2.png"));
        }

        //A classe fábrica também oferece um método para obter o objeto.
        //Assim, o acesso a estes objetos fica centralizado e unificado a partir desta classe.
        public ISpriteFlyweight getFlyweight(Sprites jogador)
        {
            switch (jogador)
            {
                case Sprites.JOGADOR:
                    return flyweights.ElementAt(0);
                case Sprites.INIMIGO_1:
                    return flyweights.ElementAt(1);
                case Sprites.INIMIGO_2:
                    return flyweights.ElementAt(2);
                case Sprites.INIMIGO_3:
                    return flyweights.ElementAt(3);
                case Sprites.CENARIO_1:
                    return flyweights.ElementAt(4);
                default:
                    return flyweights.ElementAt(5);
            }
        }
    }
}
