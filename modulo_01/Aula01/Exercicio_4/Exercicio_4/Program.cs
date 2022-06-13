using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Elabore um programa que exibe uma mensagem que incentive outras mulheres a entrar na tecnologia.

            int opcao;

            char continuar = 's';

            while (continuar == 's')
            {
                Console.WriteLine("Digite um número de 1 até 4: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1 || opcao == 4)
                {
                    Console.WriteLine("A frase mais perigosa que existe em um idioma é ‘Nós sempre fizemos assim, Grace Hopper (vulgo vovó do Cobol)");
                }
                else if (opcao == 2 || opcao == 3)
                {
                    Console.WriteLine("Devemos acreditar que somos talentosos para algumas coisas, e que essa coisa, a qualquer custo, deve ser alcançada, Marie Curie (primeira mulher a vencer um Nobel)");
                }
                else
                {
                    Console.WriteLine("Achou que não receberia nenhuma frase por digitar um número qualquer, né? Achou errado!!! \n \n'A computação é muito importante para ser deixada aos homens', Karen Jones (a criadora da noção de sites de busca)'");
                }

                Console.WriteLine("\nDeseja continuar, digite 's' para sim e 'n' para não: ");
                continuar = char.Parse(Console.ReadLine());

            }
                
            
            Console.WriteLine("\nTemos excelentes exemplos de mulheres na tecnologia, por qual motivo você não pode ser um deles?");
            

            Console.WriteLine("Pressione Enter para sair do programa");
            Console.ReadLine();
        }
    }
}
