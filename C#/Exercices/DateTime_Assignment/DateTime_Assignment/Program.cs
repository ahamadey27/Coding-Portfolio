using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentTime);

            // Asking for a number from the user
            Console.Write("Please enter a number of hours: ");
            int hoursToAdd = Convert.ToInt32(Console.ReadLine());

            // Calculating the time it will be in X hours
            DateTime futureTime = currentTime.AddHours(hoursToAdd);
            Console.WriteLine("Time in " + hoursToAdd + " hours: " + futureTime);
            Console.Read(); 
        }
        

    }
}
