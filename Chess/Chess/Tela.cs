using Chess.tabuleiro;
using Chess.Xadrez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    static class Tela
    {
        public static void imprimirTabuleiro(PartidaDeXadrez partida)
        {

            for (int i = 0; i < partida.tabuleiro.linhas; i++)
            {
                Console.WriteLine(8 - i + "");
                for (int j = 0; j < partida.tabuleiro.colunas; j++)
                {
                    Console.WriteLine(partida.tabuleiro.pecas[i, j]);
                }
            }
            Console.WriteLine("  a b c d e f g h");

        }

        public static void imprimirPartida(PartidaDeXadrez partida)
        PosicaoXadrez

        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
    }
}
