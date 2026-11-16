using System;

public class Exemplo012
{
    public static void Executar()
    {
        Console.WriteLine("Digite a temperatura em graus Fahrenheit: ");
        int grausFahrenheit = int.Parse(Console.ReadLine());

        int grausCelsius = (grausFahrenheit - 32) * 5 / 9;
        Console.WriteLine(grausCelsius);
    }
}