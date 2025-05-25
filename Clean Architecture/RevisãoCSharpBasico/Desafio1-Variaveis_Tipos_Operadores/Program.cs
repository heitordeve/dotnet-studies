Console.WriteLine(" === Desafio 1 === \n");
Console.WriteLine(" Crie um programa em que o usuário posso digitar no console:  \n");
Console.WriteLine(" nome, idade e salário de um usuário. \n");
Console.WriteLine(" Em seguida fazer a impressão no console. \n");
Console.WriteLine(" Mamão?! Bora lá! \n\n\n");


Console.Write(" Digite o nome: ");
string nome = Console.ReadLine();

Console.Write(" Digite a sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.Write(" Digite o seu salário: ");
double salario = double.Parse(Console.ReadLine());

Console.WriteLine("Olá, " + nome + "\n");
Console.WriteLine("Vocé tem " + idade + " anos." + "\n");
Console.WriteLine("O seu salário é R$ " + salario + "\n");