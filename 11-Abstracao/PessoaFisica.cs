using System;

// A classe PessoaFisica herda os métodos da classe Padrao
class PessoaFisica : Padrao
{
    // Método obrigatório
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine($"A taxa de emprétimo para PF é de R${valor * 0.1}");
    }
}
