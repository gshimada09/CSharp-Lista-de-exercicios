using System;

public class Exemplo031
{
	public static void Executar()
	{
		Console.WriteLine("Digite o valor A: ");
		int valor = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite o valor B: ");
		int valor2 = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite o valor C: ");
		int valor3 = int.Parse(Console.ReadLine());



		if (valor < valor2 + valor3 && valor2 < valor3 + valor && valor3 < valor2 + valor)
		{
			Console.WriteLine("É triangulo! ");
		}
		else
		{
			Console.WriteLine("Não é triangulo");
		} 

	}
}
