using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndMulticastDelegates
{
    class Program
    {
        // Creating a delegate class with method signature: return type and arguments
        delegate void process1(int x, int y);

        static void Main(string[] args)
        {
            Test t = new Test();

            // Creating delegate type: p
            process1 p;

            // Pointing method Add to p
            p = t.Add;

            // Calling the function with delegate
            Console.WriteLine("Single cast delegate: ");
            p(10, 2);

            Console.WriteLine("\n");

            // Multicast delegate -- combining multiple function into one delegate
            p = t.Add;
            p = p + t.Divide;
            p = p + t.Multiply;
            p = p + t.Substract;

            Console.WriteLine("Multicast delegate: ");
            p(15, 3);
        }
    }

    class Test
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public void Substract(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        public void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        public void Divide(int x, int y)
        {
            Console.WriteLine(x / y);
        }
    }
}
