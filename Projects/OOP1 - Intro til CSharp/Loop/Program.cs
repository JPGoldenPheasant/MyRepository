using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < i; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            for (i = 0; i < 6; i++)
            {
                for (j = 6; j > i; j--)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
