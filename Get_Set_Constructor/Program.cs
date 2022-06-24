namespace Get_Set_Constructor
{
    internal class Program
    {
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno("Susana", "Coding_Girls");
        aluno.Sobrenome = "Santos Silva";
        Console.WriteLine(aluno.Sobrenome);
    }

    }
}


