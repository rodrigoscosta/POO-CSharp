using System;

namespace _01_Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar um objeto da classe Pessoa
            Pessoa obj = new Pessoa();
            
            // Definindo os valores aos atributos nome e idade
            Console.WriteLine("Digite seu nome: ");
            obj.nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            obj.idade = Convert.ToInt32(Console.ReadLine());
            
            // Chamando o método mensagem
            obj.mensagem();
        }
    }
}

// O objetivo da POO é possibilitar a reutilização de trechos de programação e, com isso, ganhar tempo e tornar a codificação mais “inteligente”;

// Classe - Define os atributos e métodos comuns que serão compartilhados por um objeto, como se fosse um molde;

// Objeto é uma instancia de uma classe, tem Atributos, Métodos e Estados;

// Instanciar - criar/gerar um objeto a partir de uma classe existente.
