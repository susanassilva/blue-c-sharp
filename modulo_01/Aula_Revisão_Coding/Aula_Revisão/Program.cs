//1. Funções
/*
string retornarCumprimento()
{
    return "Oi";
}

Console.WriteLine(retornarCumprimento());


void cumprimentarComTerminal()
{
    Console.WriteLine("olá!");
}

cumprimentarComTerminal();


//1.3. Funções que respondem com parâmetros....

string testarRecomendacoesParaAndarNoBrinquedo(bool temRecomendacao)
{
    string mensagem = "";
    if (temRecomendacao)
    {
        mensagem = "Pode Andar no Brinquedo";
    }
    else
    {
        mensagem = "Não pode andar";
    }

    return mensagem;
}

testarRecomendacoesParaAndarNoBrinquedo(temRecomendacao:true);

//2.Condicionais


bool usuarioTemIdadeRecomendada = true;
bool usuarioTemAlturaRecomendada = false;

bool compararValores = 10 > 10;



//2.1. If... Else... Operador Ou - || 

//True
if(usuarioTemAlturaRecomendada || usuarioTemIdadeRecomendada)
{
    Console.WriteLine("Verdadeiro");
}

//false
else
{
    Console.WriteLine("Falso");
}


/*
//2.2. If... Else... Operador E - &&


if (usuarioTemIdadeRecomendada && usuarioTemAlturaRecomendada)
{
    Console.WriteLine("Falso");
} else
{
    Console.WriteLine("Verdadeiro");
}

//2.3. If... Else If... Else...

usuarioTemIdadeRecomendada = false;
usuarioTemAlturaRecomendada = true;

if (usuarioTemIdadeRecomendada)
{
    Console.WriteLine("Usuário tem idade recomendada.");
} else if (usuarioTemAlturaRecomendada)
{
    Console.WriteLine("Usuário tem altura recomendada.");
} else
{
    Console.WriteLine("O usuário não pode andar no brinquedo.");
}


//2.4. If... Else If... Else... Operador de Negação

usuarioTemIdadeRecomendada = false;
usuarioTemAlturaRecomendada = true;

if (usuarioTemIdadeRecomendada)
{
    Console.WriteLine("Usuário tem idade recomendada.");
}
else if (!usuarioTemAlturaRecomendada)
{
    Console.WriteLine("Usuário tem altura recomendada.");
}
else
{
    Console.WriteLine("O usuário não pode andar no brinquedo.");
}




//2.5. Switch... case... break... Default
int indiceDoDia = 4;

switch (indiceDoDia)
{
    case 0:
        Console.WriteLine("Domingo");
        break;

    case 1:
        Console.WriteLine("Segunda");
        break;

    case 2:
        Console.WriteLine("Terça");
        break;

    case 3:
        Console.WriteLine("Quarta");
        break;

    default:
        Console.WriteLine("Valor inválido");
        break;
}

*/
/*
//3. Estrutura de Repetição


// 3.1. Estrutura de repetição for...
//(valor inicial; condição; modificador)

for(int contador = 0; contador < 5; contador++)
{
    //Contador...
    Console.WriteLine(contador+1);

}


// 3.2. Estrutura de repetição while...
// Número de repetições indefinidas
int opcao = 1;

while (opcao == 1)
{
    Console.Write("Fui!");
    Console.WriteLine("Deseja continuar: ");
    opcao = int.Parse(Console.ReadLine());
}


//3.3. Estrutura de repetição do... while...
int _contador = 0;
do
{
    Console.WriteLine(_contador);//executado uma vez
    _contador++;

} while (false);


//3.4. Estrutura de repetição foreach...


//4. Vetores
*/
//4.1. Declarar vetores:
int[] numerosPares = {0, 2, 4, 6};
int[] numerosImpares = new int[4];

numerosImpares[0] = 1;
numerosImpares[1] = 3;
numerosImpares[2] = 5;
numerosImpares[3] = 7;

int[] numerosPrimos = new int[3] { 2, 3, 5 };


//4.2. Acessar valores:
Console.WriteLine(numerosPrimos[2]);

//4.3. Editar valores:
numerosPrimos[2] = 7;
Console.WriteLine(numerosPrimos[2]);


//4.4. Vetores Bidimensionais

string[,] tabuleiro = new string[3, 3]
{
    {"X", "O", "X"},
    {"X", "O", "X"},
    {"O", "X", "O"}
};

Console.WriteLine($"{tabuleiro[0, 0]} + {tabuleiro[0, 1]}");

//5. Estrutura de repetição em vetores

//5.1. Estrutura de repetição for... em vetores
for (int i = 0; i < numerosPares.Length; i++)
{
    Console.WriteLine("Par: " + numerosPares[i]);
}


//5.2. Estrutura de repetição foreach...

foreach (int numero in numerosImpares)
{
    Console.WriteLine("Ímpar: " + numero);
}


//5.3. Estrutura de repetição for em bidimensional

foreach (int linha in tabuleiro)
{
    foreach (int coluna in linha )
    {
        
    }
}


Console.Write("Olá! ");


