using System;
using tabuleiro;
using xadrez_console;


namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            Tabuleiro tab = new Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}