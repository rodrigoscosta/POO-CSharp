using System;

namespace Exercicio_Escolar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar objeto da classe aluno
            Aluno obj = new Aluno();

            // Valores dos parâmetros nome, nota1 e nota2
            Console.WriteLine("Digite o nome do aluno(a): ");
            obj.nome = Console.ReadLine();
            Console.WriteLine("Informe a primeira nota: ");
            obj.nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota: ");
            obj.nota2 = Convert.ToDouble(Console.ReadLine());

            obj.mensagem();
        }
    }
}
