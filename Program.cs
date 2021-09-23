using System;

namespace MemeToNervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            String Opnião;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("O que você pensa de mim? Porque tu é Otário! ");
            Console.ResetColor();
            Opnião = Console.ReadLine();
            Opnião = Opnião.Remove(10);
            //Opnião = Opnião.PadRight(3, '.'); // - Esse comando não estava funcionando comigo
            Opnião = Opnião.Insert(10, "..."); //  - Então dei um jeito 😉
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("- E sabe o que penso de você?");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine($"{Opnião} NÃO PERA.\nTô nervoso"); 
            Console.WriteLine();
        }
    }
}
