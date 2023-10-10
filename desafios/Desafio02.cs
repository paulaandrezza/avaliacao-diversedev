using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

class Desafio02 : Desafio
{
    public override void Execute()
    {
        int n1 = 0,
            n2 = 0,
            multiplicacao = 0,
            divisao = 0;
        bool validChoice = false,
            negativo = false;
        try
        {
            while (!validChoice)
            {
                Console.Write("\nDigite o 1° numero: ");
                if (int.TryParse(Console.ReadLine(), out n1))
                {
                    validChoice = true;
                }
                else
                {
                    Console.Error.WriteLine("Opção inválida. Insira um número inteiro válido.");
                }
            }
            validChoice = false;

            while (!validChoice)
            {
                Console.Write("\nDigite o 2° numero: ");
                if (int.TryParse(Console.ReadLine(), out n2))
                {
                    if (n2 == 0)
                    {
                        Console.Error.WriteLine("Erro: Impossível dividir por zero.");
                    }
                    else
                    {
                        validChoice = true;
                    }
                }
                else
                {
                    Console.Error.WriteLine("Opção inválida. Insira um número inteiro válido.");
                }
            }

            if (n1 < 0 && n2 > 0 || n1 > 0 && n2 < 0)
            {
                negativo = true;
            }

            n1 = Math.Abs(n1);
            n2 = Math.Abs(n2);

            for (int i = 0; i < n2; i++)
            {
                multiplicacao += n1;
            }

            while (n1 >= n2)
            {
                n1 -= n2;
                divisao++;
            }

            if (negativo)
            {
                multiplicacao = multiplicacao * -1;
                divisao = divisao * -1;
            }

            Console.WriteLine($"\nValor da multiplicacao: {multiplicacao}");
            Console.WriteLine($"Valor da divisao: {divisao}");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }
}
