using System;

public class Exemplo024
{
	public static void Executar()
	{
		Console.WriteLine("Digite o salario: ");
		double salario = double.Parse(Console.ReadLine());
		Console.WriteLine("Digite o valor total das vendas: ");
		double vendas = double.Parse(Console.ReadLine());

		double comissao = 0.03;
		double comissao2 = 0.05;

		if (vendas <= 1500)
		{
			vendas = vendas * comissao;
			Console.WriteLine($"Sua comissão e de : {comissao * 100}%, salario total: {vendas + salario}");
		}else if (vendas > 1500)
		{
			vendas = vendas * (comissao + comissao2);
			Console.WriteLine($"Sua comissão é de: { (comissao + comissao2) * 100 }%, salario total: {vendas + salario} ");
		}
	}
}
