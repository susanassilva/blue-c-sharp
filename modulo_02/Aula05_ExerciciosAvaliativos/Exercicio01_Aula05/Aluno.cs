using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_Aula05
{
    public class Aluno
    {
            public string Nome;
            public int Matricula;
            public float RecebeNotas()
            {
                float notas = 0.00f;

                Console.WriteLine("Digite a primeira nota do aluno: ");
                float nota1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a segunda nota do aluno: ");
                float nota2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a nota do trabalho do aluno: ");
                float nota3 = Convert.ToInt32(Console.ReadLine());
                notas = nota1 + nota2 + nota3;

                return notas;
            }


            public float CalculaMedia(float notas)
            {
                float media = 0.00f;

                media = notas / 3;

                return media;
            }
    }
}
