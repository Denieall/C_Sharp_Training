using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAndField
{
    class Person
    {
        private int age; // This is a field

        // public int Age { get; set; } Shorthand version without any conditions


        // This is a property
        // Property is like getter and setter for fields
        // Fields starts with a lowercase letter
        // Property starts with an uppercase letter

        public int Age 
        {
            get { return age; }
            set {

                if ((value > 0) && (value < 70))
                {

                    age = value;

                } else
                {

                    throw new Exception("Age must be more than 0 and less than 70");

                }
                
            }
        }

    }
}
