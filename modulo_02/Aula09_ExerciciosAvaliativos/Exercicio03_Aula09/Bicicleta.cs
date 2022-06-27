using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03_Aula09
{
    internal class Bicicleta : Veiculos
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando!");
        }

        public override void Freiar()
        {
            Console.WriteLine("Freiando!");
        }

        public string AjustarCorreia()
        {
            return "Ajuste realizado!";
        }
    }
}
