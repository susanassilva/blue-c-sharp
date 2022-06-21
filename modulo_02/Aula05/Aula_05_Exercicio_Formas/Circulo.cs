using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_Exercicio
{
    internal class Circulo : Forma
    {
        public override void Calcular()
        {
            //area * 3.14 * (raio**2)
            const double pi = 3.14;

            Console.WriteLine("Digite o raio: ");
            double raio = double.Parse(Console.ReadLine());

            var area = (pi * (raio * raio));

            Console.WriteLine(area);

        }

        
    }
}
