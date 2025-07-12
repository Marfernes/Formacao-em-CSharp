//Você foi contratado por uma empresa beneficente,
//que recebe doações de pessoas físicas e jurídicas para ajudar comunidades carentes.
//Algumas dessas doações são anônimas, e outras são registradas com os dados do doador.
//Além disso, as doações são depositadas em dois tipos de contas: corrente ou poupança.
//Recentemente, uma doação anônima no valor de R$500 foi feita para a conta poupança da empresa.

//Crie um programa que:

//Declare uma variável para armazenar o valor recebido da doação.
//Declare uma variável para indicar se a doação foi anônima (true para anônima, false para não anônima).
//Declare uma variável para indicar o tipo de conta onde o valor foi depositado:
//Use P para conta poupança.
//Use C para conta corrente
decimal valorSaldo = 100000000;
string valorDoacao;
bool doacaoAnonima = false;
char contaCorrente = 'C';
char contaPoupanca = 'P';

Console.WriteLine("Digite valor da doação: ");
valorDoacao = Console.ReadLine();


Console.WriteLine("C - Conta Corrente");
Console.WriteLine("P - Conta Poupança");
Console.Write("Digite sua escolha: ");
string escolhaConta = Console.ReadLine().ToUpper();

if (double.TryParse(valorDoacao, out double valor))
{
    Console.WriteLine($"Valor da doação: {valor} ");

    if (doacaoAnonima == false && valor > 0 && valor <=  50.00)
    {
        valorSaldo = valorSaldo - (decimal)valor;
        Console.WriteLine("Doação anônima!, Seu saldo atual é: " + valorSaldo);
    }
    else if (valor > 50.00)
    {
        valorSaldo = valorSaldo - (decimal)valor;
        Console.WriteLine("Doação feita por empresa conveniada! Seu saldo atual é: " + valorSaldo);
    }
    else
    {
        Console.WriteLine("Você não pode doar $ 0.00 !");

    }
}
else
{
    Console.WriteLine($"Valor da doação inválida! Digite um valor assim Exemplo: 100.50 ");
}
