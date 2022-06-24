using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02_Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var opcao = "1";
            while (opcao == "1")
            {
                Console.WriteLine("----- Gerenciador de Salários -----\n");
                Console.WriteLine("\nDigite o nome do empregado: ");
                Console.Write("> ");
                string nome = Console.ReadLine();

                Console.WriteLine("\nDigite o cargo do empregado: ");
                Console.Write("> ");
                string cargo = Console.ReadLine();

                Console.WriteLine("\nDigite o salário do empregado");
                Console.Write("> ");
                double salario = double.Parse(Console.ReadLine());

                Empregado empregado1 = new Empregado(nome, cargo, salario);

                Console.WriteLine(
                    $"\nDeseja verificar outros salários? Digite 1 para verificar ou Digite 2 para sair da aplicação");
                Console.Write("> ");
                opcao = Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}
