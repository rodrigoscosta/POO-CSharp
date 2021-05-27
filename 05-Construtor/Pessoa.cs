using System;

class Pessoa
{
    //Construtor
    public Pessoa()
    {
        Console.WriteLine("Construtor executado");
    }

    /* Um construtor é gerado quando instanciamos
     * um objeto de uma classe. Todo construtor é
     * publico e leva o nome de sua classe.
     * Podemos ter vários construtores DESDE que
     * tenham caracteristicas diferentes (Ex: parâmetros).
     */

     public Pessoa (string nome)
     {
         Console.WriteLine($"Olá {nome}");
     }

}