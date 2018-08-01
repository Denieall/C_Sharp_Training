using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringWriter_StringReader
{
    class StringRW
    {
        private StringBuilder sb;

        public StringRW()
        {

            sb = new StringBuilder();
            Write();
            Read();

        }

        public void Write()
        {
            // Instantiate new string writer object
            StringWriter sw = new StringWriter(sb);

            Console.WriteLine("Enter your first name:");
            String fname = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            String lname = Console.ReadLine();

            // Write character to string writer
            sw.WriteLine(fname);
            sw.WriteLine();
            sw.WriteLine();
            sw.WriteLine(lname);

            // For efficiency purpose destroy the string writer object
            sw.Flush();
            sw.Close();

            

        }

        public void Read()
        {

            StringReader sr = new StringReader(sb.ToString());

            Console.WriteLine("Reading the data provided...");
            Console.WriteLine();
            Console.WriteLine();

            // As an alternative to ReadToEnd method.
            //while (sr.Peek() > -1)
            //{
            //    Console.WriteLine(sr.ReadLine());
            //}

            Console.WriteLine(sr.ReadToEnd());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Process completed !!!");

        }


    }
}
