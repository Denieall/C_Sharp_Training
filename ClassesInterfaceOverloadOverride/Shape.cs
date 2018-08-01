using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInterfaceOverloadOverride
{
    class Shape : IShape
    {
        public Shape(String d, String c)
        {
            Desc = d;
            Color = c;
        }

        private string desc = null;

        public string Desc { get; set; }

        private string color = null;

        public string Color { get; set; }

        public void displayColor()
        {
            Console.WriteLine(color);
        }

        // Adding in the "virtual" keyword tells the compiler that this method is allowed to be override
        public virtual void displayShape()
        {
            Console.WriteLine("Shape class: " + desc);
        }

        public static void displayMessage()
        {
            Console.WriteLine("Hi, there !!!");
            Console.WriteLine("Please enter in the shape, color, height and width in that order...");
        }
    }
}
