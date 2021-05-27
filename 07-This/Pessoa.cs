using System;

class Pessoa
{
    // Atributo
    private string nome = "Rodrigo";

    // Construtor
    public Pessoa (string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}

/* This refere-se à instância atual da classe e também é usada como um modificador
* do primeiro parâmetro de um método de extensão;
* 
* Pode ser usado para passar um objeto com parâmetro
* para outros métodos.
* 
*/