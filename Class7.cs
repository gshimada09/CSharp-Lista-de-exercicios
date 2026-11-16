using System;

public class Exemplo007
{
	public static void Executar()
	{
		Console.WriteLine("Digite o total de carros vendidos: ");
		int TotalCarros = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o valor total");
		double TotalVendas = double.Parse(Console.ReadLine());
		Console.WriteLine("Digite o seu valor");
		double salario = double.Parse(Console.ReadLine());

		double comissso = salario * 0.5;
		double valorVenda = TotalVendas * 0.5;

		Console.WriteLine($"Seu salario final é: { salario + valorVenda }");
	}
}
