using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, result;

            try
            {

                a = 8;
                b = 0;

                result = a / b;

                Console.WriteLine(result);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {

                Console.WriteLine("Process done");

            }

            Console.ReadLine();

        }
    }
}
