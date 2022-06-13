using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalculaIdade();
            //Soma();
            CalculaHoras();
            //CalculaIdade2();
            //Conversor();
        }

        static void CalculaIdade()
        {
            Console.WriteLine("Digite seu ano de nascimento: ");
            int ano = int.Parse(Console.ReadLine());
            int calculadoraIdade = 2022 - ano;

            Console.WriteLine($"Sua idade é: {calculadoraIdade}");
            Console.ReadLine();

        }

        static void Soma()
        {
            int i = 1;
            double numeros, total = 0;
            while (i <= 10)
            {
                Console.WriteLine("Digite um número");
                numeros = double.Parse(Console.ReadLine());

                total = numeros + total;

                i++;
            }

            Console.WriteLine(total);
            Console.ReadLine();
        }

        static void CalculaHoras()
        {
            float horas, valor, salario;
            char opcao = 's';

            while(opcao == 's'){
                Console.WriteLine("Digite o nome do funcionário: ");
                string nomeFuncionario = Console.ReadLine();

                Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
                horas = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor recebido por hora trabalhada: ");
                valor = float.Parse(Console.ReadLine());

                salario = horas * valor;

                Console.WriteLine($"A(o) funcionária(o) {nomeFuncionario} receberá ${salario}");

                Console.Write("Deseja calcular demais funcionários? Se sim, digite 's', senão digite 'n': ");
                opcao = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Pressione enter para sair do programa");
            Console.ReadLine();

        }

        static void CalculaIdade2()
        {
            Console.WriteLine("Digite seu ano de nascimento: ");
            int ano = int.Parse(Console.ReadLine());
            int anos = 2022 - ano;
            int meses = anos * 12;
            int dias = anos * 365;


            Console.WriteLine($"Sua idade em anos é: {anos} \nSua idade em meses é: {meses} \nSua idade em dias é: {dias}");
            Console.WriteLine("Pressione enter para sair do programa");
            Console.ReadLine();
        }

        static void Conversor()
        {
            Console.OutputEncoding = Encoding.UTF8;
            double real, dolar, euro, libraEsterlina, dolarCanadense, pesoArgentino, pesoChileno;
            
            Console.Write("Digite o valor em real a ser convertido: R$ ");
            real = double.Parse(Console.ReadLine());


            dolar = real * 4.87;
            euro = real * 5.21;
            libraEsterlina = real * 6.12;
            dolarCanadense = real * 3.88;
            pesoArgentino = real * 0.040;
            pesoChileno = real * 0.0059;

            Console.WriteLine($"\nSeguem os valores convertidos de R$ {real}: \n Dólar: US$ {dolar} \n Euro: € {euro} " +
                $"\n Libra Esterlina: £ {libraEsterlina} \n Dólar Canadense: C$ {dolarCanadense} \n Peso Argentino: $ {pesoArgentino} \n Peso Chileno: CLP$ {pesoChileno}");

            Console.WriteLine("\n\nPressione enter para sair do programa");
            Console.ReadLine();
            
        }

    }
}
