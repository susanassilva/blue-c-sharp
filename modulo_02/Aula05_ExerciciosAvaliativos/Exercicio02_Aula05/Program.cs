using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02_Aula05
{
    public class Program
    {
        static void Main(string[] args)
        {
            Voo voo33 = new Voo();
            voo33.OcuparVaga(3);
            voo33.OcuparVaga(10);
            voo33.OcuparVaga(3);
        }
    }
}
