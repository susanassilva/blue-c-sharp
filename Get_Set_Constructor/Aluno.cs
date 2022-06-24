using System;

namespace Get_Set_Constructor
{
    public class Aluno
    {
        private string nome;
        private string sobrenome;
        private string codigoDaTurma;

        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }
        }

        public Aluno(string Nome, string CodigoDaTurma)
        {
            nome = Nome;
            codigoDaTurma = CodigoDaTurma;
            Cadastrar(nome, codigoDaTurma);
        }

        private void Cadastrar(string Nome, string CodigoDaTurma)
        {

        }
    }
}
