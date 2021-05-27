using System;

namespace _06_Get_e_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia da classe Pessoa
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite um nome: ");
            // Set - pois está enviando um dado
            pessoa.Nome = Console.ReadLine();

            // Get - pois está exibindo/buscando um dado
            Console.WriteLine(pessoa.Nome);
        }
    }
}


