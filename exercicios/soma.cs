using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número inteiro: ");
        if (!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Entrada inválida. Por favor digite um inteiro.");
            return;
        }
        Console.Write("Digite o segundo número inteiro: ");
        if (!int.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Entrada inválida. Por favor digite um inteiro.");
            return;
        }
        Console.WriteLine($"Soma: {a + b}");
    }
}
