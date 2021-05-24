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
