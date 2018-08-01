using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {

            Addition a;
            a.x = 1;
            a.y = 2;
            a.Add();

            Division d = new Division(15, 3);
            d.Divide();

        }
    }

    // Structs are 99% same as class but they are value type.
    // Class is reference type that stores a pointer in the stack which points to the data in the heap.
    // Struct are light and easy on resources but does not accept a default constructor and property cannot be initialized

    struct Addition
    {
        public int x, y;

        public void Add()
        {
            Console.WriteLine(x + y);
        }
    }

    struct Division
    {
        public int j;
        public int k;

        public Division(int a, int b)
        {
            j = a;
            k = b;
        }

        public void Divide()
        {
            Console.WriteLine(j / k);
        }
    }
}
