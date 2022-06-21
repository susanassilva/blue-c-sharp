using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Descomente com CTRL + U + K o nome do programa que deseja executar;
            //Para comentá-lo digite CTRL + C;
            CalculaCedula();
            //MaiorValor();
            //CalculadoraMedia();
            //CalculaFaixasMedias();
            //AumentoSalario();
        }

        static void CalculaCedula()
        {
            /*Leia um valor de ponto flutuante com duas casas decimais. 
             * Este valor representa um valor monetário. A seguir, calcule o 
             * menor número de notas e moedas possíveis no qual o valor pode ser decomposto.As notas consideradas 
             * são de 100, 50, 20, 10, 5, 2.*/

            Console.WriteLine("----- Caixa -----");

            char opcao = 'S';
            float valor = 0.0f;
            float valor2 = 0;
            double[] notas =  { 100, 50, 20, 10, 5, 2 };

            while (opcao == 'S')
            {
                Console.WriteLine("\nDigite um valor para decompormos o valor: ");
                valor = float.Parse(Console.ReadLine());

                for (int i = 0; i < notas.Length; i++)
                {
                        valor2 = (int) (valor / notas[i]);
                        valor = (int) (valor % notas[i]);
                        Console.WriteLine($"{valor2} nota(s) de {notas[i]}");
                }

                Console.WriteLine("\nDeseja continuar, 'S' para sim e 'N' para não: ");
                opcao = char.Parse(Console.ReadLine());
            }

            Console.ReadLine();

        }

        static void MaiorValor()
        {
            /*Faça um programa que leia três valores e apresente 
             * o maior dos três valores lidos seguido da mensagem “x é o maior”.
             */
            int val, val2, val3;
            
            Console.WriteLine("Digite um valor: ");
            val = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo valor: ");
            val2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            val3 = int.Parse(Console.ReadLine());

            if (val > val2 && val > val3)
            {
                Console.WriteLine($"o valor {val} é maior");
            }
            else if (val2 > val && val2 > val3)
            {
                Console.WriteLine($"o valor {val2} é maior");
            }
            else
            {
                Console.WriteLine($"o valor {val3} é maior");
            }

            Console.ReadLine();
        }

        static void CalculadoraMedia()
        {
            //Leia 3 valores que são as três notas de um aluno.
            //A seguir, calcule a média do aluno.Considere que cada nota pode ir de 0 até 10.0,
            //sempre com uma casa decimal.Imprima se o aluno foi aprovado ou reprovado considerando a média 7.

            var opcao = 'S';
            float[] notas = new float[3];
            float media = 0.0f;
            float calculoMedia;

            Console.WriteLine("----- Cálculo de Média -----");


            while (opcao == 'S')
            {

                for (int i = 0; i < notas.Length; i++)
                {


                    Console.WriteLine($"\nDigite a nota {i+1}: ");
                    notas[i] = float.Parse(Console.ReadLine());

                    media += notas[i];
                }

                calculoMedia = (float) (media / 3);
                string resultado = (calculoMedia >= 7.0) ? "Aluno Aprovado" : "Aluno Reprovado";

                Console.WriteLine($"A média do aluno foi: {calculoMedia: 0.00}. {resultado}");
            
                
                Console.WriteLine("\nDeseja continuar com mais cálculos, 'S' para sim e 'N' para não? ");
                opcao = char.Parse(Console.ReadLine());
                media = 0;
                if(opcao != 'S')
                {
                    Console.Write("Aperte enter para sair");
                }
            }

            Console.ReadLine();

        }

        static void CalculaFaixasMedias()
        {
            var opcao = 'S';
            float[] notas = new float[3];
            float media = 0.0f;
            float calculoMedia;
            string resultado = "";

            Console.WriteLine("----- Cálculo de Média -----");


            while (opcao == 'S')
            {

                for (int i = 0; i < notas.Length; i++)
                {


                    Console.WriteLine($"\nDigite a nota {i + 1}: ");
                    notas[i] = float.Parse(Console.ReadLine());

                    media += notas[i];
                }

                calculoMedia = (float)(media / 3);

                if (calculoMedia > 9.0)
                {
                    resultado = "A. Parabéns!";
                }
                else if (calculoMedia > 8.0 && calculoMedia <= 9.0)
                {
                    resultado = "B. Parabéns!";
                } else if (calculoMedia > 7.0 && calculoMedia <= 8.0)
                {
                    resultado = "C. No limite, treine um pouco mais";
                } else if (calculoMedia > 6.0 && calculoMedia <= 7.0)
                {
                    resultado = "D. Reprovado!";
                }
                else
                {
                    resultado = "F. Reprovado!";
                }

                Console.WriteLine($"O aluno tirou {resultado}");


                Console.WriteLine("\nDeseja continuar com mais cálculos, 'S' para sim e 'N' para não? ");
                opcao = char.Parse(Console.ReadLine());
                media = 0;

                if (opcao != 'S')
                {
                    Console.Write("Aperte enter para sair");
                }
            }

            Console.ReadLine();

        }
    
    

        static void AumentoSalario(){
            /* A Blue resolveu dar um aumento de salários a seus funcionários 
             * de acordo com os dados abaixo:
            Salário de 0 até 400.00 ganha 15% Salário de 400.01 até 800.00 ganha 12% 
            Salário de 800.01 até 1200.00 ganha 10% 
            Salário de 1200.01 até 2000.00 ganha 7% 
            Acima de 2000.00 ganha 4%
            Leia o salário do funcionário e calcule e mostre o novo salário, 
            bem como o valor de reajuste ganho e o índice reajustado, em percentual.
             */

            //Exemplo de Entrada 400.00
            //Exemplo de Saída Novo salario: 460.00 Reajuste ganho: 60.00 Em percentual: 15 %
            double valorInicial, valorFinal, diferencaValor;
            char opcao = 'S';


            while (opcao == 'S')
            {

                Console.WriteLine("Digite o salário do funcionário: ");
                valorInicial = double.Parse(Console.ReadLine());

                if (valorInicial <= 400.00)
                {
                    diferencaValor = (float)valorInicial * 0.15;
                    valorFinal = (float)valorInicial + diferencaValor;
                    Console.WriteLine(
                        $"Novo Salário {valorFinal:0.00} Reajuste Ganho {diferencaValor: 0.00} Índice Reajustado: 15%");
                }
                else if (valorInicial > 400.00 && valorInicial <= 800.00)
                {
                    diferencaValor = (float)valorInicial * 0.12;
                    valorFinal = (float)valorInicial + diferencaValor;
                    Console.WriteLine(
                        $"Novo Salário {valorFinal:0.00} Reajuste Ganho {diferencaValor: 0.00} Índice Reajustado: 12%");
                }
                else if (valorInicial > 800.00 && valorInicial <= 1200.00)
                {
                    diferencaValor = (float)valorInicial * 0.10;
                    valorFinal = (float)valorInicial + diferencaValor;
                    Console.WriteLine(
                        $"Novo Salário {valorFinal:0.00} Reajuste Ganho {diferencaValor: 0.00} Índice Reajustado: 10%");
                }
                else if (valorInicial > 1200.00 && valorInicial <= 2000.00)
                {
                    diferencaValor = (float)valorInicial * 0.07;
                    valorFinal = (float)valorInicial + diferencaValor;
                    Console.WriteLine(
                        $"Novo Salário {valorFinal:0.00} Reajuste Ganho {diferencaValor: 0.00} Índice Reajustado: 7%");
                }
                else
                {
                    diferencaValor = (float)valorInicial * 0.04;
                    valorFinal = (float)valorInicial + diferencaValor;
                    Console.WriteLine(
                        $"Novo Salário {valorFinal:0.00} Reajuste Ganho {diferencaValor: 0.00} Índice Reajustado: 4%");
                }
                Console.WriteLine("\nDeseja continuar com mais cálculos, 'S' para sim e 'N' para não? ");
                opcao = char.Parse(Console.ReadLine());
                
                if (opcao != 'S')
                {
                    Console.Write("Aperte enter para sair");
                }

            }


            Console.ReadLine();

        }

    }
    
}

