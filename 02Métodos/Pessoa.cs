using System;

class Pessoa
{
    //Podemos ter varios metados com o mesmo nome mas com parametros diferentes
    //Método 01
    public void apresentar()
    {
        Console.WriteLine("Ola, Mundo!");
    }
    //Método 02
    public void apresentar(string nome)
    {
        Console.WriteLine("Ola "+nome);
    }
    //Método 03
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine("Ola "+nome+" voce tem "+idade+" anos");
    }  
}