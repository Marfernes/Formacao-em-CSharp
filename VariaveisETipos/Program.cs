// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tipos de Variaveis");

int quantidade = 42;
char inicial = 'A';

bool ativo = true;

if (ativo ==  false)
{
    Console.WriteLine("Não!");
}
else
{
    Console.WriteLine("Sim");
}
  

byte idade = 25;
sbyte temperatura = -5;
short numeroCurto = 1000;
ushort codigo = 500;
double numeroComPontoFlutuante = 20.00;
long numeroGrande = 200000000000000000;
decimal numeroMuitoGrande = 2000000000000000000;



//Incremento
quantidade++;
//Imprime variaveis
Console.WriteLine("Quantidade: " + quantidade);
Console.WriteLine("Inicial: " + inicial);
Console.WriteLine("Ativo: " + ativo);
Console.WriteLine("Idade: " + idade);
Console.WriteLine("Temperatura: " + temperatura);
Console.WriteLine("Número curto: " + numeroCurto);
Console.WriteLine("Código: " + codigo);
Console.WriteLine("Numero Com Ponto Flutuante: " + numeroComPontoFlutuante);
Console.WriteLine("Numero grande: " + numeroGrande);
Console.WriteLine("Numero muito grande: " + numeroMuitoGrande);

