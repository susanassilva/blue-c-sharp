using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            int[] nums = new int[4];

            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Digite um número: ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("---- Números digitados ----");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Na posição {i+1} = {nums[i]}");
            }

            Console.ReadLine();
        }
    }
}
