using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Media();

        }

        static void Operadores()
        {
            //
            int num = 10;
            int num2 = 15;

            Console.WriteLine(num == num2);
            Console.WriteLine(num2 != num);
            Console.WriteLine(num > num2);
            Console.WriteLine(num < num2);
            Console.WriteLine(num <= num2);

            Console.ReadLine();
        }

        static void Media()
        {
            Console.WriteLine("** Cálculo da Média **");

            float nota1, nota2, nota3, media;

            Console.WriteLine("Digite a Nota 1: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Nota 2: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Nota 3: ");
            nota3 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            if(media >= 7)
            {
                Console.WriteLine("Aprovado!");
            } else if(media >= 5 && media < 7) {
                Console.WriteLine("Em recuperação");
            } else
            {
                Console.WriteLine("Reprovado");
            }

            //Operador Ternário:
            // variavel = (condição) ? resultadoVerdadeiro : resultadoFalso

            Console.ReadLine();

        }
    }
}

