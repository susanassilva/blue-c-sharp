using System;

namespace Exercicio02_Aula05
{
    public class Voo
    {

        public int[] MaxPassageiros = new int[100];

        public string Data = "30/06/2022";
        public string Horario = "22h";
        public bool statusSucesso;


        public int VagasLivres()
        {
            
            int tamanho = MaxPassageiros.Length;
            int count = 0;
            int ocupadas = 0;

            for (int i = 0; i < tamanho; i++)
            {
                if (MaxPassageiros[i] == 0)
                {
                    count++;
                } else if (MaxPassageiros[i] != 0)
                {
                    ocupadas++;
                }
                
            }

            Console.WriteLine($"\n\nTemos {count} vagas livres e {ocupadas} vagas ocupadas");
            Console.WriteLine($"Escolha uma das {count} vagas livres listadas abaixo: ");
            CadeiraLivre();
            string[] arrayCadeirasLivres = CadeiraLivre();
            Console.Write("\n");
            Console.WriteLine(String.Join(", ", arrayCadeirasLivres));

            return count;
        }


        public bool OcuparVaga(int vaga)
        {
            int tamanho = MaxPassageiros.Length;
            string[] arrayMaxPassageiros = new string[tamanho];

            for (int i = 0; i < tamanho; i++)
            {


                if ((i == vaga) && (MaxPassageiros[i] == 0))
                {
                    Console.Write($"\nVerificando a disponibilidade da vaga {i}...");
                    Console.WriteLine($"\nVaga {i} não preenchida");
                    Console.WriteLine("\nAguarde um instante para reservarmos sua vaga...");
                    MaxPassageiros[i - 1] = vaga;
                    Console.WriteLine($"\nVaga {vaga} reservada para o dia {Data} e horário {Horario}");
                    Console.WriteLine("\n----------------------");
                    statusSucesso = true;
                }
                else if(MaxPassageiros[i] == vaga)
                {
                    Console.WriteLine("\n----------------------");
                    Console.WriteLine("\n\nVaga já preenchida, escolha uma vaga livre");
                    
                    statusSucesso = false;
                    VagasLivres();
                    ProximaCadeiraVaga(vaga);
                    Console.WriteLine("\n----------------------");

                    break;

                }
            }
            return statusSucesso;
        }
        

        public string[] CadeiraLivre()
        {
            int tamanho = MaxPassageiros.Length;
            string[] arrayMaxPassageiros = new string[tamanho];
            string frase;

            for (int i = 0; i < tamanho; i++)
            {
                if (MaxPassageiros[i] == 0)
                {
                    frase = $"{i + 1}-desocupada";
                    arrayMaxPassageiros[i] = frase;
                }
                else if (MaxPassageiros[i] != 0)
                {
                    frase = $"{i + 1}-ocupada";
                    arrayMaxPassageiros[i] = frase;
                }

            }
            

            return arrayMaxPassageiros;
        }

        public int ProximaCadeiraVaga(int vaga)
        {
            int cadeiravaga;
            int tamanho = MaxPassageiros.Length;
            string[] arrayCadeirasLivres = CadeiraLivre();

            for (int i = 0; i < tamanho; i++)
            {
                if ((arrayCadeirasLivres[i] == $"{i + 1}-desocupada") && (i > vaga))
                {
                    cadeiravaga = i;
                    Console.WriteLine($"\n\nA próxima cadeira vaga, perto a anteriormente escolhida, é {cadeiravaga}");
                    Console.WriteLine($"\nDeseja ocupá-la? " +
                                      $"\nSe sim, digite 1" +
                                      $"\nSe não, digite 2 para verificar outras vagas");
                    Console.Write("> ");
                    string opcao = Console.ReadLine();


                    switch (opcao)
                    {
                        case "1":
                            Ocupa(cadeiravaga);
                            break;
                        case "2":
                            Console.WriteLine("\nVerifique as demais cadeiras disponíveis");
                            Console.WriteLine(String.Join(", ", arrayCadeirasLivres));
                            Console.WriteLine("\nQual cadeira você deseja?");
                            int cadeiraSolicitada = int.Parse(Console.ReadLine());
                            
                            Ocupa(cadeiraSolicitada);
                            break;
                        default:
                            Console.WriteLine("Pressione enter para sair do programa");
                            break;

                    }

                    break;
                }
            }

            return 0;
        }

        public int Ocupa(int vaga)
        {
            OcuparVaga(vaga);
            Console.WriteLine("Pressione enter para sair do programa...");
            return 0;
        }
        
    }
}
