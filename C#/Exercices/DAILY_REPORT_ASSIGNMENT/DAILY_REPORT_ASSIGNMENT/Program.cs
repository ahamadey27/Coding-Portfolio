using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAILY_REPORT_ASSIGNMENT
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Tech Academy! \nStudent Daily Report.");
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page are you on?");
            string pageNumber = Console.ReadLine();
            bool yesHelp = true;
            bool noHelp = false;
            string helpYes = Convert.ToString(yesHelp);
            string helpNo = Convert.ToString(noHelp); 
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string helpAnswer = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positveExperiece = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudy = Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        


            Console.ReadLine();
        }
    }
}
