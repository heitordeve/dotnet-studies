Console.Clear();

Console.WriteLine(" === Desafio 3.1 - Tabuada com FOR === \n");
Console.WriteLine(" DADO QUE o usuário esteja no sistema para gerar a tabuada.  \n");
Console.WriteLine(" QUANDO usuário digita algum valor número \n");
Console.WriteLine(" ENTÃO será impresso no terminal a tabuada.\n");
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
