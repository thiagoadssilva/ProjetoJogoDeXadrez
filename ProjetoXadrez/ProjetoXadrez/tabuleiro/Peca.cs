using ProjetoXadrez.tabuleiro.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoXadrez.tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        //public Peca() { }

        public Peca(Tabuleiro tab, Cor cor) 
        {
            Posicao = null;
            Cor = cor;
            QteMovimentos = 0;
            Tab = tab;
        }

        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }
    }
}
