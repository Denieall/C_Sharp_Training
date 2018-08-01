using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Test2> maths = new List<Test2> {

                new Test2() { marks = 75 },
                new Test2() { marks = 85 }

            };

            maths[0].displayMarks();
            maths[1].displayMarks();

            // Creating new instance without using constructor
            Test2 t1 = new Test2 { marks = 90 };
            Console.WriteLine(t1.marks);

            // Another way object initializer
            List<Test2> t2 = new List<Test2>();
            t2.Add(new Test2());
            t2[0].marks = 12;
            t2[0].displayMarks();
        }

    }

    class Test2
    {
        public int marks;

        public void displayMarks()
        {
            Console.WriteLine("The test2 mark is {0}", marks);
        }
    }
}
