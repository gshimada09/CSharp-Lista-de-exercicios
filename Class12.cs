using System;

public class Exemplo017
{
	public static void Executar()
	{
		Console.WriteLine("Digite a sua primeira nota: ");
		int nota1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite a sua segunda nota: ");
		int	nota2 = int.Parse(Console.ReadLine());
		int CalculoAritica = (nota1 + nota2 / 2);

		if (CalculoAritica >= 6) {

			Console.WriteLine($"Voce foi aprovado! com a medía {CalculoAritica} ");

		}
		else
		{
			Console.WriteLine($"Voce foi reprovado! com a media {CalculoAritica}");
		}
	}
}
