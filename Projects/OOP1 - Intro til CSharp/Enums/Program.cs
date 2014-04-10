using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        enum PlayState {Play = 3, Stop, Pause, Record};
        static void Main(string[] args)
        {
            Console.WriteLine("{0} - {1} - {2} - {3}", (int)PlayState.Play, PlayState.Stop, (int)PlayState.Pause, PlayState.Record);
        }
    }
}
