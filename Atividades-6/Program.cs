//Para isso, você precisa de um programa que:

//Pergunte ao usuário qual o momento do dia (manhã, tarde ou noite).
//Solicite o nome do usuário.
//Exiba uma saudação personalizada com base no momento do dia e no nome fornecido.
//Exiba uma mensagem em caso de opção inválida.

Console.WriteLine("Que momento do dia é agora ?: Manhã, Tarde, Noite");

string opcao = Console.ReadLine();
Console.WriteLine("Qual o seu nome?");
string nome = Console.ReadLine();
string momentododia = opcao switch
{
    "Manhã" => "Bom dia!",
    "Tarde" => "Boa tarde!",
    "Noite" => "Boa Noite!",
    _ => "Opção Inválida",
};
Console.WriteLine($"Olá!, {momentododia}, {nome}");



