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

/* 
* HERANÇA significa aquilo que se herda, aquilo que é transmitido por hereditariedade.
*
* A herança serve para compartilhar métodos, atributos e
* objetos entre classes;
*
* Caso o método/atributo/objeto esteja marcado como private,
* mesmo com a herança, não temos acesso;
*
* Uma notação muito aceita é a seguinte: coloca-se o nome da classe filha mais o símbolo de dois-pontos " : " e, em seguida, coloca-se o nome da classe herdada,
*
* A herança é múltipla quando uma classe herda características de duas ou mais classes-pai. 
* Algumas linguagens – como Java e C # – NÃO permitem herança múltipla. Nesses casos, somente é possível existir APENAS UMA herança simples por classe
*
* A classe principal ou original é chamada de superclasse ou classe-mãe. 
* Sinônimos: Os termos classe-base, supertipo, superclasse, classe-pai, classe-mãe e classe primitiva são sinônimos.
*
* A classe que herda é considerada classe-filha ou subclasse.Sinônimos: classe derivada, subtipo, subclasse e classe filha
*/
