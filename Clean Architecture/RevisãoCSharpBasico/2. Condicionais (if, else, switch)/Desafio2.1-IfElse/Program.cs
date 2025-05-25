Console.Clear();

Console.WriteLine(" === Desafio 2.1 === \n");
Console.WriteLine(" Peça para informar a nota do aluno.  \n");
Console.WriteLine(" Em seguida verifique se está aprovado, reprovado ou em recuperação \n");
Console.WriteLine(" Mamão?! Bora lá! \n\n\n");

string nome;
double nota = 0;

Console.Write(" Digite o nome do aluno: ");
nome = Console.ReadLine();

Console.Write(" Digite a nota do aluno: ");
nota = double.Parse(Console.ReadLine());


if (nota > 6)
{
    Console.WriteLine($"✅ A nota do aluno(a) {nome} é {nota}, portanto está aprovado.");
}
else if (nota == 6)
{
    Console.WriteLine($"⚠️ A nota do aluno(a) {nome} é {nota}, portanto está em recuperação.");
}
else
{
    Console.WriteLine($"❌ A nota do aluno(a) {nome} é {nota}, portanto está reprovado.");
}


Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();