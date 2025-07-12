//Para facilitar a comunicação com os clientes,
//sua missão é criar um sistema de conversão de distâncias que transforme milhas em quilômetros, utilizando a fórmula: 1 milha = 1.60934 quilômetros. 

Console.WriteLine("Conversor de Milhas para Quilômetros");
Console.Write("Digite a distância em milhas: ");
string entrada = Console.ReadLine();

if (double.TryParse(entrada, out double milhas))
{
    double quilometros = milhas * 1.60934;
    Console.WriteLine($"{milhas} milha(s) equivalem a {quilometros:F2} quilômetros.");
}
else
{
    Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
}

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();