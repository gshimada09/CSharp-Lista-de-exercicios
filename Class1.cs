using System;

public class Exemplo001
{
	public static void executar()
	{
        Console.Write("Escolha um numero: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write(numero - 1);
    }
}
