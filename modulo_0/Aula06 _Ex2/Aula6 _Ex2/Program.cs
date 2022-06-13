using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6__Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Par ou Ímpar ------");
            float n1 = float.Parse(Console.ReadLine());
            if (n1 % 2 == 0)
            {
                Console.WriteLine("É par");
            } else
            {
                Console.WriteLine("É ímpar");
            }

            Console.ReadLine();
        }
    }
}
