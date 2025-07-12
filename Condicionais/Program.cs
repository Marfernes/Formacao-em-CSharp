
bool conexaoAtiva = false;
if (conexaoAtiva)
{
    Console.WriteLine("Inciando o jogo!");
}
else
{
    Console.WriteLine("Falha na conexão!");
}

double valorCompra = 100.00;
bool clienteVip = false;

if(valorCompra > 300.00 || clienteVip)
{
    double desconto = valorCompra * 0.1;
    Console.WriteLine($"Você ganhou {desconto} de desconto!");
}
else if (valorCompra > 200.00)
{
    Console.WriteLine("Parabéns você ganhou um brinde!");
}
else
{
    double diferenca = 300.00 - valorCompra;
    Console.WriteLine($"Faltam {diferenca} para obter desconto!");
}