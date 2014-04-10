using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            List<string> groupList = new List<string>{ "Jeppe", "Jacob", "Thure", "Ahmed" };
            for (i = 0; i < groupList.Count; i++)
            {
                Console.Write("{0} ", groupList[i]);
            }

            Console.Write("\n");
            groupList.Add("Børge");

            for (i = 0; i < groupList.Count; i++)
            {
                Console.Write("{0} ", groupList[i]);
            }
            Console.Write("\n");

            groupList.Remove("Ahmed");

            for (i = 0; i < groupList.Count; i++)
            {
                Console.Write("{0} ", groupList[i]);
            }
            Console.Write("\n");
        }
    }
}
