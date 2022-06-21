using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PercorrendoArray();
            //VerificaVetor();
            //VerificaTamanho();
            //Jokenpo();
            //JogoDaVelha();
        }

        static void PercorrendoArray()
        {
            //Crie um programa que solicite a entrada de 10 números pelo usuário,
            //armazenando-os em um vetor, e então monte outro vetor com os valores
            //do primeiro multiplicados por 5.
            //Exiba os valores dos dois vetores na tela, um em cada linha.

            float[] numeros = new float[10];
            float[] vetorMultiplicado = new float[10];
            Console.WriteLine("------- Varrendo Array -------");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite um número");
                numeros[i] = float.Parse(Console.ReadLine());
                vetorMultiplicado[i] = (float)numeros[i] * 5;

            }

            Console.WriteLine("O vetor gerado foi: " + String.Join(" ", numeros));
            Console.WriteLine("O resultado do vetor criado e multiplicado por 5 é: " +
                              String.Join(" ", vetorMultiplicado));
            Console.ReadLine();

        }

        static void VerificaVetor()
        {
            /*Crie um programa que armazene 10 números digitados pelo usuário em dois vetores:
             um somente para números pares, e outro somente para números ímpares.
             Após, exiba os valores dos dois vetores na tela, um vetor em cada linha.*/
            float[] numeros = new float[10];
            float[] vetorPar = new float[10];
            float[] vetorImpar = new float[10];

            Console.WriteLine("------- Varrendo Array -------");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite um número");
                numeros[i] = float.Parse(Console.ReadLine());

                if (numeros[i] % 2 == 0)
                {
                    vetorPar[i] += numeros[i];
                }

                else
                {
                    vetorImpar[i] += numeros[i];
                }
            }

            Console.WriteLine("\nO vetor gerado foi: " + String.Join(" ", numeros));
            Console.WriteLine("O resultado do vetor com números pares é: " + String.Join(" ", vetorPar));
            Console.WriteLine("O resultado do vetor com números ímpares é: " + String.Join(" ", vetorImpar));
            Console.ReadLine();
        }


        static void VerificaTamanho()
        {
            //Crie um programa que lê 5 palavras e as ordena em um vetor de strings pelo seu tamanho. Se o tamanho das strings for igual, deve-se manter a ordem inserida pelo usuário.
            string[] vetorPalavras = new string[5];
            int[] vetorOrdenado = new int[5];

            Console.WriteLine("------- Programa de Ordenação de Palavras por Tamanho -------");

            for (int i = 0; i < vetorPalavras.Length; i++)
            {
                Console.WriteLine("Digite uma palavra:");
                Console.Write("> ");
                vetorPalavras[i] = Console.ReadLine();

                vetorOrdenado[i] = vetorPalavras[i].Length;
                Console.WriteLine(vetorOrdenado[i]);
            }

            for (int c = 0; c < (vetorOrdenado.Length - 1); c++)
            {
                if (vetorOrdenado[c] == vetorOrdenado[c + 1])
                {
                    vetorOrdenado[c] = vetorOrdenado[c];
                }

                else if (vetorOrdenado[c] > vetorOrdenado[c + 1])
                {
                    var auxiliar = vetorOrdenado[c];
                    vetorOrdenado[c] = vetorOrdenado[c + 1];
                    vetorOrdenado[c + 1] = auxiliar;
                }
            }

            for (int j = 5; j < vetorOrdenado.Length; j--)
            {
                if (vetorOrdenado[j] < vetorOrdenado[j - 1])
                {
                    var auxiliar = vetorOrdenado[j];
                    vetorOrdenado[j] = vetorOrdenado[j - 1];
                    vetorOrdenado[j - 1] = auxiliar;
                }
            }


            Console.WriteLine(String.Join(" ", vetorOrdenado));
            Console.ReadLine();
        }

        static void Jokenpo()
        {
            var opcao = 'S';
            while (opcao == 'S')
            {
                Console.WriteLine("------- Jokenpô -------");

                Console.WriteLine("Insira seu nome: ");
                Console.Write("> ");
                var nomeJogador = Console.ReadLine();

                Console.WriteLine("\nQuantas rodadas deseja jogar?");
                Console.Write("> ");
                var jogadas = int.Parse(Console.ReadLine());


                var contadorJogadas = 0;
                int auxiliar = 0;
                int contadorDePartidasVencidas = 0;
                int contadorDePartidasVencidasPC = 0;
                int empate = 0;

                while (contadorJogadas < jogadas)
                {
                    Console.WriteLine("\nJO - KEN - PÔ:");
                    var escolhaDoJogador = Console.ReadLine();
                    var escolhaUpper = escolhaDoJogador.ToUpper();

                    switch (escolhaUpper)
                    {
                        case "PEDRA":
                            Console.WriteLine($"\nVocê jogou {escolhaDoJogador}");
                            auxiliar = 0;
                            break;
                        case "PAPEL":
                            Console.WriteLine($"\nVocê jogou {escolhaDoJogador}");
                            auxiliar = 1;
                            break;
                        case "TESOURA":
                            Console.WriteLine($"\nVocê jogou {escolhaDoJogador}");
                            auxiliar = 2;
                            break;
                    }

                    Random escolhaDoPC = new Random();

                    for (int i = 0; i <= 0; i++)
                    {
                        var escolha = escolhaDoPC.Next(3);
                        switch (escolha)
                        {
                            case 0:
                                Console.WriteLine("O computador jogou Pedra");
                                break;
                            case 1:
                                Console.WriteLine("O computador jogou Papel");
                                break;
                            case 2:
                                Console.WriteLine("O computador jogou Tesoura");
                                break;
                        }

                        if (auxiliar > escolha)
                        {
                            Console.WriteLine("Você venceu esta partida");
                            contadorDePartidasVencidas++;
                        }
                        else if (auxiliar == escolha)
                        {
                            Console.WriteLine("Empate!!");
                            empate++;
                        }
                        else
                        {
                            Console.WriteLine("O computador venceu esta partida");
                            contadorDePartidasVencidasPC++;
                        }
                    }

                    contadorJogadas++;
                    Console.ReadLine();

                }

                Console.WriteLine("----- PONTUAÇÃO FINAL -----");
                Console.WriteLine($"Partidas vencidas pelo jogador {nomeJogador}: {contadorDePartidasVencidas}");
                Console.WriteLine($"Partidas vencidas pelo PC: {contadorDePartidasVencidasPC}");
                Console.WriteLine($"Partidas com empate: {empate}");
                if ((contadorDePartidasVencidas > contadorDePartidasVencidasPC) &&
                    (contadorDePartidasVencidas > empate))
                {
                    Console.WriteLine("Você venceu!!!!!");

                }
                else if (contadorDePartidasVencidas == contadorDePartidasVencidasPC)
                {
                    Console.WriteLine($"Empate técnico de {empate}");
                }
                else
                {
                    Console.WriteLine("Não foi desta vez, o computador venceu!!");
                }

                Console.WriteLine("\nDesja continuar jogando, pressione 'S' para sim e 'N' para não");
                opcao = char.Parse(Console.ReadLine());

            }


        }

        static void JogoDaVelha()
        {
            Console.WriteLine("------- Jogo da Velha -------");

            Console.WriteLine("\nInsira o nome do Jogador 1: ");
            Console.Write("> ");
            var nomeJogador1 = Console.ReadLine();

            Console.WriteLine("\nInsira o nome do Jogador 2: ");
            Console.Write("> ");
            var nomeJogador2 = Console.ReadLine();

            Console.WriteLine("\n");


           Console.WriteLine($"\n{nomeJogador1} escolha X ou O (letra o)");
            Console.Write("> ");
            string escolhaJogador1 = Console.ReadLine();

            string verificaEscolha = (escolhaJogador1 == "O") ? "X" : "O";

            Console.WriteLine($"\n{nomeJogador2} você ficou com {verificaEscolha}");

            
            string[,] matrizTabuleiro = new string[3, 3];

            Console.WriteLine("\n");
            Console.WriteLine($"Este é o nosso tabuleiro\n");

            int contador = 0;
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    contador++;
                    matrizTabuleiro[linha, coluna] = Convert.ToString(contador);
                }
            }

            exibeTabuleiro();

            void exibeTabuleiro()
                {
                    Console.WriteLine("\n");
                    Console.WriteLine($"  {matrizTabuleiro[2, 0]} | {matrizTabuleiro[2, 1]} | {matrizTabuleiro[2, 2]}");
                    Console.WriteLine("------------");
                    Console.WriteLine($"  {matrizTabuleiro[1, 0]} | {matrizTabuleiro[1, 1]} | {matrizTabuleiro[1, 2]}");
                    Console.WriteLine("------------");
                    Console.WriteLine($"  {matrizTabuleiro[0, 0]} | {matrizTabuleiro[0, 1]} | {matrizTabuleiro[0, 2]}");
                    Console.WriteLine("\n");
                }

            int rodada = 0;
            string[,] tabuleiroNovo = new string[3, 3];
            var auxiliar = 0;
            while (rodada <= 4)
            {
                Console.WriteLine($"\n\nRodada {rodada + 1}");

                Console.WriteLine($"\n{nomeJogador1} em qual posição você deseja jogar");
                auxiliar = int.Parse(Console.ReadLine());
                //escolhaJogador1
                verificaPosJogador1();
                exibeTabuleiro();
                verificaX();
                verificaO();

                bool verificando = verificaX();
                bool verificandoO = verificaO();

                if (verificando == true && verificandoO == false)
                {
                    Console.WriteLine($"O Jogador X venceu");
                    break;
                }
                else if (verificando == false && verificandoO == true)
                {
                    Console.WriteLine($"O Jogador O venceu");
                    break;
                }

                Console.WriteLine($"\n{nomeJogador2} em qual posição você deseja jogar");
                auxiliar = int.Parse(Console.ReadLine());
                verificaPosJogador2();
                exibeTabuleiro();
                verificaX();
                verificaO();

                verificando = verificaX();
                verificandoO = verificaO();

                if (verificando == true && verificandoO == false)
                {
                    Console.WriteLine($"\nO Jogador X venceu");
                    break;
                }
                else if (verificando == false && verificandoO == true)
                {
                    Console.WriteLine($"\nO Jogador O venceu");
                    break;
                }
                
                void verificaPosJogador1()
                {
                    switch (auxiliar)
                    {
                        case 7:
                            matrizTabuleiro[2, 0] = escolhaJogador1;
                            break;

                        case 8:
                            matrizTabuleiro[2, 1] = escolhaJogador1;
                            break;

                        case 9:
                            matrizTabuleiro[2, 2] = escolhaJogador1;
                            break;

                        case 4:
                            matrizTabuleiro[1, 0] = escolhaJogador1;
                            break;

                        case 5:
                            matrizTabuleiro[1, 1] = escolhaJogador1;
                            break;

                        case 6:
                            matrizTabuleiro[1, 2] = escolhaJogador1;
                            break;

                        case 1:
                            matrizTabuleiro[0, 0] = escolhaJogador1;
                            break;

                        case 2:
                            matrizTabuleiro[0, 1] = escolhaJogador1;
                            break;

                        case 3:
                            matrizTabuleiro[0, 2] = escolhaJogador1;
                            break;

                    }
                }
                
                void verificaPosJogador2()
                {
                    switch (auxiliar)
                        { 
                            case 7:
                                matrizTabuleiro[2, 0] = verificaEscolha;
                                break;

                            case 8:
                                matrizTabuleiro[2, 1] = verificaEscolha;
                                break;

                            case 9:
                                matrizTabuleiro[2, 2] = verificaEscolha;
                                break;

                            case 4:
                                matrizTabuleiro[1, 0] = verificaEscolha;
                                break;
                            
                            case 5:
                                matrizTabuleiro[1, 1] = verificaEscolha;
                                break;

                            case 6:
                                matrizTabuleiro[1, 2] = verificaEscolha;
                                break;

                            case 1:
                                matrizTabuleiro[0, 0] = verificaEscolha;
                                break;

                            case 2:
                                matrizTabuleiro[0, 1] = verificaEscolha;
                                break;

                            case 3:
                                matrizTabuleiro[0, 2] = verificaEscolha;
                                break;
                        }
                }
                
                bool verificaX()
                {
                    bool resultado = false;
                    if (matrizTabuleiro[0, 0] == "X" && matrizTabuleiro[0, 1] == "X"
                                                     && matrizTabuleiro[0, 2] == "X")
                    {
                        resultado = true;
                    }
                    else if (matrizTabuleiro[0, 0] == "X" && matrizTabuleiro[1, 0] == "X" &&
                             matrizTabuleiro[2, 0] == "X")
                    {
                        resultado = true;
                    }
                    else if (matrizTabuleiro[0, 0] == "X" && matrizTabuleiro[1, 1] == "X" &&
                             matrizTabuleiro[2, 2] == "X")
                    {
                        resultado = true;
                    }
                    else if (matrizTabuleiro[0, 1] == "X" && matrizTabuleiro[1, 1] == "X" &&
                             matrizTabuleiro[2, 1] == "X")
                    {
                        resultado = true;
                    }
                    else if (matrizTabuleiro[0, 2] == "X" && matrizTabuleiro[1, 2] == "X" &&
                             matrizTabuleiro[2, 2] == "X")
                    {
                        resultado = true;
                    }
                    else if (matrizTabuleiro[0, 2] == "X" && matrizTabuleiro[1, 1] == "X" &&
                             matrizTabuleiro[2, 0] == "X")
                    {
                        resultado = true;
                    }
                    else if (matrizTabuleiro[1, 0] == "X" && matrizTabuleiro[1, 1] == "X" &&
                             matrizTabuleiro[1, 2] == "X")
                    {
                        resultado = true;
                    }
                    else if (matrizTabuleiro[2, 0] == "X" && matrizTabuleiro[2, 1] == "X" &&
                             matrizTabuleiro[2, 2] == "X")
                    {
                        resultado = true;

                    }
                    return resultado;
                }

                bool verificaO()
                {
                    bool resultado = false;
                    if (matrizTabuleiro[0, 0] == "O" && matrizTabuleiro[0, 1] == "O"
                                                     && matrizTabuleiro[0, 2] == "O")
                    {
                        resultado = true;
                    }
                    else if (matrizTabuleiro[0, 0] == "O" && matrizTabuleiro[1, 0] == "O" &&
                             matrizTabuleiro[2, 0] == "O")
                    {
                        resultado = true;
                    }
                    else if (matrizTabuleiro[0, 0] == "O" && matrizTabuleiro[1, 1] == "O" &&
                             matrizTabuleiro[2, 2] == "O")
                    {
                        resultado = true;
                    }
                    else if (matrizTabuleiro[0, 1] == "O" && matrizTabuleiro[1, 1] == "O" &&
                             matrizTabuleiro[2, 1] == "O")
                    {
                        resultado = true;
                    }
                    else if (matrizTabuleiro[0, 2] == "O" && matrizTabuleiro[1, 2] == "O" &&
                             matrizTabuleiro[2, 2] == "O")
                    {
                        resultado = true;
                    }
                    else if (matrizTabuleiro[0, 2] == "O" && matrizTabuleiro[1, 1] == "O" &&
                             matrizTabuleiro[2, 0] == "O")
                    {
                        resultado = true;
                    }
                    else if (matrizTabuleiro[1, 0] == "O" && matrizTabuleiro[1, 1] == "O" &&
                             matrizTabuleiro[1, 2] == "O")
                    {
                        resultado = true;
                    }
                    else if (matrizTabuleiro[2, 0] == "O" && matrizTabuleiro[2, 1] == "O" &&
                             matrizTabuleiro[2, 2] == "O")
                    {
                        resultado = true;

                    }
                    return resultado;
                }

                rodada++;

                if (rodada == 4)
                {
                    Console.WriteLine("Deu velha!");
                    break;
                }

            }
        }
    }
}
