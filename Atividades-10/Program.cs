// enquanto meu contador for diferente de zero soma o valor digitado


int contador;
int soma = 0;
do
{
    Console.WriteLine("#SUPERMERCADO");
    Console.WriteLine("Digite valor da venda:");
    contador = int.Parse(Console.ReadLine());
    soma += contador;
} 
while(contador != 0);
Console.WriteLine($"Compra finalizada. Total: R$ {soma - 0:F2}");
