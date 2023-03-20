using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogodeXadrez.Tabuleiro;

namespace JogodeXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);
            Console.WriteLine("Posicao: " + P.linha + P.coluna);

            Console.WriteLine(); 

        }
    }
}