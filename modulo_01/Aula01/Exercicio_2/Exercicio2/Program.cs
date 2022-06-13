using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escolha uma mulher famosa na história da tecnologia e implemente um programa que escreve seu nome,
            //sua formação e uma contribuição feita por ela dentro da tecnologia em linhas separadas.
            string nomeWoman, formacao, contribuicaoTech;
            nomeWoman = "Hedy Lamarr";
            formacao = "atriz";
            contribuicaoTech = "Wi-fi and GPS";
            Console.WriteLine($"\n{nomeWoman} \n{formacao} \n{contribuicaoTech}");
        }
    }
}
