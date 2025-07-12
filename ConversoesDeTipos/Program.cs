// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int quantidade = 42;
// convertendo int para long / conversão implicita
long quantidadeLong = quantidade;

// conversão explicita
byte quantidadeByte = (byte)quantidadeLong;

double valorUnitario = 30.0 / 4;
Console.WriteLine(valorUnitario);

//Escreva um programa em C# que, a partir do ano de nascimento de uma pessoa, calcule a idade com base no ano atual.



int anoAtual = DateTime.Now.Year;

Console.WriteLine("Digite ano de Nascimento");
string entrada = Console.ReadLine();

if(int.TryParse(entrada, out int  anoNascimento))
{
    int idade = anoAtual - anoNascimento;
    if (idade < 0)
    {
        Console.WriteLine("Ano de nascimento inválido!");
    }
    {
        Console.WriteLine($"Você tem {idade} anos.");
    }
}
else
{
    Console.WriteLine("Entrada inválida. Digite um valor númerico como 1192");
}

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();


