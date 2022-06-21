using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02_Aula05
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Companhia VoeNamoral -----");
            Console.WriteLine("--- Reserva de vagas ---");
            
            Voo voo33 = new Voo();
            
            //vagas já reservadas para testes
            voo33.OcuparVaga(5);
            voo33.OcuparVaga(98);


            Console.WriteLine($"Qual vaga você deseja reservar para o vôo no dia {voo33.Data} às {voo33.Horario}? ");
            int vaga = int.Parse(Console.ReadLine());
            voo33.OcuparVaga(vaga);

            
        }
    }
}
