using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogodeXadrez.tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas; 

        public Tabuleiro(int linha, int coluna)
        {
            this.linhas = linha;
            this.colunas = coluna;
            this.pecas = new Peca[linha, colunas];
        }
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
    }
}
