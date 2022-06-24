using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_Aula07
{
    public class Aluno
    {
        private string nome;
        private int matricula;
        private double nota1;
        private double nota2;
        private double frequencia;

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public int Matricula
        {
            get { return this.matricula; }
            set { this.matricula = value; }
        }

        public double Notas1
        {
            get { return this.nota1; }
            set { this.nota1 = value; }
        }

        public double Notas2
        {
            get { return this.nota2; }
            set { this.nota2 = value; }
        }

        public double Frequencia
        {
            get { return this.frequencia; }
            set { this.frequencia = value; }
        }


        public Aluno()
        {

            var listaAluno = CadastroAlunos();
            var consulta = ConsultaAluno(listaAluno);

        }

        public List<string> CadastroAlunos()
        {
            Console.WriteLine(" ---- Cadastro de Alunos ---- ");

            var lista = new List<string>();

            var alternativa = "1";

            while (alternativa == "1")
            {
                
                Console.WriteLine("Nome do aluno:");
                Console.Write("> ");
                var nome = Console.ReadLine();

                Console.WriteLine($"Matrícula do estudante {nome}:");
                Console.Write("> ");
                int matricula = int.Parse(Console.ReadLine());

                Console.WriteLine("1ª nota: ");
                Console.Write("> ");
                int nota1 = int.Parse(Console.ReadLine());


                Console.WriteLine("2ª nota: ");
                Console.Write("> ");
                int nota2 = int.Parse(Console.ReadLine());


                var media = (nota1 + nota2) / 2;
                lista.Add(($"{nome}, {matricula}, {media}"));

                Console.WriteLine("Deseja continuar a cadastrar? 1 - sim, 2 - não");
                Console.Write("> ");
                alternativa = Console.ReadLine();
            }

            return lista;

        }

        public string ConsultaAluno(List<string> listaAluno)
        {
            Console.WriteLine("--- Consulta Alunos ---");
            
            
            Console.Write("> ");
            var nome = Console.ReadLine();

            for (var i = 0; i < listaAluno.Count; i++)
            {
                if (listaAluno[i] == nome)
                {
                    Console.WriteLine(listaAluno[i]);
                }
            }
          

            return "oi";
        }

    }
}
