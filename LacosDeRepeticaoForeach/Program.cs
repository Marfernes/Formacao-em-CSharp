List<string> funcionarios = new List<string>
{
            "João-Gerente-8500",
            "Maria-Analista de Sistemas-6200",
            "Carlos-Desenvolvedor-5500",
            "Ana-Designer-4800",
            "Pedro-Suporte Técnico-3900",
            "Fernanda-Coordenadora de Projetos-7300",
            "Ricardo-Contador-6000",
            "Juliana-RH-4500"
};

foreach (string funcionario in funcionarios)
{
    var salario = funcionario.Split('-')[2];
    var salarioInt = int.Parse(salario);
    if (salarioInt > 5000)
    {
        continue;
    }
    Console.WriteLine($"Os dados do funcionário é : {funcionario}");
}

foreach (string funcionario in funcionarios)
{
    var nome = funcionario.Split('-')[0];
    if (nome.Equals("Fernanda"))
    {
        Console.WriteLine($"Os dados do funcionário é : {funcionario}");
        break;
    }
    
}
