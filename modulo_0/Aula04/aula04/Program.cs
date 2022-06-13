using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, localNascimento;
            int idade;

            Console.WriteLine("---------- Cadastro de Usuários ----------");
            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Naturalidade: ");
            localNascimento = Console.ReadLine();

            Console.WriteLine("\n---------- Impressão de Dados ----------");
            Console.WriteLine($"Nome: {nome} \nIdade: {idade} \nNaturalidade: {localNascimento}");
            Console.Read();



            

        }
    }
}
