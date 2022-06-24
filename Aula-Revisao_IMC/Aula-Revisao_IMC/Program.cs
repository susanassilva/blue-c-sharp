

string retornarDiagnosticodoUsuario(double alturaDousuario, double pesoDousuario)
{
    string mensagem;
    double imc = (alturaDousuario * alturaDousuario) / pesoDousuario;

    if (imc < 18.5)
    {
        mensagem = "Anêmico";
    }
    else if (imc >= 18.5 && imc <= 24.9)
    {
        mensagem = "Sobrepeso";
    }
    else if (imc >= 30 && imc <= 40)
    {
        mensagem = "Obesidade";
    }
    else
    {
        mensagem = "Obesidade grave";
    }

    return mensagem;
}

Console.WriteLine("Informe altura: ");
double alturaDousuario = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o peso ");
double pesoDousuario = double.Parse(Console.ReadLine());

Console.WriteLine($"Seu diagnóstico é {retornarDiagnosticodoUsuario(alturaDousuario, pesoDousuario)}");

