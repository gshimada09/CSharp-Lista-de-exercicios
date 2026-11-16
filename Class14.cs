using System;

public class Exemplo019
{
	public static void Executar()
	{
		Console.WriteLine("Digite um numero ");
		int numero1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o seu segundo numero: ");
		int numero2 = int.Parse(Console.ReadLine());

		if (numero1 > numero2)
		{
			Console.WriteLine("o numero 1 é maior que o numero 2 ");
		}
		else
		{
			Console.WriteLine("o numero 2 é maior que o numero 1 ");
		}
	}
}
