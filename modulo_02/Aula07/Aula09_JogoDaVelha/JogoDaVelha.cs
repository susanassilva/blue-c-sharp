using System;
using System.Runtime.Intrinsics.X86;

namespace Aula09_JogoDaVelha
{
    public class JogoDaVelha
    {
        private string[,] Tabuleiro = new string[3, 3];
        private int Rodada = 0;

        private string JogadorX;
        private string JogadorO;

        public JogoDaVelha()
        {
            JogadorX = String.Empty;
            JogadorO = String.Empty;

            Iniciar();
        }

        private void Iniciar()
        {
            Console.WriteLine("Jogo da Velha v1.0 \n");
            Console.WriteLine("Digite o nome do Jogador 1 - X: ");
            Console.Write("> ");
            JogadorX = Console.ReadLine();

            Console.WriteLine("Digite o nome do Jogador 2 - O: ");
            Console.Write("> ");
            JogadorO = Console.ReadLine();

            Desenhar();
        }

        private void Desenhar()
        {
            Console.Clear();

            Preencher();
        
            Console.Write("\n");
            Console.WriteLine($"{Tabuleiro[2, 0]} | {Tabuleiro[2, 1]} | {Tabuleiro[2,2]}");
            Console.WriteLine("----------");
            Console.WriteLine($"{Tabuleiro[1, 0]} | {Tabuleiro[1, 1]} | {Tabuleiro[1, 2]}");
            Console.WriteLine("----------");
            Console.WriteLine($"{Tabuleiro[0, 0]} | {Tabuleiro[0, 1]} | {Tabuleiro[0, 2]}");
        }

        private void Preencher()
        {
            int Contador = 0;
            for (int Linha = 0; Linha < 3; Linha++)
            {
                for (int Coluna = 0; Coluna < 3; Coluna++)
                {
                    /*
                        //Linha 1
                        Tabuleiro[0, 0] = "7";
                        Tabuleiro[0, 1] = "8";
                        Tabuleiro[0, 2] = "9";

                        //Linha 2
                        Tabuleiro[1, 0] = "4";
                        Tabuleiro[1, 1] = "5";
                        Tabuleiro[1, 2] = "6";

                        //Linha 3
                        Tabuleiro[2, 0] = "1";
                        Tabuleiro[2, 1] = "2";
                        Tabuleiro[2, 2] = "3";
                    */

                    Rodada++;
                    Tabuleiro[Linha, Coluna] = Convert.ToString(Contador);
                }
            }
        }

        private bool Vencedor()
        {
            return true;
        }


        private void Jogada()
        {
            bool Limite = Rodada > 0;
            bool Fim = Vencedor() || Limite;

            while (Fim)
            {
                Console.WriteLine("Escolha a posição que deseja jogar: ");
                Console.Write("> ");
                bool ValidarEntrada = int.TryParse(Console.ReadLine(), out int EscolhaCoordenadaDoTabuleiro);

                if (ValidarEntrada)
                {
                    switch (EscolhaCoordenadaDoTabuleiro)
                    {
                        case 1:
                            Tabuleiro[2, 0] = "1";
                            Rodada--;
                            break;
                        
                        case 2:
                            Tabuleiro[2, 1] = "2";
                            Rodada--;
                            break;
                        
                        case 3:
                            Tabuleiro[2, 2] = "3";
                            
                            Rodada--;
                            break;
                        
                        case 4:
                            Tabuleiro[1, 0] = "4";
                            Rodada--;
                            break;
                        
                        case 5:
                            Tabuleiro[1, 1] = "5";
                            Rodada--;
                            break;
                        
                        case 6:
                            Tabuleiro[1, 2] = "6";
                            Rodada--;
                            break;
                        
                        case 7:
                            Tabuleiro[0, 0] = "7";
                            Rodada--;
                            break;
                        
                        case 8:
                            Tabuleiro[0, 1] = "8";
                            Rodada--;
                            break;
                        
                        case 9:
                            Tabuleiro[0, 2] = "9";
                            Rodada--;
                            break;

                        default:
                            break;

                    }
                }
            }
        }
        
    }
}
