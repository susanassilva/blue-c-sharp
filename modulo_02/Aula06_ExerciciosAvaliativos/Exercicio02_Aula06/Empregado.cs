using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02_Aula06
{
    internal class Empregado
    {
        public string NomeEmpregado;
        public string CargoEmpregado;
        public double SalarioMensalEmpregado;
        
        //construtor
        public Empregado(string nome, string cargo, double salario)
        {
            this.NomeEmpregado = nome;
            this.CargoEmpregado = cargo;
            this.SalarioMensalEmpregado = salario;

            if (salario < 0.0)
            {
                salario = (double)0.0f;
                Console.WriteLine(salario);
            }

            VerificaSalario(salario);
            var salarioModificado = VerificaSalario(salario);
            ImprimeSalario(nome, cargo, salarioModificado);

        }

        public double VerificaSalario(double salario)
        {
            double salarioAtual = 0.0;

            if (salario > 0 && salario <= 400.00)
            {
                salarioAtual = salario * 1.15;

            } else if (salario > 400.00 && salario <= 800.00)
            {

                salarioAtual = salario * 1.12;
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {

                salarioAtual = salario * 1.10;
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {

                salarioAtual = salario * 1.07;
            }
            else
            {
                salarioAtual = salario * 1.04;
            }

            return salarioAtual;
            
        }

        public void ImprimeSalario(string nome, string cargo, double salarioAtual)
        {
            Console.WriteLine($"\nA(o) empregada(o) {nome}, alocada(o) no cargo de {cargo}, teve seu salário modificado para ${salarioAtual:0.00}");
        }
    }
}
