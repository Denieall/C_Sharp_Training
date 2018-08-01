using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInterfaceOverloadOverride
{
    // Always inherit base class first before interfaces
    class Square : Shape, IOperation
    {
        private int height, width;

        public Square(String desc, String color, int h, int w) : base(desc, color)
        {
            height = h;
            width = w;
        }

        public double calcArea()
        {
            return height * width;
        }

        public override void displayShape()
        {
            Console.WriteLine("This is from Square class: " + base.Desc);
        }
    }
}
