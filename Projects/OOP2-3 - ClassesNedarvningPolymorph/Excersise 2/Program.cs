using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SuchDoge doge = new SuchDoge();
            doge.Name = "Doge";
            Person lis = new Person("Lis Larsen", new DateTime(1961, 11, 29));
            lis.AddPet(doge);
   
            Person per = new Person("Per Larsen", new DateTime(day: 10, month: 9, year: 1958),
                Person.Sex.Male, 1.85, 95, lis);
            lis.Weight = 60;
            lis.Height = 1.7;
            Console.WriteLine(per);
            Console.WriteLine(lis);
            lis.WalkThePets();
            lis.PetTalk();
            Console.ReadLine();
        }
   }
}
