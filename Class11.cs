using System;

public class Exemplo016
{
	public static void Executar()
	{
		Console.WriteLine("Digite a quantidade de maçãs compradas! ");
		int quantidade = int.Parse(Console.ReadLine());
		double meiaDuzia = 1.30;
		double duzia = 1.00;

		if (quantidade <12 )
		{
			Console.WriteLine($"sua compra fica R${meiaDuzia * quantidade}");
		}
		else
		{
			Console.WriteLine($"sua compra fica R${duzia * quantidade}");
		}
	}
}
