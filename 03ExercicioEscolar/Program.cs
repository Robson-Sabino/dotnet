using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar um objeto
            Aluno a = new Aluno();
            a.nome = "Robson";
            a.nota1 = 8;
            a.nota2 = 7.5;
            a.mensagem();
        }
    }
}