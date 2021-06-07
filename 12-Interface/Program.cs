using System;

namespace _12_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
           // Instanciar a classe Calculo
           Calculo calculo = new Calculo();
           calculo.somar(10, 50);
           calculo.subtrair(40, 5);
        }
    }
}

/*
* Interface é  um tipo de classe que contém apenas as assinaturas de métodos, propriedades, eventos e indexadores;
* 
* É uma forma de criar e definir um contrato que ajuda na organização do código;
*
* Uma classe pode implementar várias interfaces;
*
* Uma interface NÃO pode ser instanciada;
*
* Uma interface pode herdar de uma ou mais interfaces básicas;
*
* Uma interface NÃO pode conter um construtor;
*
* No C# a sintaxe usada para indicar a utilização de uma interface é colocar dois pontos após o nome da classe concreta 
* que vai implementar a interface seguido do nome da interface;
* Ex:   Jogo : ITeste   (Jogo = classe concreta   ITeste = interface)
*
* No C#, por padrão, um método criado na Interface não tem corpo e são abstratos e públicos;
*
* Nas boas práticas do C#, toda Interface tem a inicial I seguido do nome da interface
* Ex: ITeste, IProduto, IAcoes;
*/