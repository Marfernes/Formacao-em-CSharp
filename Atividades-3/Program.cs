//Crie um programa que:

//Declare uma variável com um valor inteiro representando o total de minutos.
//Calcule quantas horas completas existem nesse valor e quantos minutos restam.
//Exiba o resultado no formato X horas e Y minutos.

Console.Write("Digite o total de minutos: ");
string entrada = Console.ReadLine();

if (int.TryParse(entrada, out int totalMinutos) && totalMinutos >= 0)
{
    int horas = totalMinutos / 60;        // Parte inteira das horas
    int minutosRestantes = totalMinutos % 60;  // O resto é o que sobra em minutos

    Console.WriteLine($"{horas} hora(s) e {minutosRestantes} minuto(s).");
}
else
{
    Console.WriteLine("Por favor, digite um número inteiro válido e não negativo.");
}

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();