using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    public class Employee
    {
        public int ID { get; set; }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.ID == emp2.ID; 
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 != emp2); 
        }
    }
}
