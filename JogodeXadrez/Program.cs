using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using JogodeXadrez;
using JogodeXadrez.tabuleiro;
using JogodeXadrez.xadrez;

namespace JogodeXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
                tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(2, 4));

                tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicao(1, 5));
                tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicao(3, 7));
                tab.colocarPeca(new Rei(Cor.Branca, tab), new Posicao(3, 4));

                Tela.imprimirTabuleiro(tab);

                Console.WriteLine();
                PosicaoXadrez pos = new PosicaoXadrez('d', 8);
                Console.WriteLine(pos);

                Console.WriteLine(pos.ToPosicao().ToString());



                Console.ReadLine();
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}