using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRANCHING_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter package weight");
            string packageWeight = Console.ReadLine();
            int intWeight = Convert.ToInt32(packageWeight);
            int packageMaxWeight = 50;
            string packageAapproval = packageMaxWeight > intWeight ? "Please enter package height" : "Package too heavy to be shipped via Package Express. Have a good day.";
            Console.WriteLine(packageAapproval);
            string packageHeight = Console.ReadLine();
            int intHeight = Convert.ToInt32(packageHeight);
            Console.WriteLine("Please enter packaage length.");
            string packageLength = Console.ReadLine();
            int intLength = Convert.ToInt32(packageLength);
            Console.WriteLine("Please enter packaage Width.");
            string packageWidth = Console.ReadLine();
            int intWidth = Convert.ToInt32(packageWidth);
            int maxLength = 50;
            int maxHeight = 50;
            int maxWidth = 50;
            double estimate = intHeight * intLength * intWidth * intWeight / 100; 
            if (maxLength > intLength && maxHeight > intHeight && maxWidth > intWidth)
            {
                Console.WriteLine("Your estimated total for shipping this package is: " + estimate + "\nThanks You!!"); 
            }
            else
            {
                Console.WriteLine("Sorry to big!"); 
            }
            Console.ReadLine(); 



        }
    }
}
