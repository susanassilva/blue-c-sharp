using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_Aula05
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
         
            Console.WriteLine("Digite a matrícula do aluno");
            aluno.Matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do aluno");
            aluno.Nome = Console.ReadLine();

            float media = aluno.RecebeNotas();
            Console.WriteLine(aluno.CalculaMedia(media));
        }
    }
}
