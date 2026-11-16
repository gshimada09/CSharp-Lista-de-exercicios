using System;

public class Exemplo002
{
	public static void executar()
	{
		Console.Write("Numero da base: ");
		int basee = int.Parse(Console.ReadLine());
		Console.Write("Digite a altura: ");
		int altura = int.Parse(Console.ReadLine());
		double calculo = (altura * basee) / 2.0;

		Console.WriteLine($"O tamanho do seu retangulo {calculo} ");
	}
}
