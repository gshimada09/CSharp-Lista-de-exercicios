using System;

public class Exemplo044
{
	public static void Executar()
	{
		Console.WriteLine("Insira o primeiro valor: \n");
		double valor1 = double.Parse(Console.ReadLine()), valor2 = 0;

		while (valor2 == 0)
		{
			Console.WriteLine("\n Insira o segundo valor: \n");
			valor2 = double.Parse(Console.ReadLine());
		}

		Console.WriteLine($"\nO resultado de {valor1} dividido por {valor2} é: {valor1 / valor2} ");
	}
}
