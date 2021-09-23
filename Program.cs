using System;

namespace MemeToNervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            String Opnião;
            Console.WriteLine();
            Console.Write("O que você pensa de mim? Porque tu é Otário! ");
            Opnião = Console.ReadLine();
            Opnião = Opnião.Remove(10);
            Opnião = Opnião.PadLeft(4, '.');
            Console.WriteLine();
            Console.WriteLine("- E sabe o que penso de você?");
            Console.WriteLine();
            Console.WriteLine($"{Opnião}NÃO PERA.\nTô nervoso");
            Console.WriteLine();
        }
    }
}
