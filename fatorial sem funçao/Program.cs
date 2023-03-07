using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        int fatorial = Fatorial(numero);

        Console.WriteLine($"O fatorial de {numero} é {fatorial}");
    }

    static int Fatorial(int num)
    {
        if (num == 0)
        {
            return 1;
        }
        else
        {
            return num * Fatorial(num - 1);
        }
    }
}