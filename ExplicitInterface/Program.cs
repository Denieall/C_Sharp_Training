using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            Test t = new Test();
            ((Interface1)t).display();
            Console.WriteLine(((Interface2)t).display());

        }
    }

    class Test : Interface1, Interface2
    {
        void Interface1.display()
        {
            Console.WriteLine("Im interface 1.");
        }

        int Interface2.display()
        {
            return 2;
        }
    }
}
