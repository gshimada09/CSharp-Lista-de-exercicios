using System;

public class Exemplo023
{
	public static void Executar()
	{
		Console.WriteLine("Digite seu nome: ");
		string nome = Console.ReadLine();
		int altura = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite seu sexo: (M / F)");
		char sexo = char.Parse(Console.ReadLine());

		double Masculino_peso = 72.7;
		double Feminino_peso = 62.1;

		if (sexo == 'M')
		{
			double peso_ideal = (Masculino_peso * altura) - 58;
			Console.WriteLine(peso_ideal);

		}
		else if (sexo == 'F')
		{
			double peso_ideial = (Feminino_peso * altura) - 44.7;
			Console.WriteLine(peso_ideial);
		}
		else
		{
			Console.WriteLine("Invalido!");
		}
		 
	}
}
