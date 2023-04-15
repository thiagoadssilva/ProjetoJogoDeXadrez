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
        public Posicao Posical { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca() { }

        public Peca(Posicao posical, Cor cor, Tabuleiro tab) 
        {
            Posical = posical;
            Cor = cor;
            QteMovimentos = 0;
            Tab = tab;
        }
    }
}
