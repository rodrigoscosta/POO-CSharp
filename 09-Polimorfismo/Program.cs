using System;

namespace _09_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar classe Estagiario
            Imposto objetoE = new Estagiario();
            objetoE.valeAlimentacao(1000);
            objetoE.valeTransporte(1000);
            Console.WriteLine("---------------------------");

            // Instanciar classe Gerente
            Imposto objetoG = new Gerente();
            objetoG.valeAlimentacao(6000);
            objetoG.valeTransporte(6000);
            Console.WriteLine("---------------------------");

            // Instanciar classe Atendente
            Imposto objetoA = new Atendente();
            objetoA.valeAlimentacao(2000);
            objetoA.valeTransporte(2000);
            Console.WriteLine("---------------------------");
        }
    }
}

/* Polimorfismo = várias formas;
* 
* O polimorfismo é complementado pelos conceitos de herança e sobrecarga de métodos;
* 
* Podemos enviar uma mesma mensagem para diferentes objetos e fazê-los responder da maneira correta;
* 
* Polimorfismo permite que classes forneçam diferentes implementações de métodos que são chamados com o mesmo nome;
* 
* Sobrecarga consiste em escrever métodos de mesmo nome com assinaturas diferentes. Em outras palavras, podemos criar vários métodos de mesmo nome com diferentes passagens de parâmetros;
*
* O modificador de acesso "virtual" indica que o método pode ser sobrescrito na classe derivada;
* 
* O modificador "override" indica que a reescrita do método.
* 
*/
