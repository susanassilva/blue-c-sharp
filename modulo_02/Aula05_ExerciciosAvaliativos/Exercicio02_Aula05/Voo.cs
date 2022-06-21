using System;

namespace Exercicio02_Aula05
{
    public class Voo
    {

        public int[] MaxPassageiros = new int[100];
        
        public string Data;
        public string Horario;
        public bool statusSucesso;


        public bool OcuparVaga(int vaga)
        {
            
            for (int i = 0; i < 100; i++)
            {

                if ((i == vaga) && (MaxPassageiros[i] == 0))
                {
                    Console.WriteLine("\nVaga não preenchida");
                    Console.WriteLine("\n\nAguarde um instante para reservarmos sua vaga...");
                    MaxPassageiros[i - 1] = vaga;
                    Console.Write(String.Join(" ", MaxPassageiros));
                    Console.WriteLine($"\nVaga {vaga} reservada");
                    statusSucesso = true;
                }
                else if(MaxPassageiros[i] == vaga)
                {
                    statusSucesso = false;
                }
            }
            return statusSucesso;
        }

        

        public int VagasLivres()
        {
            return 0;
        }

        public int CadeiraLivre()
        {
            return 0;
        }

        public int Ocupa(int vaga, bool statusCadeira)
        {
            return 0;
        }
        

    }
}
