Console.Clear();

Console.WriteLine(" === Desafio 2.1 === \n");
Console.WriteLine(" DADO QUE o usuário esteja no sistema para validar a situação do Aluno  \n");
Console.WriteLine(" E está usando a estrutura de condição IFELSE \n");
Console.WriteLine(" QUANDO ele informa a nota do aluno \n");
Console.WriteLine(" ENTÃO será impresso no terminal a situação do Aluno\n")
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