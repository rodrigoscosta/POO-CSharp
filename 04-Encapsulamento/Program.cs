using System;

namespace _04_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia da classe Aluno
            Aluno obj = new Aluno();

            /*Quando é gerado objeto da classe Aluno,
             * os métodos e atributos em private criados nesta classe
             * não são visíveis em outras classes.
             * No exemplo abaixo, só foi possivel chamar
             * o método mensagem, pois está marcado como public.
             * O programa funcionará normalmente.
             */
            obj.mensagem();
        }
    }
}
