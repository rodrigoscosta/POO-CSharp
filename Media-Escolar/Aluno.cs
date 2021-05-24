using System;
public class Aluno
{
    // Atributos
     public string nome;
     public double nota1, nota2;

     // Métodos
     public double media()
     {
         return (nota1 + nota2) / 2;
     }

     public string situacao(double media)
     {
         return media >= 7 ? "aprovado(a)" : "reprovado(a)";
     }

     public void mensagem()
     {
         // Obtém a média
         double obterMedia = media();

         // Obtém a situação
         string obterSituacao = situacao(obterMedia);

         Console.WriteLine($"O/A aluno(a) {nome} está {obterSituacao} com média de {obterMedia}");
     }
}