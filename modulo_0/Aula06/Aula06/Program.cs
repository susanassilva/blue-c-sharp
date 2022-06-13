using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("------- Média do Aluno -------");

            Console.Write("\nNota 1: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            float n3 = float.Parse(Console.ReadLine());

            float media = (n1 + n2 + n3) / 3;
            Console.WriteLine($"A média do aluno foi: {media}");


            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado");

            } else if (media >=5 && media < 7.0){

                Console.WriteLine("Aluno em recuperação");

            } else
            {
                Console.WriteLine("Aluno reprovado");
            }

            Console.ReadLine();
            
            




        }
    }
}
