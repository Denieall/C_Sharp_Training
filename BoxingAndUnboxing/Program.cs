using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unboxing and boxing takes alot of system resources. It's best to avoid it.

            int i = 45;
            object o = i; // Unboxing is happening here. Implicitly convert int to object

            Console.WriteLine(o);
            Console.WriteLine(i);

            int x;
            x = (int)o; // Object needs to be cast to int

            Console.WriteLine(x);
            
            
            // A list objects
            List<Object> l = new List<Object>();

            l.Add("Hello");
            l.Add(123456);

            foreach (Object j in l)
            {
                Console.WriteLine(j);
            }


        }
    }
}
