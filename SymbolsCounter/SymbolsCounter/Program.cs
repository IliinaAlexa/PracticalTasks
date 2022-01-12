using System;

namespace SymbolsCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                int res = DifferentSymbolsCounter.MaxDifferentSymbols(args[0]);
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Error");
            }
           
            
        }
    }
}
