using System;

class Program
{
    static void Main()
    {
        Console.Write("Nota (0-100): ");
        if (!double.TryParse(Console.ReadLine(), out double nota))
        {
            Console.WriteLine("Por favor, digite uma nota numérica.");
            return;
        }
        if (nota < 0 || nota > 100)
        {
            Console.WriteLine("Nota inválida. Deve estar entre 0 e 100.");
        }
        else if (nota >= 70)
        {
            Console.WriteLine("Aprovado");
        }
        else if (nota >= 50)
        {
            Console.WriteLine("Recuperação");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}
