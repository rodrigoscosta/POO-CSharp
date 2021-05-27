using System;

namespace _04_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia da classe Aluno
            Aluno obj = new Aluno();
            
            obj.mensagem();
        }
    }
}

/*Quando é gerado objeto da classe Aluno,
* os métodos e atributos em private criados nesta classe
* não são visíveis em outras classes.
* No exemplo abaixo, só foi possivel chamar
* o método mensagem, pois está marcado como public.
* O programa funcionará normalmente.
*
* ENCAPSULAMENTO permite proteger os métodos e atributos de uma classe
*
* Por meio desse mecanismo, podemos impedir o acesso direto por outros objetos e garantir que todo o processo
* de comunicação com o objeto aconteça por um conjunto predeterminado de operações.
*
* A proteção oferecida pelo encapsulamento é baseada na utilização de modificadores de acesso (public, private, protected, default).
*
* Dentro de uma classe, os atributos podem ser declarados públicos e privados.
*
* Atributos públicos Podem ser acessados ou modificados por todo objeto que:  Instancia uma classe que contém tais atributos.
*
* Atributos privados Só podem ser acessados ou modificados pelo objeto que está instanciando a classe. O acesso ocorre por meio de um método.
*
* O encapsulamento é o mecanismo que permite a proteção de métodos e atributos sensíveis dentro de uma classe, impedindo o acesso direto a eles por outros objetos.
*/
