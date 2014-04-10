using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            double value;
            double root;
            Console.WriteLine("Please type positive number: ");
            value = double.Parse(Console.ReadLine());
            root = System.Math.Sqrt(value);
            Console.WriteLine("The square root of {0} is {1}", value, root)
;

        }
    }
}
