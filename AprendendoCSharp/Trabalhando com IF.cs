using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 7 - Condicionais");


        int idadeJoao = 16;
        int quantidadePesssoaas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (quantidadePesssoaas > 0)
            {
                Console.WriteLine("Ele está acompnhado, pode entarr!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }

        }

        Console.WriteLine("Tecle enter paa fechar...");
        Console.ReadLine();
    }
}
