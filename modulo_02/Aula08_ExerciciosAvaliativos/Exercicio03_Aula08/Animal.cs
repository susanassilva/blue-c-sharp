using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03_Aula08
{
    public class Animal
    {
        public string Nome { get; set; }
        public bool TemPatas { get; set; }
        public int QtdPatas { get; set; }
        public string Cor { get; set; }
        public string Ambiente { get; set; }
        public double VelocidadeMedia { get; set; }
        public string Filo { get; set; }

        public Animal(string nome, bool temPatas, int qtdPatas, string cor, string ambiente, 
               double velocidadeMedia, string filo)
        {
            this.Nome = nome; 
            this.TemPatas = temPatas;
            this.QtdPatas = qtdPatas;
            this.Cor = cor;
            this.Ambiente = ambiente;
            this.VelocidadeMedia = velocidadeMedia;
            this.Filo = filo;
        }

        public string Dados()
        {

            return $"\nNome: {Nome}" +
                              $"\nTem Patas: {TemPatas}" +
                              $"\nQuantidade de Patas: {QtdPatas} " +
                              $"\nCor do Animal: {Cor} " +
                              $"\nAmbiente em que vive: {Ambiente}" +
                              $"\nVelocidade Média: {VelocidadeMedia}" +
                              $"\nFilo: {Filo}";

            

        }
    }
}
