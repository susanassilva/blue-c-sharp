using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03_Aula09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.Acelerar();
            carro.Freiar();
            Console.WriteLine(carro.TrocarOleo());

            Bicicleta bicicleta = new Bicicleta();
            bicicleta.Acelerar();
            bicicleta.Freiar();
            bicicleta.AjustarCorreia();
        }
    }
}
