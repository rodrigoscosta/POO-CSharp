using System;

namespace Calculo_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando um objeto da classe Pessoa
            Pessoa pessoa = new Pessoa();

            // Atribuindo valores ao objeto
            Console.WriteLine("Digite o seu nome: ");
            pessoa.nome = Console.ReadLine();

            Console.WriteLine("Informe o seu peso: ");
            pessoa.peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a sua altura: ");
            pessoa.altura = Convert.ToDouble(Console.ReadLine());

            // Chamando o método mensagem
            pessoa.mensagem();
        }
    }
}
