using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Preço do produto (use ponto como separador): ");
        if (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double preco))
        {
            Console.WriteLine("Entrada inválida. Use formato numérico com ponto.");
            return;
        }
        Console.Write("Quantidade comprada: ");
        if (!int.TryParse(Console.ReadLine(), out int quantidade))
        {
            Console.WriteLine("Entrada inválida. Por favor digite um inteiro.");
            return;
        }
        double total = preco * quantidade;
        Console.WriteLine($"Valor total: R$ {total:F2}");
    }
}
