using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerToWordForamConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a Number to convert into word format");
                ConvertNmberInWordFormat(' ');
            }
            catch (Exception ex)
            {
                Console.WriteLine("Number is not valid " + ex.Message);
            }
        }

        private static void ConvertNmberInWordFormat(char keyValue)
        {
            string number= Console.ReadLine();
            string wortForamtedValue = (keyValue + number).Trim().ToWordFormt();
            Console.WriteLine(wortForamtedValue + "\n");
            Console.WriteLine("Enter another number to convert into word format or Press escape to exit");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            ConvertNmberInWordFormat(key.KeyChar);
        }
    }
}
