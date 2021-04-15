using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 2));

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(5,0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 7));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(2, 5));
                Tela.imprimirTabuleiro(tab);
                Console.ReadLine();
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
