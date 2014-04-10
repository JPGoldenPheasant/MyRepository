using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseAndTryParse
{
    class Program
    {
        public static void Main(string[] args)
        {
            Parsing.Parse();
            Parsing.TryToParse();


        }
    }
    class Parsing
    {
        public static void Parse()
        {
            int value;

            Console.WriteLine("Please enter an integer: ");
            try
            {
                value = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("That was not an integer");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unkown exception, {0}", ex.Message);
            }
            finally {
                Console.WriteLine("Goodbye");
            }
        }
        public static void TryToParse()
        {
            int value;

            Console.WriteLine("Please enter an integer: ");
            int.TryParse(Console.ReadLine(), out value);
        }
    }
}
