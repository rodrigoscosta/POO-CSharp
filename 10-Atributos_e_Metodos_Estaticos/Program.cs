using System;

namespace _10_Atributos_e_Metodos_Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            Exemplo.nome = Console.ReadLine();

            Exemplo.soma(30, 30);
        }
    }
}

/*
* A palavra "static" permite acesso ao método/atributo sem precisar instanciar um objeto;
* Isso quer dizer que um método, para ser acessível sem a necessidade de existir um objeto da classe, além de ser estático, também deve ser público.
*/
