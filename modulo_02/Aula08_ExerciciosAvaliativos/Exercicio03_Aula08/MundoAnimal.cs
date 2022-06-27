using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03_Aula08
{
    public class MundoAnimal
    {
        

        Peixe peixe1 = new Peixe("Olaf", false, 0, "laranja", "mar", 10.2, "cordados", "peixe palhaço");
        Mamifero mamifero1 = new Mamifero("Krypto", true, 4, "caramelo", "doméstico", 20.1, "cordados", "ração");

        public List<string> listaAnimais = new List<string>();
        

        public MundoAnimal()
        {

            string peixeImprime = peixe1.ImprimeRelatorioPeixe();
            string mamiferoImprime = mamifero1.ImprimirMamifero();

            listaAnimais.Add(peixeImprime);
            listaAnimais.Add(mamiferoImprime);

            foreach (var n in listaAnimais)
            {
                Console.WriteLine(n);
            }


        }

        
    }
}
