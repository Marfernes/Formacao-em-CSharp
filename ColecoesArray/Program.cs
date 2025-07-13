// mostrando nome do funcionario passando a posição
string[] funcionarios = { "João", "Maria", "Pedro", "Ana" };
Console.WriteLine(funcionarios[0]);

// mostrando posição do indice
int indice = Array.IndexOf(funcionarios, "João");
Console.WriteLine($"Posição do João é : {indice}");

//ordenando array
Array.Sort(funcionarios);
foreach(string funcionario in funcionarios)
{
    Console.WriteLine(funcionario);
}

Console.WriteLine($"-----------------------");
// criando novo array e copiando array funcionario para novoArray
string[] novoArray = new string[5];
Array.Copy(funcionarios, novoArray, funcionarios.Length);

foreach (string nome in novoArray)
{
    Console.WriteLine(nome);
}
Console.WriteLine($"-----------------------");
// inserindo novo nome no arrayNovo
novoArray[4] = "Joana";
foreach (string nome in novoArray)
{
    Console.WriteLine(nome);
}
