using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05_Aula06
{
    public class Abreviando
    {
        //public void remocaosubstring()
        //{

        //}

        public Abreviando()
        {
            Console.WriteLine("\nDigite seu nome completo: ");
            Console.Write("> ");
            string nomeCompleto = Console.ReadLine();

            
            string[] separandoNomeEmStrings = nomeCompleto.Split(' ');
            foreach(string sub in separandoNomeEmStrings){
                if (sub.Length < 3)
                {
                    Console.Write($"{sub.Substring(0, 2)}. ");
                }
                else
                {
                    Console.Write($"{sub.Substring(0, 1)}. ");
                }

            }



        }

        public string Invertendo(string frase)
        {
            string textoInvertido = new string(frase.Reverse().ToArray());

            Console.WriteLine($"Texto invertido: {textoInvertido}");
            return textoInvertido;
        }

        public int Contagem(string textoQualquer)
        {
            char caracter = ' ';
            int vogaisContagem = 0;
            int consoantesContagem = 0;
            string textoNormalizado = textoQualquer.ToLower();

            for (int i = 0; i < textoNormalizado.Length; i++)
            {
                caracter = textoNormalizado[i];

                if((caracter == 'a') || (caracter == 'e') || (caracter == 'i') || (caracter == 'o') || (caracter == 'u'))
                {
                    vogaisContagem += 1;
                } else if ((caracter == 'á') || (caracter == 'à') || (caracter == 'â') || (caracter == 'ã') || (caracter == 'é') ||
                           (caracter == 'ê') || (caracter == 'í') || (caracter == 'ó') || (caracter == 'ô') || (caracter == 'õ') || (caracter == 'ú'))
                {
                    vogaisContagem += 1;
                }
                else if ((caracter == '!') || (caracter == ',') || (caracter == '.') || (caracter == ';') ||
                         (caracter == '?') || (caracter == ':') || (caracter == '-') || (caracter == ' '))
                {
                    continue;
                } else { 
                    consoantesContagem += 1;
                }
                             
            }


            //


            Console.WriteLine($"\nQuantidade de vogais na frase '{textoQualquer}': {vogaisContagem}");
            Console.WriteLine($"\nQuantidade de consoantes na frase '{textoQualquer}': {consoantesContagem}\n\n");
            return 0;
        }
    }
}
