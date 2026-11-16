using System;

public class Exemplo030
{
	public static void Executar()
	{
		Console.WriteLine("Digite um numero");
		int numero = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite um numero difente do primeiro: ");
        int numero2 = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite um numero diferente dos primeiros numeros: ");
        int numero3 = int.Parse(Console.ReadLine());

		int UM = 0;
		int DOIS = 0;
		int TRES = 0;

		if (numero < numero2 || numero < numero3)
		{
			if (UM == 0) { 
				UM = numero; 
			} else if (DOIS == 0)
			{
				DOIS = numero;
			}
			else
			{
				TRES = numero;

			}


			if (numero2 < numero || numero2 < numero3)
			{
				if (UM == 0)
				{
					UM = numero2;
				}
				else if (DOIS == 0)
                {
					DOIS = numero2;
                }
				else
				{
					TRES = numero2;
				}


				if (numero3 < numero || numero3 < numero2)
				{
					if (UM == 0)
					{
						UM = numero3;
					}
					else if (DOIS == 0)
					{
						DOIS = numero3;
					}
				}

				else
				{
					TRES = numero3;
				}

				Console.WriteLine($"{UM}, {DOIS}, {TRES}");

			} 
		
		}
    }
}
