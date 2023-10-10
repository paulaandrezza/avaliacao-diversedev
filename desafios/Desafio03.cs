using System;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

class Desafio03 : Desafio
{
    public override void Execute()
    {
        string frase = "";
        int maiusculas = 0,
            minusculas = 0,
            iniMaiuscula = 0,
            iniMinuscula = 0;
        bool todasMaiusculas = true,
            todasMinusculas = true;

        try
        {
            Console.Write("Insira uma frase: ");
            frase = Console.ReadLine();
            string[] palavras = Regex.Split(frase, @"\s+|\t+");

            foreach (string palavra in palavras)
            {
                Console.WriteLine(palavra);

                if (Char.IsUpper(palavra[0]))
                    iniMaiuscula++;
                else
                    iniMinuscula++;

                foreach (char letra in palavra)
                {
                    if (Char.IsUpper(letra))
                        todasMinusculas = false;
                    if (Char.IsLower(letra))
                        todasMaiusculas = false;
                }

                if (todasMaiusculas)
                    maiusculas++;
                else if (todasMinusculas)
                    minusculas++;

                todasMaiusculas = true;
                todasMinusculas = true;
            }

            Console.WriteLine($"\nQuantidade de palavras maiusculas: {maiusculas}");
            Console.WriteLine($"Quantidade de palavras minusculas: {minusculas}");
            Console.WriteLine($"Quantidade de palavras que iniciam em maiuscula: {iniMaiuscula}");
            Console.WriteLine($"Quantidade de palavras que iniciam em minuscula: {iniMinuscula}");
            Console.WriteLine($"Quantidade de palavras: {palavras.Length}");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }
}
