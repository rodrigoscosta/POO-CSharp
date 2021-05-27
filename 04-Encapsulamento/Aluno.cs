using System;
class Aluno
{
    // Atributos privados
    private double nota1, nota2;

    // Método privado
    private double media()
    {
        return (nota1 + nota2) / 2;
    }

    // Método publico
    public void mensagem()
    {
        Console.WriteLine("Informe a primeira nota: ");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota: ");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"A média é {media()}");
    }
}
        
