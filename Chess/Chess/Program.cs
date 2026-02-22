using Chess;
using Chess.tabuleiro;
using Chess.Xadrez;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();

            while (!partida.terminada)
            {
                try
                {
                    Console.Clear();
                    Tela.imprimirPartida(partida);

                    Console.WriteLine();
                    Console.WriteLine("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosicaoOrigem(origem);

                    bool[,] posicoesPossiveis = partida.tabuleiro.pecas(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tabuleiro, posicoesPossiveis);

                    Console.Clear();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosicaoDestino(origem, destino);

                    partida.realizarJogada(origem, destino);
                }
                catch (TabuleiroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        catch (TabuleiroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}