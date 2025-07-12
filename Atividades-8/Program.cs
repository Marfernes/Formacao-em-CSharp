//Então, um livro com o código 451 seria catalogado como “Romance”, 
//enquanto o livro com o código 762 seria “Biografias/Memórias”. 
//Sua tarefa é refatorar o código atual para utilizar switch/case.

Console.WriteLine("#BIBLIOTECA");
Console.WriteLine("#DIGITE CÓDIGO DO LIVRO (142, 143, 144, 145, 146, 147, 148, 149,150)");

int opcao = int.Parse(Console.ReadLine());


string mensagem = opcao switch
{
    142 => "Ficção Científica",
    143 => "Literatura Clássica",
    144 => "Fantasia",
    145 => "Romance",
    146 => "Suspense/Mistério",
    147 => "Não Ficção",
    148 => "Biografias/Memórias",
    149 => "Distopia",
    150 => "Infantojuvenil",
    _ => "Código Inexistente"
};
Console.WriteLine($"Livro da sua escolha foi {mensagem}");
