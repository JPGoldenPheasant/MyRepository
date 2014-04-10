using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_random
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int i;
            Random r = new Random(); 
    
            for (i = 0; i < 10; i++)
            {
                array[i] = r.Next(1, 43);
            }
            i = 0;
            while (i < 10)
            {
                Console.WriteLine(array[i]);
                i++;
            }
        }

    }
}
