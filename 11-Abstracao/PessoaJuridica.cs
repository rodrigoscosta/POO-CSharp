using System;

// A classe PessoaJuridica herda os métodos da classe Padrao
class PessoaJuridica : Padrao
{
    // Método obrigatório
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine($"A taxa de emprétimo para PJ é de R${valor * 0.2}");
    } 
}
