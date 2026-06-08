using System;

class Program
{
    static void Main()
    {
        Console.Write("Idade: ");
        if (!int.TryParse(Console.ReadLine(), out int idade))
        {
            Console.WriteLine("Por favor, digite uma idade válida.");
            return;
        }
        if (idade >= 18)
            Console.WriteLine("Maior de idade");
        else
            Console.WriteLine("Menor de idade");
    }
}
