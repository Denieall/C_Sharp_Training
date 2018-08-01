using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "This is a string";

            // Calling extension method
            s.print();

            // Calling static method
            extendTestClass.display(s);
            
        }
    }

    // Extension Method - Class and Method must be static
    // Used when there is a need to extend a class's functionality without disturbing that class
    static class extendTestClass
    {
        public static void print(this string i)
        {
            Console.WriteLine(i);
        }

        public static void display(string i)
        {
            Console.WriteLine("This is display method: {0}", i);
        }
    }
}
