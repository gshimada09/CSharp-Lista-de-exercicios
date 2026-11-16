using System;

public class Exemplo020
{
	public static void Executar()
	{
		Console.WriteLine("Digite um número: ");
		int numero1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite segundo numero: ");
		int numero2 = int.Parse(Console.ReadLine());

		if (numero1 < numero2)
		{
			Console.WriteLine($"{numero1}, {numero2}");
		} else if (numero1 == numero2)
		{
			Console.WriteLine("Numero invalido, numeros iguais!");
		}
		else
		{
			Console.WriteLine($"{numero2}, {numero1}");
		}
	}
}
