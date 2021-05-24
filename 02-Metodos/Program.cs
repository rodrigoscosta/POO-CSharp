using System;

namespace _02_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia da classe Pessoa
            Pessoa obj = new Pessoa();

            // Chamando os 3 métodos criados e atribuindo valores aos parâmetros
            obj.apresentar();
            obj.apresentar("Rodrigo");
            obj.apresentar("Rodrigo", 24);
        }
    }
}
