using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAndField
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            p.Age = 50;

            Console.WriteLine("p objects's age is: " + p.Age);

        }
    }
}
