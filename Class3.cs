using System;

public class Exemplo003
{
	public static void executar()
	{
		Console.WriteLine("Digite sua idade: ");
		int idade = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o mês");
		int mes = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o dia");
		int dia = int.Parse(Console.ReadLine());

		Console.WriteLine($"Você tem {idade * 365 } + {dia + 30} dias de vida ");
	}
}
