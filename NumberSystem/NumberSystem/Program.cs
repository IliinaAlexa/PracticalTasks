using System;

namespace NumberSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 2)
                {
                    DecimalToOtherBaseConverter convertor = new DecimalToOtherBaseConverter();
                    int number, system;
                    number = Convert.ToInt32(args[0]);
                    system = Convert.ToInt32(args[1]);
                    string res = convertor.Convert(number, system);
                    Console.WriteLine("Decimal number {0} in base {1} is {2}",number, system, res);
                }
                else
                {
                    Console.WriteLine("Error arguments number");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong argument type");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Argument out of range");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("System base more then allowed");
            }

        }
    }
}
