using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_Exercicio
{
    internal class Triangulo : Forma
    {
        public override void Calcular()
        {
            Console.WriteLine("Digite a base: ");
            double baseTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            double altura = double.Parse(Console.ReadLine());

            var area = (baseTriangulo * altura)/2;

            Console.WriteLine(area);
        }
    }
}
