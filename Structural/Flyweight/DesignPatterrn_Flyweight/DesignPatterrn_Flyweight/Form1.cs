using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DesignPatterrn_Flyweight
{
    public partial class Form1 : Form
    {
        string console;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Iniciado!");

            //"Printando" no Debug:
            FlyweightFactory factory = new FlyweightFactory();

            factory.getFlyweight(FlyweightFactory.Sprites.CENARIO_1).desenharImagem(new Ponto(0, 0));

            factory.getFlyweight(FlyweightFactory.Sprites.JOGADOR).desenharImagem(new Ponto(10, 10));

            factory.getFlyweight(FlyweightFactory.Sprites.INIMIGO_1).desenharImagem(
                    new Ponto(100, 10));
            factory.getFlyweight(FlyweightFactory.Sprites.INIMIGO_1).desenharImagem(
                    new Ponto(120, 10));
            factory.getFlyweight(FlyweightFactory.Sprites.INIMIGO_1).desenharImagem(
                    new Ponto(140, 10));

            factory.getFlyweight(FlyweightFactory.Sprites.INIMIGO_2).desenharImagem(
                    new Ponto(60, 10));
            factory.getFlyweight(FlyweightFactory.Sprites.INIMIGO_2).desenharImagem(
                    new Ponto(50, 10));

            factory.getFlyweight(FlyweightFactory.Sprites.INIMIGO_3).desenharImagem(
                    new Ponto(170, 10));



            consoleBox.Text += factory.getFlyweight(FlyweightFactory.Sprites.CENARIO_1).desenharNoConsole(new Ponto(0, 0));

            consoleBox.Text += factory.getFlyweight(FlyweightFactory.Sprites.JOGADOR).desenharNoConsole(new Ponto(10, 10));

            consoleBox.Text += factory.getFlyweight(FlyweightFactory.Sprites.INIMIGO_1).desenharNoConsole(
                    new Ponto(100, 10));
            consoleBox.Text += factory.getFlyweight(FlyweightFactory.Sprites.INIMIGO_1).desenharNoConsole(
                    new Ponto(120, 10));
            consoleBox.Text += factory.getFlyweight(FlyweightFactory.Sprites.INIMIGO_1).desenharNoConsole(
                    new Ponto(140, 10));

            consoleBox.Text += factory.getFlyweight(FlyweightFactory.Sprites.INIMIGO_2).desenharNoConsole(
                    new Ponto(60, 10));
            consoleBox.Text += factory.getFlyweight(FlyweightFactory.Sprites.INIMIGO_2).desenharNoConsole(
                    new Ponto(50, 10));

            consoleBox.Text += factory.getFlyweight(FlyweightFactory.Sprites.INIMIGO_3).desenharNoConsole(
                    new Ponto(170, 10));


            //consoleBox.Text += "Olar";
        }
    }

}
