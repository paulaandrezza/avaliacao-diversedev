using System;
using System.Runtime.Intrinsics.X86;

// Considerei o 0 como positivo

class Desafio01 : Desafio
{
    public override void Execute()
    {
        int[] numbers = new int[5];
        int pares = 0,
            positivos = 0;

        bool validChoice = false;
        try
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                while (!validChoice)
                {
                    Console.Write($"\nDigite o {i + 1}° numero: ");
                    if (int.TryParse(Console.ReadLine(), out numbers[i]))
                    {
                        if (numbers[i] % 2 == 0)
                            pares += 1;
                        if (numbers[i] >= 0)
                            positivos += 1;
                        validChoice = true;
                    }
                    else
                    {
                        Console.Error.WriteLine("Opção inválida. Insira um número inteiro válido.");
                    }
                }
                validChoice = false;
            }

            Console.WriteLine($"\nValores pares: {pares}");
            Console.WriteLine($"Valores impares: {5 - pares}");
            Console.WriteLine($"Valores positivos: {positivos}");
            Console.WriteLine($"Valores negativos: {5 - positivos}");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }
}
