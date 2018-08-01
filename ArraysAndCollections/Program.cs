using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a collection that contains a list of strings
            List<String> brands = new List<String>();

            // Adding to collections
            brands.Add("Proton");
            brands.Add("BMW");
            brands.Add("Mazda");
            brands.Add("Honda");
            brands.Add("Toyota");

            // Display single value in collctions
            Console.WriteLine(brands[1]);

            int index = 1;

            foreach (String brand in brands)
            {
                Console.WriteLine(index + ". " + brand);

                index++;
            }

            Console.WriteLine("-----------------------------------------------------------------------------------");

            // Create an array
            int[] yearArray = new int[] { 1995, 2001, 2005, 2010, 2018 };

            // Looping array
            for (int i = 0; i < yearArray.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + yearArray[i]);
            }

            //Another way to create array
            String[] names = new String[10];
            names[0] = "dj";
            names[1] = "f3";
            names[2] = "bear";

            Console.WriteLine();
            Console.WriteLine(names[2]);


            Console.ReadLine();
        }
    }
}
