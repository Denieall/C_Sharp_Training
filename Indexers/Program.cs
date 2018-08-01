using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();

            // c here will directly call the indexer --- brand
            c["brand", 0] = "Toyota";
            c["brand", 1] = "Honda";
            c["brand", 2] = "Proton";

            for (int x = 0; x < c.brandLength(); x++)
            {
                Console.WriteLine(c["brand", x]);
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            // c here will directly call the indexer --- horse power
            c["hp", 0] = "400";
            c["hp", 1] = "465";
            c["hp", 2] = "700";

            for (int x = 0; x < c.horsepowerlength(); x++)
            {
                Console.WriteLine(c["hp", x]);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }

    class Car
    {
        private string[] brand = new string[10];

        public int brandLength()
        {
            return this.brand.Length;
        }



        private string[] horsepower = new string[3];

        public int horsepowerlength()
        {
            return this.horsepower.Length;
        }

        // This is an indexer
        public String this[String s, int i]

        {
            get
            {
                if (s == "hp")
                {
                    if (i < horsepower.Length)
                    {
                        return horsepower[i];
                    }
                }
                else if (s == "brand")
                {
                    if (i < brand.Length)
                    {
                        return brand[i];
                    }
                }
                

                return "Index limit exceeded";
            }

            set
            {
                if (s == "hp")
                {
                    if (i < horsepower.Length)
                    {
                        horsepower[i] = value;
                    }
                }
                else if (s == "brand")
                {
                    if (i < brand.Length)
                    {
                        brand[i] = value;
                    }
                }


            }
        }

    }
}
