using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 13 - Encadeando For");
       
        //*
        //**
        //***
        //****
        //*****

        //com break
        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas < 10; contadorColunas++)
            {
                Console.WriteLine("*");
                if (contadorColunas >= contadorLinhas)
                    break;
            }
            Console.WriteLine();
        }

        Console.WriteLine("Tecle enter paa fechar...");
        Console.ReadLine();
    }
}