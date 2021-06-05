using System;

abstract class Padrao
{
    // Obrigatório
    public abstract void taxaEmprestimo(double valor);

    // Opcional
    public void calculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine($"Valores obtidos pela poupança R${valor * taxa}");
    }
}
