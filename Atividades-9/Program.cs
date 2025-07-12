
Console.WriteLine("#MENU");

Console.WriteLine("SISTEMA DE AUTENTICAÇÂO");
Console.WriteLine("-----------------------");
Console.WriteLine("1_ Cadastro novo usuário");
Console.WriteLine("2_ Acessar como convidado");
Console.WriteLine("3_ Sair...");

int opcao = int.Parse(Console.ReadLine());

string mensagem = opcao switch
{
    1 => "Cadastre um novo usuário",
    2 => "Acesso como convidado",
    3 => "Você foi deslogado",
    _ => "Opção inválida"
};
Console.WriteLine($"{mensagem}");
Console.WriteLine("Nome Usuário: ");
string usuarioNovo = Console.ReadLine();
Console.WriteLine($"Usuário {usuarioNovo} cadastrado");



