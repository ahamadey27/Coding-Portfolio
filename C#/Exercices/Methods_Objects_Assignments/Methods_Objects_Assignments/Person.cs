using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Objects_Assignments
{
    class Person
        
    {
        public string FirstName { get; set; } //accessors - these allow you to get and set the values of these properties.
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + "" + LastName); 
        }
    }
}
