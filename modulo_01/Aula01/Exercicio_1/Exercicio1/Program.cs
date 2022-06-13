

using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Elabore um programa que escreve seu nome completo, seu endereço, o CEP e telefone em linhas separadas.
            string nome, endereco, cep, telefone; // preferi deixar cep e tel como string para, posteriormente, aplicar máscaras de input;

            Console.WriteLine("------ Cadastre-se ------");
            
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            
            Console.Write("Digite seu CEP: ");
            cep = Console.ReadLine();

            Console.Write("Digite seu Endereço: ");
            endereco = Console.ReadLine();

            Console.Write("Digite seu Telefone: ");
            telefone = Console.ReadLine();

            Console.WriteLine("\n------ Seus Dados ------");
            Console.Write($"\nNome: {nome} \nCEP: {cep} \nEndereço: {endereco} \nTelefone: {telefone}");

            Console.WriteLine("\nAperte Enter para sair");
            Console.ReadLine();
            

        }
    }
}