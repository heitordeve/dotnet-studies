Console.Clear();

Console.WriteLine(" === Desafio 3.3 - Menu interativo com DO WHILE === \n");
Console.WriteLine(" DADO QUE o usuário tenha um sistema com menu interativo.  \n");
Console.WriteLine(" QUANDO usuário digita uma das opção do Menu Interativo \n");
Console.WriteLine(" ENTÃO será impresso no terminal o texto referente a opção do menu informada \n");
Console.WriteLine(" Mamão?! Bora lá! \n\n\n");

int opcao;

do
{
    Console.WriteLine("\n=== Menu ===");
    Console.WriteLine("1 - Exibir data");
    Console.WriteLine("2 - Exibir hora");
    Console.WriteLine("0 - Sair");
    Console.Write("Opção: ");



    // Nesse ponto valido a entrada de dados para evitar que o usuário digita uma letra por exemplo
    string? entrada = Console.ReadLine();

    if (!int.TryParse(entrada, out opcao))
    {
        Console.WriteLine("❌ Opção inválida. Digite um número válido.");
        continue;
    }

    Console.Clear();

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Data: {DateTime.Now.ToShortDateString()}");
            break;
        case 2:
            Console.WriteLine($"Hora: {DateTime.Now.ToShortTimeString()}");
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    if (opcao != 0)
    {
        Console.WriteLine("\n✅ Programa finalizado. Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

} while (opcao != 0);

