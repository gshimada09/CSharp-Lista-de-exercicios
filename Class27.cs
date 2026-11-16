using System;

public class Exemplo032
{
	public static void Executar()
	{
		Console.WriteLine("Escreva o nome do time: ");
		string nome = Console.ReadLine();
		
		Console.WriteLine("Escreva o nome de outro time: ");
		string nome2 = Console.ReadLine();
	
		Console.WriteLine("Digite o numero de gols marcados para o time 1: ");
		int gols1 = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite o numero de gols marcados para seu time 2: ");
		int gols2 = int.Parse(Console.ReadLine());

		if (gols1 > gols2)
		{
			Console.WriteLine($"Time {nome} Vencedor! ");
		}
		else if (gols1 == gols2)
		{
			Console.WriteLine("Empate");
		}
		else
		{
			Console.WriteLine($"Time {nome2} vencedor! ");
		}
	}
}
