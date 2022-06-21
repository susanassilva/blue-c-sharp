using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a forma você deseja calcular? ");
            Console.WriteLine("1 - Quadrado");
            Console.WriteLine("2 - Triângulo");
            Console.WriteLine("3 - Círculo");

            string Alternativa = Console.ReadLine();

            switch (Alternativa)
            {
                case "1":
                    Quadrado quadrado = new Quadrado();
                    quadrado.Calcular();
                    break;
                
                case "2":
                    Triangulo triangulo = new Triangulo();
                    triangulo.Calcular();
                    break;
                
                case "3":
                    Circulo circulo = new Circulo();
                    circulo.Calcular();
                    break;

                default:
                    Console.WriteLine("Forma inválida");
                    break;

            }


        }
    }
}
