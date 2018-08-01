using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInterfaceOverloadOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Square.displayMessage();
            Square s = new Square(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The area is {0}", s.calcArea());

            Console.WriteLine();
            Console.WriteLine();
            s.displayColor();
            s.displayShape();

            // Overloading
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            Class1 class1 = new Class1();
            class1.Plus();
            class1.Plus(2);
            class1.Plus(1, 2);
            class1.Plus(1, 2, 3);
        }
    }
}
