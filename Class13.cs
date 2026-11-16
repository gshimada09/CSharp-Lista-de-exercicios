using System;

public class Exemplo018
{
	public static void Executar()
	{
		Console.WriteLine("Qual ano de nascimento: ");
		int anoNascimento = int.Parse(Console.ReadLine());

		int anoAtual = 2026;

		int idade = anoAtual - anoNascimento;

		if (idade >= 18)
		{
			Console.WriteLine("Seu voto vai ser OBRIGATORIO! ");
		}
		else if (idade >= 16 )
		{
			Console.WriteLine("O seu voto é opcional! ");
		}
		else
		{
			Console.WriteLine("Voce nao pode votar ainda! ");
		}



	}
}
