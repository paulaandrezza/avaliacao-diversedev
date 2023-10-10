﻿using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

// Desafio 1: Calculadora

// Objetivo: Escrever um programa que solicite ao usuário dois números e realize operações
// simples de adição, subtração, multiplicação e divisão.

// Instruções:

// Solicite ao usuário que insira dois números.
// Realize as operações de adição, subtração, multiplicação e divisão entre esses números.
// Exiba os resultados das operações no console.

// Dica: Use variáveis para armazenar os números de entrada e os resultados intermediários.


class Desafio01 : Desafio
{
    public override void Execute()
    {
        try
        {
            Console.WriteLine("Hello World");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }
}
