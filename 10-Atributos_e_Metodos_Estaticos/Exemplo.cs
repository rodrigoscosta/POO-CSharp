using System;
public class Exemplo
{
    // Atributo estático
    public static string nome;
    // Método estático
    public static void soma(int numero1, int numero2)
    {
        Console.WriteLine(numero1 + numero2);
    }   
}

/* 
* A palavra "static" permite acesso ao método/atributo sem precisar instanciar um objeto;
*/
