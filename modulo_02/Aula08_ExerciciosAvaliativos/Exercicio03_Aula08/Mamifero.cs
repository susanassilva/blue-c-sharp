using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03_Aula08
{
    public class Mamifero : Animal
    {
        public string Alimento { get; set; }
        public Mamifero(string nome, bool temPatas, int qtdPatas, string cor, string ambiente, double velocidadeMedia, string reino, string alimento) : base(nome, temPatas, qtdPatas, cor, ambiente, velocidadeMedia, reino)
        {
            this.Alimento = alimento;
        }

        public string ImprimirMamifero()
        {
            var impressao = $"\n---- Imprimindo dados do animal ----\n" +
                            $"\nDados do mamífero:" + base.Dados() +
                            "\nAlimento: {Alimento} \n---- Impressão de dados concluída ----";

            return impressao;
        }
    }
}
