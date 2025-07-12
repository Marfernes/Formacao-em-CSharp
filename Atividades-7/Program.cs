//Crie um programa que:

//Receba o cupom de recompensa inserido
//Retorne uma mensagem de acordo com o cupom
//Informe que “Recompensa indisponível” se o cupom for inválido

Console.WriteLine("#MENU");
Console.WriteLine("DIGITE SEU CUPOM: (DOBRAR, CURAR, OURO, ESPECIAL)");
string cupom = Console.ReadLine();

string mensagem = cupom switch
{
    "DOBRAR" => "Ganhar 2x EXP por 1 hora",
    "CURAR" => "Poção de cura",
    "OURO" => "100 moedas de ouro",
    "ESPECIAL" => "Item lendário",
    _ => "Recompensa indisponível, cupom inválido!"
};
Console.WriteLine($"Sua recompensa é {mensagem}");
