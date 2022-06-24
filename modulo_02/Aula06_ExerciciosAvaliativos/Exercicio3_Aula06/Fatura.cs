using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_Aula06
{
    public class Fatura
    {
        public int NumeroProduto;
        public string DescricaoProduto;
        public int QuantidadeCompradaProduto;
        public double PrecoProduto;


        public Fatura(int numeroProduto, string descricaoProduto, int quantidadeCompradaProduto, double precoProduto)
        {
            NumeroProduto = numeroProduto;
            DescricaoProduto = descricaoProduto;
            QuantidadeCompradaProduto = quantidadeCompradaProduto;
            PrecoProduto = precoProduto;
        }

    }
}
