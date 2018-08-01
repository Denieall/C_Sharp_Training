using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    class Program
    {
        // Something like constants
        enum workingDays { Monday = 5, Tuesday = 10, Wednesday = 15, Thursday = 20, Friday = 25 };

        static void Main(string[] args)
        {

            Console.WriteLine("Test enumeration: " + workingDays.Friday);

            Console.WriteLine("Test enumeration: " + workingDays.Monday);

            Console.WriteLine("Test enumeration: " + (int) workingDays.Friday);

        }
    }
}
