using System;

public class Exemplo036
{
	public static void Executar()
	{
		Console.WriteLine("Digite sua idade(M): ");
		int idadeP1 = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite sua idade(M): ");
		int idadeP2 = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite sua idade(F): ");
		int idadeF1 = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite sua idade(F): ");
		int idadeF2 = int.Parse(Console.ReadLine());


		int novaF = 0;
		int velhaF = 0;

		int velhoM = 0;
		int novoM = 0;




		if (idadeP1 != idadeP2 )
		{
			if(idadeP1> idadeP2)
			{
				 velhoM = idadeP1;
				 novoM = idadeP2;
			}
			else
			{
				 velhoM = idadeP2;
				novoM = idadeP1;
			}

			if (idadeF1 != idadeF2)
			{
				if (idadeF1 < idadeF2)
				{
					 novaF = idadeF1;
					 velhaF = idadeF2;
				}
				else
				{
					 novaF = idadeF2;
					 velhaF = idadeF1;
				}
			}
				int calculo = novaF + velhoM;
				int calculo2 = velhaF + novoM;

			Console.WriteLine($"Mulher mais nova + homem mais velho: {calculo}");
			Console.WriteLine($"Homem mais novo + mulher mais velha: {calculo2}");
		}
	}
}
