using System;

public class Exemplo005
{
	public static void Executar()
	{
		Console.WriteLine("Digite seu salario: ");
		decimal salario = decimal.Parse(Console.ReadLine());
		Console.WriteLine("Digite o percentual de reajuste");
		decimal percentual = decimal.Parse(Console.ReadLine());

		decimal CalcularReajuste = decimal.Parse(Console.ReadLine());
		Console.WriteLine($"Seu salario reajuste ficou {CalcularReajuste + salario}");
	}
}
