using Aula05_Encapsulamento_Abstracao_Polimorfismo_Heranca;

namespace Encapsulamento_Abstracao_Heranca_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humano professor = new Humano();
            professor.Falar();

            Mamifero gato = new Mamifero();
            gato.Falar();

        }
    }
}