using System;

public class Exemplo004
{
	public static void executar ()
	{
		Console.WriteLine("Escreva o numero de eleitores do Municipio: ");
		int eleitores = int.Parse(Console.ReadLine());
		Console.WriteLine("Quantos votos em Bracos teve? ");
		int Brancos = int.Parse(Console.ReadLine());
		Console.WriteLine("Quantos votos em nulo teve? ");
		int Nulo = int.Parse(Console.ReadLine());
		Console.WriteLine("Quantos votos validos teve? ");
		int validos = int.Parse(Console.ReadLine());


		Console.WriteLine($"A porcentagem de votos Brancos {(double)Brancos/eleitores * 100:F2}%");
		Console.WriteLine($"A porcentagem de votos Nulos {(double)Nulo/eleitores * 100:F2}%");
		Console.WriteLine($"A porcentagem de votos validos {(double)validos / eleitores * 100:F2}%");
		
	}
}
