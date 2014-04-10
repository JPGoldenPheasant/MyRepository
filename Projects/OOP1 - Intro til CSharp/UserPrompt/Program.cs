using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPrompt
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, fullName;
            Console.WriteLine("Please enter your first name: ");
            firstName = Console.ReadLine();
            lastName = Console.ReadLine();
            fullName = firstName + " " + lastName;
            Console.WriteLine("Hello {0}!", fullName);
        }
    }
}
