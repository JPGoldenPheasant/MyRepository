using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string initString = "the quick brown fox";
            string newString;
            newString = initString.Replace(' ', '_');
            Console.WriteLine(newString);

            string[] split = newString.Split('_');

            foreach (string s in split)
            {
                if (s.Trim() != "")
                    Console.WriteLine(s);
            }
        }
    }
}
