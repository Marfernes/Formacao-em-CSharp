
// usando do while para manter o menu em tela

int opcao;

do
{
    Console.WriteLine("#MENU");

    Console.WriteLine("SISTEMA DE AUTENTICAÇÃO");
    Console.WriteLine("-----------------------");
    Console.WriteLine("1_ Cadastro novo usuário");
    Console.WriteLine("2_ Acessar como convidado");
    Console.WriteLine("3_ Sair...");

    opcao = int.Parse(Console.ReadLine());

    string mensagem = opcao switch
    {
        1 => "Cadastre um novo usuário",
        2 => "Acesso como convidado",
        3 => "Você foi deslogado",
        _ => "Opção inválida"
    };

    Console.WriteLine($"{mensagem}");

    if (opcao == 1)
    {
        Console.WriteLine("Nome Usuário: ");
        string usuarioNovo = Console.ReadLine();
        Console.WriteLine($"Usuário {usuarioNovo} cadastrado");
    }
}
while (opcao != 3);
