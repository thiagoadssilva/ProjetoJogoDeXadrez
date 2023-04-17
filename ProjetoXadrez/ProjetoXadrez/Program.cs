using ProjetoXadrez;
using ProjetoXadrez.tabuleiro;
using ProjetoXadrez.tabuleiro.enums;
using ProjetoXadrez.tabuleiro.Exceptions;
using ProjetoXadrez.xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while(!partida.Terminada){
        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab);
        Console.WriteLine();

        Console.Write("Origem: ");
        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

        bool[,] posicoesPossiveis = partida.tab.Peca(origem).MovimentosPossiveis();

        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

        Console.WriteLine();
        Console.Write("Destino: ");
        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

        partida.ExecutarMovimento(origem, destino);
        Tela.imprimirTabuleiro(partida.tab);
    }
    


    
}
catch (TabuleiroExeception e){
    Console.WriteLine("Erro: " + e.Message);
}


