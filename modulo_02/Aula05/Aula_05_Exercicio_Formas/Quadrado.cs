using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_Exercicio
{
    internal class Quadrado : Forma
    {
        public override void Calcular()
        {
            Console.WriteLine("Digite a medida de um dos lados: ");
            double baseQuadrado = double.Parse(Console.ReadLine());

            var area = baseQuadrado * baseQuadrado;

            Console.WriteLine(area);
        }

        //l²

    }
}
