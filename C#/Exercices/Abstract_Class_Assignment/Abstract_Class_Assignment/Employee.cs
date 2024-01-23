using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    public class Employee : Person , IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("name: " + firstName + " " + lastName);          
        }

        public void Quit()
        {
            throw new NotImplementedException(); 
        }
        
         
       
 
    }
}
