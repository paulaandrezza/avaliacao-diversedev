using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

class Desafio02 : Desafio
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
