using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambaExpression
{
    class Program
    {
        static void Main(string[] args)
        {

            // Using delegate to create new method using lambda expression
            // Action for return type of void
            Action<String> print = s => Console.WriteLine(s);
            print("Hey");

            Func<Double> num = () => 45.5 * 2;
            Console.WriteLine(num());

            // Calling a defined function
            Action printVoid = new Test().printOut;
            printVoid();

            // Pass a lamda expression(function) as an argument
            var numList = new List<int>() { 3, 4, 5, 12, 13, 15, 16 };

            Test test1 = new Test();
            var result = test1.addToList(numListItem => { if (numListItem > 12) { return true; } return false; }, numList);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }

        
    }

    class Test
    {
        public delegate Boolean CustomFunction(int x);

        public void printOut()
        {
            Console.WriteLine("Hello");
        }

        public List<int> addToList(CustomFunction cf, List<int> i)
        {
            List<int> listmorethan12 = new List<int>();

            foreach(int x in i)
            {

                if (cf(x))
                {
                    listmorethan12.Add(x);
                }

            }

            return listmorethan12;
        }
    }
}
