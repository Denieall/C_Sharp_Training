using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastAndConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion = Done by the compiler in the background when its sure that no data loss might occur.
            // Explicit Conversion = Tells the compiler to cast or convert a variable while understanding the risks assosiated.

            // Casting Example
            Int64 num = 1234;
            Int32 bigNum = (Int32)num;
            Console.WriteLine(bigNum);

            // Convert Example --- More suitable for string
            int x = 1995;
            String year = Convert.ToString(x);
            Console.WriteLine(year);

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
