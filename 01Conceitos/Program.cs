﻿using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar um objeto
            Pessoa obj = new Pessoa();
            obj.nome = "Robson";
            obj.idade = 29;
            obj.mensagem();
        }
    }
}