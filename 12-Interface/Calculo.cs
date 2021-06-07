using System;

// A classe Calculo herda a interface IPadrao
public class Calculo : IPadrao
{
    public void somar(int numero1, int numero2)
    {
        int soma = numero1 + numero2;

        Console.WriteLine($"A soma é {soma}");
    }

    public void subtrair(int numero1, int numero2)
    {
        int subtracao = numero1 - numero2;

        Console.WriteLine($"A subtração é {subtracao}");
    } 
}
