using System;

public class Exemplo025
{
    public static void Executar()
    {
        Console.WriteLine("Digite o número da sua conta: ");
        int numeroConta = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o saldo da sua conta: ");
        double saldo = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite os débitos da sua conta: ");
        double debitos = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o crédito da sua conta: ");
        double credito = double.Parse(Console.ReadLine());
        double saldoAtual = saldo - debitos + credito;

        if (saldoAtual >= 0)
        {
            Console.WriteLine("Saldo positivo!");
        }
        else
        {
            Console.WriteLine("Saldo negativo!");
        }
    }
}
