using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03_Aula08
{
    public class Peixe : Animal
    {
        public string Caracteristicas { get; set; }
        public Peixe(string nome, bool temPatas, int qtdPatas, string cor, string ambiente, double velocidadeMedia, string reino, string caracteristicas) : base(nome, temPatas, qtdPatas, cor, ambiente, velocidadeMedia, reino)
        {
            this.Caracteristicas = caracteristicas;
        }

        public string ImprimeRelatorioPeixe()
        {
            var impressao = $"\n---- Imprimindo dados do animal ----\n" +
                            $"\nDados do peixe:" + base.Dados() +
                            $"\nCaracterísticas: {Caracteristicas} \n---- Impressão de dados concluída ----";

            return impressao;

        }
    }
}
