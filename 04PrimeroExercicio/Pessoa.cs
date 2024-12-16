using System;

class Pessoa
{
    //Atributos da classe peso e altura
    public double peso, altura;
    // calculo de imc
    public double calculo()
    {
        return peso / (altura * altura);
    }
    //Situacao do imc
    public string situacao(double imc)
    {
        // variavel de retorno
        string retorno;

        if(imc < 18.5)
        {
            retorno = "Abaixo do peso";
        }
        else if(imc < 25)
        {
            retorno = "Peso normal";
        }
        else if(imc < 30)
        {
            retorno = "Acima do peso";
        }
        else if(imc < 35)
        {
            retorno = "Obesidade I";
        }
        else if(imc < 40)
        {
            retorno = "Obesidade II";
        }
        else
        {
            retorno = "Obesidade III";
        }
        return retorno;
    }
    //Mensagem da pessoa
    public void mensagem()
    {
       //Obter o calculo
       double obterCalculo = calculo();
       //Obter a situacao
       string obterSituacao = situacao(obterCalculo);
       //Exibir a mensagem
       Console.WriteLine("Seu imc e "+obterCalculo+" sua situação é "+obterSituacao);
    }
}