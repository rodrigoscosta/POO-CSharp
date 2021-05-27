using System;

namespace _08_Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia da classe Funcionário
            Funcionario funcionario = new Funcionario("Rodrigo", 24, 999999999, "1214210", 2.000, "Gerente");
        }
    }
}

/* A herança serve para compartilhar métodos, atributos e
* objetos entre classes;
*
* Caso o método/atributo/objeto esteja marcado como private,
* mesmo com a herança, não temos acesso;
*
* Para herdar de uma classe para outro, usamos o sinal de " : ".
*
* No C#, não existe herança múltipla (Ex: a classe Funcionario não pode
* estender outras classes, APENAS 1, que no caso, é Pessoa).
*/
