using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Your job is to create a basic approval program for car insurance. It will ask the applicant some questions and
            //return a “true” or “false” at the end to determine whether or not the applicant qualified for car insurance.

            Console.WriteLine("What is your age?");
            string ageString = Console.ReadLine();
            Console.WriteLine("Have you had a DUI?");
            string duiString = Console.ReadLine();
            Console.WriteLine("How many speeding tickets have you had");
            string ticketsString = Console.ReadLine();
            int ageInt = Convert.ToInt32(ageString);
            bool duiBool = Convert.ToBoolean(duiString);
            int ticketsInt = Convert.ToInt32(ticketsString);
            bool insuraceApproval = (ageInt > 15 && duiBool != true && ticketsInt < 3);
            Console.WriteLine("Are you qualified?");
            Thread.Sleep(3000); //this adds three seconds but must add the "using System.Threading;" 
            Console.WriteLine(insuraceApproval); 

            Console.ReadLine(); 




        }
    }
}
