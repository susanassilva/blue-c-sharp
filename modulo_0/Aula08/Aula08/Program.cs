using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 20; i++) //dentro do escopo do for
            {
                Console.WriteLine($"{i+1} Olá, Bluemer!");
            }

            

            for(int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);

            }

            Console.WriteLine("Feliz Ano Novo!");


            int c = 0; //fora do escopo do while
            while (c > -2){
                Console.WriteLine($"{c} Oie, Bluemer");
                c--;
            }


            Console.ReadLine();

        }
    }
}
