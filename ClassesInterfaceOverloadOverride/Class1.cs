using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInterfaceOverloadOverride
{
    class Class1
    {
        // Overloading only works on different argument types and combinations

        public void Plus()
        {
            Console.WriteLine("1");
        }

        public void Plus(int i)
        {
            Console.WriteLine(i);
        }

        public void Plus(int i, int j)
        {
            Console.WriteLine(i + j);
        }

        public void Plus(int i, int j, int k)
        {
            Console.WriteLine(i + j + k);
        }
    }
}
