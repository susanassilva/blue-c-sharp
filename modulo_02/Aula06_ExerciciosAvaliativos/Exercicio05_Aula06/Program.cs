using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05_Aula06
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Abreviando nomes ----");

            Abreviando abrevia1 = new Abreviando();


            Console.WriteLine("\n\n---- Invertendo strings ----");

            Console.WriteLine("\nEscreva um texto qualquer para vê-lo invertido ");
            Console.Write("> ");
            string texto = Console.ReadLine();

            abrevia1.Invertendo(texto);


            Console.WriteLine("\n\n---- Contando vogais e consoantes ----");

            Console.WriteLine("\nEscreva um texto: ");
            Console.Write("> ");
            string texto2 = Console.ReadLine();

            abrevia1.Contagem(texto2);
        }
    }
}
