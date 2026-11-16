using System;

public class Exemplo015
{
	public static void Executar()
	{
		Console.WriteLine("Digite um valor: ");
		int valor = int.Parse(Console.ReadLine());
		if(valor >= 0)
		{
			Console.WriteLine("Seu numero é positivo! ");
		}
		else
		{
			Console.WriteLine("Seu numero é negativo! ");
		}
	}
}
