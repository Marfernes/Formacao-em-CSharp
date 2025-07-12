//Crie um programa que:

//Receba dois números digitados pelo usuário.
//Pergunte qual a operação matemática deseja realizar (+, -, *, /).
//Exiba “Operação inválida” caso a entrada seja diferente das operações acima.
//Exiba o resultado de acordo com a operação escolhida.

Console.WriteLine("Digite o primeiro número");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Qual operação você deseja fazer: (Adição, Subtração, Multiplicação, Divisão)");

string opcao = Console.ReadLine();
int resultado;
resultado = opcao switch
{
    "Adição" => numero1 + numero2,
    "Subtração" => numero1 - numero2,
    "Multiplicação" => numero1 * numero2,
    "Divisão" => (numero1 / numero2)
};
Console.WriteLine($"O resultado dessa operação é: {resultado}");
