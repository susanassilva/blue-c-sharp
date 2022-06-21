using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Aula05
{
    public class Program
    {
        static void Main()
        {
            Aluno aluno = new Aluno();
            aluno.Matricula = 199992003;
            aluno.Nome = "Maria";
            float media = aluno.RecebeNotas();
            Console.WriteLine(aluno.CalculaMedia(media));
        }
    }
}
