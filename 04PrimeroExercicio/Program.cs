using System;

namespace _04PrimeroExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar um objeto
            Pessoa p = new Pessoa();
            p.peso = 180;
            p.altura = 1.85;
            p.calculo();
            p.mensagem();
        }
    }
}