using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paramaters_Assignment
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var employeeWithString = new Employee<string>  // Instantiate an Employee object with type “string” as its generic parameter. Assign a list of strings as the property value of Things.
            {
                things = new List<string> { "Desk", "Computer", "Mouse" }
            };

            var employeeWithInt = new Employee<int> //Instantiate an Employee object with type “int” as its generic parameter. Assign a list of integers as the property value of Things.
            {
                things = new List<int> { 123, 143, 567 }
            };

            foreach (var Thing in employeeWithString.things)
            {
                Console.WriteLine(Thing); 
            }

            foreach (var Thing in employeeWithInt.things)
            {
                Console.WriteLine(Thing);
            }

            Console.Read(); 
        }
    }
}
