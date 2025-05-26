using System;

Console.WriteLine(" === Desafio 3.4 - Unificando as 3 estruturas === \n");
Console.WriteLine(" DADO QUE o sistema seja iniciado.  \n");
Console.WriteLine(" E o combustível for carregado até 100%  \n");
Console.WriteLine(" E o operador passar pelas verificações no menu  \n");
Console.WriteLine(" QUANDO a contagem regressiva for concluída com sucesso  \n");
Console.WriteLine(" ENTÃO o foguete será lançado com sucesso ao escolher a opção de lançament\n");
Console.WriteLine(" Mamão?! Bora lá! \n\n\n");

Thread.Sleep(5000);

Console.WriteLine("🚀 Iniciando sequência de lançamento...");


Console.WriteLine("\n🔢 Contagem regressiva iniciada:");
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine($"⏳ {i}");
    Thread.Sleep(300);
}

int combustivel = 0;
Console.WriteLine("\n⛽ Carregando combustível...");
while (combustivel < 100)
{
    combustivel += 20;
    Console.WriteLine($"🔋 Combustível: {combustivel}%");
    Thread.Sleep(400); 
}
Console.WriteLine("✅ Combustível 100%");


int opcao;
do
{
    Console.WriteLine("\n=== Painel de Controle ===");
    Console.WriteLine("1 - Verificar combustível");
    Console.WriteLine("2 - Verificar temperatura");
    Console.WriteLine("3 - Lançar foguete");
    Console.WriteLine("0 - Cancelar missão");
    Console.Write("Escolha uma opção: ");

    string? entrada = Console.ReadLine();

    if (!int.TryParse(entrada, out opcao))
    {
        Console.WriteLine("❌ Entrada inválida.");
        continue;
    }

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"🔋 Combustível atual: {combustivel}%");
            break;
        case 2:
            Console.WriteLine("🌡️ Temperatura: Normal (26°C)");
            break;
        case 3:
            Console.WriteLine("🚀 Foguete lançado com sucesso! Missão iniciada!");
            break;
        case 0:
            Console.WriteLine("🛑 Missão cancelada pelo operador.");
            break;
        default:
            Console.WriteLine("❌ Opção inválida.");
            break;
    }

    if (opcao != 0 && opcao != 3)
    {
        Console.WriteLine("\nPressione qualquer tecla para voltar ao painel...");
        Console.ReadKey();
    }

} while (opcao != 3 && opcao != 0);

Console.WriteLine("\n✅ Programa encerrado. Pressione qualquer tecla para sair...");
Console.ReadKey();
