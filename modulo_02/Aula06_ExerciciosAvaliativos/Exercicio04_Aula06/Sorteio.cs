using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04_Aula06
{
    public class Sorteio
    {
        public int AdivinhaNumero;

        public Sorteio()
        {

            int contador = 0;

            Random numeroRandom = new Random();
            int ranNum = numeroRandom.Next(0, 1001);

            var aux = 1002;

            while (aux != ranNum)
            {
                
                Console.WriteLine("\nQual o seu palpite? ");
                Console.Write("> ");
                aux = int.Parse(Console.ReadLine());
                

                if (aux == ranNum)
                {
                    Console.WriteLine("\nParabéns você acertou!!");
                    contador += 1;
                    Console.WriteLine($"\nVocê fez {contador} tentativas até acertar");
                    break;
                }
                else
                {
                    Console.WriteLine("\nTente Novamente!!");
                    contador++;
                    if (ranNum > aux)
                    {
                        Console.WriteLine("\nUma dica: aumente mais esse número");

                    } else if (ranNum < aux)
                    {
                        Console.WriteLine("\nUma dica: diminua um pouco o número");

                    }
                }
            }
        }
    }
}
