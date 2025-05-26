Console.Clear();

Console.WriteLine(" === Desafio 3.2 - Acúmulo de Notas com WHILE === \n");
Console.WriteLine(" Crie um programa em que o usuário deverá digital várias notas.  \n");
Console.WriteLine(" O loop termina quando ele digitar -1. Ao final, exiba a média. \n");
Console.WriteLine(" Mamão?! Bora lá! \n\n\n");

double nota;
double soma = 0;
int quantidade = 0;

while (true)
{
    Console.Write("Nota: ");
    string? entrada = Console.ReadLine();

    // Esse ponto valido a entrada de dados para evitar que o usuário digita uma letra por exemplo
    if (!double.TryParse(entrada, out nota))
    {
        Console.WriteLine("❌ Entrada inválida. Digite um número válido.");
        continue;
    }

    // Caso usuário digite -1, quer dizer que ele quer parar o loop e seguir para o cálculo da média
    if (nota == -1)
        break;

    soma += nota;
    quantidade++;
}

// Cálculo da média
double media = quantidade > 0 ? soma / quantidade : 0;

// Resultado
Console.WriteLine($"\n📊 Média das notas: {media:F2}");
Console.WriteLine("\n✅ Programa finalizado. Pressione qualquer tecla para sair...");
Console.ReadKey();
