using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual tabuada? ");

            int tabuada = int.Parse(Console.ReadLine());

            Console.WriteLine($"A tabuada de {tabuada} é: ");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
            }
            
            Console.ReadLine();

        }
    }
}
