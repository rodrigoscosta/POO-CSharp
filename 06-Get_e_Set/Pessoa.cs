class Pessoa
{
    // Atributo
    private string nome;

    /* Set - envio de dados/informações para um atributo;
    *  Get - obtém esses dados/informações;
    *
    * Devem ser publicos;
    *
    * Podemos utilizar eles juntos ou apenas 1;
    *
    * Englobam conceitos de Encapsuçamento, pois evitam
    * deixar atributos de maneira publica;
    *
    * Para utilza-los em outra classe, devemos criar
    * um método publico, do mesmo tipo, e por padrão,
    * com o mesmo nome do atributo a que se refere iniciando
    * com a primeira letra maiúscula.
    */

    public string Nome
    {
        // Retorno do valor
        get {return nome;}
        // Será o valor que o usuário irá informar em outra classe
        set {nome = value;}
    }       
}