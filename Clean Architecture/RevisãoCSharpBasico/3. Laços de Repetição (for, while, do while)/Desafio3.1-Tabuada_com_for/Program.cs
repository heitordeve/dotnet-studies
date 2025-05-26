Console.Clear();

Console.WriteLine(" === Desafio 3.1 - Tabuada com FOR === \n");
Console.WriteLine(" Crie um programa que solicite ao usuário um número.  \n");
Console.WriteLine(" Em seguida será impresso uma tabuada \n");
Console.WriteLine(" Mamão?! Bora lá! \n\n\n");

Console.Write(" Digite um número: ");
string? entradaNumero = Console.ReadLine();

if (!int.TryParse(entradaNumero, out int numero))
{
    Console.WriteLine("❌ Número inválida, apenas usar teclado númerico. Encerrando o programa.");
    return;
}

Console.WriteLine($"\n📊 Tabuada do {numero}:\n");

for (int i = 1; i <= 10; i++) 
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}

Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();
