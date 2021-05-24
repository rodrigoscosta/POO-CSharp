using System;
public class Pessoa
{
    // Atributos
    public string nome;
    public double peso, altura;

    // Método calculo
    public double calcularIMC()
    {
        return peso / (altura * altura);
    }

    public string situacao(double imc)
    {
        if (imc < 18.5) { return "abaixo do peso"; }
        else if (imc < 25) { return "peso normal"; }
        else if (imc < 30) { return "acima do peso"; }
        else if (imc < 35) { return "obesiddade I"; }
        else if (imc < 40) { return "obesidade II"; }
        else { return "obesidade III"; }
    }

    public void mensagem()
    {
        double obterIMC = calcularIMC();
        string obterSituacao = situacao(obterIMC);

        Console.WriteLine($"{nome}, sua classificação no IMC é {obterSituacao}");
    } 
}
