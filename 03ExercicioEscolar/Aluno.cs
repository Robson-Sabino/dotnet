using System;

class Aluno
{
    //Atributos
    public string nome;
    public double nota1, nota2;

    //Metodos de media
    public double media()
    {
        return (nota1 + nota2) / 2;
    }

    //Metodos de situacao
    public string situacao(double media)
    {
        return media >= 7 ? "Aprovado" : "Reprovado";
    }

    //Metodos de apresentar
    public void mensagem()
    {
        //Obter media
        double obterMedia = media();
        //Obter Situacao
        string obterSituacao = situacao(obterMedia);
        //Mensagem
        Console.WriteLine("O Aluno " +nome+" está "+obterSituacao+" com a media "+obterMedia);
    }

}