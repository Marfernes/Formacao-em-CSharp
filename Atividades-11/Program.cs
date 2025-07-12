//Crie um programa que:

//Defina uma lista de nomes dos alunos.
//Utilize um loop para percorrer a lista.
//Interrompa a busca quando o nome desejado for encontrado.
//Informe se o nome não for encontrado.

string [] alunos = { "Ana", "Carlos", "Bianca", "João", "Marina" };
string contador;
int indice;

do
{
    Console.WriteLine("Nome dos Alunos, (Ana, Carlos, Bianca, João, Marina");
    Console.WriteLine("Digite o nome do Aluno que você deseja encontrar:");
    contador = Console.ReadLine();
    indice = 0;

    while(indice < alunos.Length && alunos[indice] != contador)
    {
        indice++;
    }

}
while (indice == alunos.Length);

Console.WriteLine($"Aluno '{contador}' encontrado!");

