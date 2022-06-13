using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Elabore um programa que mostre na tela uma letra de música que você gosta, o compositor e o gênero musical em linhas separadas.

            string letra, compositor, genero;

            Console.Write("--- Cadastro de música --- Fireflies.mus.br ---");

            char opcao = 's';
            
            while (opcao == 's')
            {
                Console.Write("\nDigite a letra de uma música: ");
                letra = Console.ReadLine();

                Console.Write("Digite o nome do compositor: ");
                compositor = Console.ReadLine();

                Console.Write("Digite o gênero musical: ");
                genero = Console.ReadLine();

                Console.Write("\n--- Cadastro Efetuado --- Fireflies.mus.br ---");

                Console.WriteLine($"\nVocê cadastrou os seguintes dados do compositor {compositor}: \nTrecho da música: {letra} \nGênero: {genero}");

                Console.Write("\nDeseja continuar cadastrando mais músicas? Digite 's' para 'sim' ou 'n' para 'não'");
                opcao = char.Parse(Console.ReadLine());

            }
            Console.Write("\nPressione Enter para finalizar o programa");
            Console.ReadLine();
        }
    }
}
