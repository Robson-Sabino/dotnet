using System;

// Uma classe é algo abistrato é basicamente um molde, dentro das classes temos os Atributos,  
class Pessoa
{
    // Atributo: os atributos vão remeter as caracteristicas que uma pessoa pode ter
    // quando utilizamos o public isso significa que qualquer arquivo .cs pode ter acesso a esse atributo ou do metodo
    // string significa que vai ser uma informação do tipo textual vai poder receber: letras, numeros e caracteres especiais
    public string nome;

    // int significa que vai ser uma informação do tipo numero inteiro
    public int idade;


    // Metodos: os metodos são funções
    // void: ou não a retorno é utilizado quando não se que guardar nunhum dados ou seja é vazio, vamos apenas exibir algo na tela
    public void mensagem()
    {
        Console.WriteLine("Ola "+nome+" você tem "+idade+" anos");
    }


}