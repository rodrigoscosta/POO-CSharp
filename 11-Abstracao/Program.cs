using System;

namespace _11_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia da classe PessoaFisica
            PessoaFisica pf = new PessoaFisica();
            Console.WriteLine("Digite o valor do empréstimo para PF");
            pf.taxaEmprestimo(Convert.ToDouble(Console.ReadLine()));

            // Instancia da classe PessoaJuridica
            PessoaJuridica pj = new PessoaJuridica();
            Console.WriteLine("Digite o valor do empréstimo para PJ");
            pj.taxaEmprestimo(Convert.ToDouble(Console.ReadLine()));
        }
    }
}

/* ABSTRAÇÃO consiste na habilidade de se concentrar e reunir os aspectos essenciais de um contexto qualquer,  possibilitando 
* a modelagem de conceitos, elementos, problemas e características do mundo real, as características menos importantes 
* ou acidentais são desconsideradas;
*
* É uma classe que pode conter métodos obrigatórios para todas as classes que a herdarem;
*
* É possível criar métodos não obrigatórios, para que as classes que herdem consigam usar;
*
* Não é possível instanciar uma classe abstrata;
*
* Garante uma estrutura pré moldada com ações que podem ser realizadas;
*
* Como é usada a herança, cada classe só pode herdar APENAS UMA classe abstrata
* EX: class Jogo: JogoAcao > Certo
*     class Jogo: JogoAcao, JogoTerror > Errado
*
*/