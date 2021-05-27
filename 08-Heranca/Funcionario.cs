using System;

// A classe Funcionario está herdando a classe Pessoa
public class Funcionario : Pessoa
{
    // Atributos privados
    private string matricula;
    private double salario;
    private string cargo;

    // Método privado
    private void mensagemFuncionario()
    {
        Console.WriteLine($"Matrícula: {matricula}");
        Console.WriteLine($"Salário: {salario}");
        Console.WriteLine($"Cargo: {cargo}");
    }

    // Construtor
    public Funcionario(string nome, int idade, int telefone, string matricula, double salario, string cargo)
    {
        this.nome = nome;
        this.idade = idade;
        this.telefone = telefone;
        this.matricula = matricula;
        this.salario = salario;
        this.cargo = cargo;

        mensagemPessoa();
        mensagemFuncionario();
    }      
}