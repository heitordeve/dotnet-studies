Console.WriteLine(" === Desafio 1 === \n");
Console.WriteLine(" DADO QUE o usuário esteja no sistema para informar os dados o funcionário.  \n");
Console.WriteLine(" QUANDO ele informa os dados como Nome, Idade e Salário. \n");
Console.WriteLine(" ENTÃO será impresso no terminal as informações do Colaborador\n")
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