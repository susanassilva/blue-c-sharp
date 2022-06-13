using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cadastro();
        }

        static void Cadastro() 
        {
            Console.WriteLine("---- Cadastro de Usuários ----");

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Cidade: ");
            string cidade = Console.ReadLine();

            Console.WriteLine($"{nome}, {cidade}");
            Console.ReadLine();
        }

        static void Tipo()
        {
            int valorInteiro = 59;
            double valorFloat = 5.56;
            bool valorBoolean = false;

            Console.Write(Convert.ToString(valorInteiro));
        }
    }
}
