Console.Clear();

Console.WriteLine(" === Desafio 2.2 - Switch === \n");
Console.WriteLine(" DADO QUE o usuário esteja no sistema para validar a situação do Aluno  \n");
Console.WriteLine(" E está usando a estrutura de condição SWITCH  \n");
Console.WriteLine(" QUANDO ele informa a nota do aluno \n");
Console.WriteLine(" ENTÃO será impresso no terminal a situação do Aluno\n");
Console.WriteLine(" Mamão?! Bora lá! \n\n\n");

Console.Write(" Digite o nome do aluno: ");
string? entradaNome = Console.ReadLine();
if (string.IsNullOrWhiteSpace(entradaNome))
{
    Console.WriteLine("❌ Nome inválido. Encerrando o programa.");
    return;
}
string nome = entradaNome!;

Console.Write(" Digite a nota do aluno: ");
string? entradaNota = Console.ReadLine();

if (!double.TryParse(entradaNota, out double nota))
{
    Console.WriteLine("❌ Nota inválida. Encerrando o programa.");
    return;
}

switch (nota)
{
    case > 6:
        Console.WriteLine($"✅ A nota do aluno(a) {nome} é {nota}, portanto está aprovado.");
        break;
    case 6:
        Console.WriteLine($"⚠️ A nota do aluno(a) {nome} é {nota}, portanto está em recuperação.");
        break;

    case < 6:
        Console.WriteLine($"❌ A nota do aluno(a) {nome} é {nota}, portanto está reprovado.");
        break;
    default:
        Console.WriteLine("fechou");
        break;
}

Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();
