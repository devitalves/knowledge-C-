﻿using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.15;

        Console.WriteLine(salario);
        int salarioInteiro;
        salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        // O long é um tipo de variável de 64 bits
        long x;
        x - 200000000000;
        Console.WriteLine(x);


        short y;
        y = 15000;
        Console.WriteLine(y);

        float altura = 1.62f;
        Console.WriteLine(altura);
        
        
        
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();


    }
}