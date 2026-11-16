using System;

public class Exemplo014
{
	public static void Executar()
	{
		Console.WriteLine("Escreva um valor para ser comparado a 10: ");
		int valor = int.Parse(Console.ReadLine());
		if(valor > 10)
		{
			Console.WriteLine("Seu numero é maior que 10! ");
		}
			else
		{
			Console.WriteLine("Seu numero é menor que 10! ");
		}
	}
}
