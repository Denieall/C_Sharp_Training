using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_and_StringWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Normal String concatenation

            // This is slow and inefficient when doing this over thousands of times because
            // it drops the s1 object and recreate the object again

            String s1 = "Denieall";
            s1 = s1 + " Joenethen";

            //String Builder Class --- faster and efficient
            // This will perform string operation using buffer wihout dropping or recreating any objects.

            StringBuilder sb = new StringBuilder("Denieall");
            sb.Append(" Joenethen");

            sb.AppendLine();
            sb.AppendLine();

            sb.Append(@"I'm 21 years old.");

            sb.Replace("21", "23");

            Console.WriteLine(sb);
            
        }
    }
}
