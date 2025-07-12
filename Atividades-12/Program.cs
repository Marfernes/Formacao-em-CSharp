Console.WriteLine("Lista de participantes (exceto múltiplos de 3):");

for (int i = 1; i <= 22; i++)
{
    //Lê-se: "se o resto da divisão de i por 3 for diferente de 0, não é multiplo de 3".

    if (i % 3 != 0)
    {
        Console.WriteLine($"Participante nº {i}");
    }
}