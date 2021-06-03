using System;
public class Imposto
{
    // Métodos
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine($"O desconto padrão do Vale Alimentação é de R${salario * 0.1}");
    }

    public void valeTransporte(double salario)
    {
        Console.WriteLine($"O desconto padrão do Vale Transporte é de R${salario * 0.06}");
    }
}

/*
* O modificador de acesso virtual indica que o método pode ser sobrescrito na classe derivada.
*/