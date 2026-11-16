using System;

public class Exemplo042
{
	public static void Executar()
	{
		Console.WriteLine("Insira o código do trabalhador: ");
		int codigo = int.Parse(Console.ReadLine());
		int anoNasc = 0;
		int anoIngress = 0;

		if (codigo = 123)
		{
			anoNasc = 1800;
			anoIngress = 2020;
		}
		else if ()
		{

		}


			string aponsentadoria;

		if (2026 - anoNasc >= 65 || 2026 - anoIngress)
		{
			aponsentadoria = "Requerer aponsentadoria. ";

		}else if ((2026 - anoNasc) <= 60 && (2026 - anoIngress) <= 25) 
		{
			aponsentadoria = "Requerer aponsentadoria. ";
		}
		else
		{
			aponsentadoria = "Não requer aponsentadoria. ";
		}



			Console.WriteLine($"\nO funcionario {codigo}: \n- Possui {2026 - anoNasc} anos idade. \n- trabalhou em  ")
	}
}
