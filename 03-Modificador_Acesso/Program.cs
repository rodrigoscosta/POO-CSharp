using System;

namespace _03_Modificador_Acesso
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando a classe produto
            Produto produto = new Produto();

            // Só é exibido o atributo nome, já que o atributo valor é privado a classe Produto
            Console.WriteLine("Digite um nome: ");
            produto.nome = Console.ReadLine();
            Console.WriteLine(produto.nome);        
        }
    }
}
