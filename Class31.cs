using System;

public class Exemplo038
{
	public static void Executar()
	{
		int senha1 = 9999;

		Console.WriteLine("Digite a senha: ");
		int senha = int.Parse(Console.ReadLine());

		int contador = 0;

		while (senha != senha1 )
		{
			Console.WriteLine("Digite a senha novamente : ");
			 senha = int.Parse(Console.ReadLine());
			contador++;

			if (senha == senha1)
			{
				Console.WriteLine("Voce esta logado! ");
			}
		}
	}
}
