using System;

// A classe Atendente herda os métodos da classe Imposto
public class Atendente : Imposto
{
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine($"O desconto para Atendente do Vale Alimentação é de R${salario * 0.12}");
    }  
}

/* O modificador "override" indica que a reescrita do método.
*/