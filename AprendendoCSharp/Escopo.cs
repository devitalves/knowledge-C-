using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 7 - Condicionais");


        int idadeJoao = 16;
        int quantidadePesssoas = 2;

        bool acompanhado = quantidadePesssoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "João está acompanhado";
        }
        else
        {
            textoAdicional = "João não está acompnahdo";
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }

        else
        {
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("Tecle enter paa fechar...");
        Console.ReadLine();
    }
}
