using System;

// A classe Gerente herda os métodos da classe Imposto
public class Gerente : Imposto
{
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine($"O desconto para Gerente do Vale Alimentação é de R${salario * 0.15}");
    }    
}

/* O modificador "override" indica que a reescrita do método.
*/