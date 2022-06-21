namespace Aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humano professor = new Humano();
            professor.Especie = "Humano";
            professor.Falar();

            Gato persa = new Gato();
            persa.Falar();

            Mamifero baleia = new Mamifero();
            baleia.Falar();

        }
    }
}
