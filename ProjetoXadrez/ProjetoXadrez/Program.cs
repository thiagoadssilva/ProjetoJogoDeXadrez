﻿using ProjetoXadrez;
using ProjetoXadrez.tabuleiro;
using ProjetoXadrez.tabuleiro.enums;
using ProjetoXadrez.tabuleiro.Exceptions;
using ProjetoXadrez.xadrez;

try
{
    /*PosicaoXadrez pos = new PosicaoXadrez('c', 7);
    Console.WriteLine(pos);
    Console.WriteLine(pos.ToPosicao());*/

    Tabuleiro tab = new Tabuleiro(8, 8);


    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
    tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 4));

    tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 5));
    tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 5));


    Tela.imprimirTabuleiro(tab);
}
catch (TabuleiroExeception e){
    Console.WriteLine("Erro: " + e.Message);
}


