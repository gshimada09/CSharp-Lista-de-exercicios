using System;

public class  Exemplo021
{
	public static void Executar()
	{
		Console.WriteLine("Diigite o hora do inicio do jogo: ");
		int inicio = int.Parse(Console.ReadLine());

		Console.WriteLine("digite a hora do fim do jogo: ");
		int final = int.Parse(Console.ReadLine());

		int horas = final - inicio;

		if (horas <= 0)
		{
			horas += 24;

		}
		Console.WriteLine($"O jogo durou {horas}");
		
	}
}
