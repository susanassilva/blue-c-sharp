using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            numeros[0] = 3;
            numeros[1] = 6;
            numeros[2] = 8;
            numeros[3] = 12;

            Console.WriteLine(numeros[0]);
            int[] outrosNumeros = new int[4] { 11, 22, 33, 44 };
            Console.WriteLine(outrosNumeros[3]);

            int[] novoVetor = { 11, 22, 44, 5, 9, 10 };
            Console.WriteLine(novoVetor.Length);

            

            Console.ReadLine();
        }
    }
}
