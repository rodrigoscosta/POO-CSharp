using System;

public class Pessoa
{
    // Atributos protegidos
    protected string nome;
    protected int idade;
    protected int telefone;

    // Método protegido
    protected void mensagemPessoa()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Telefone: {telefone}");
    }       
}