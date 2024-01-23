using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums_Assignment
{
    public class Program
    {

        public enum WeekDays //must be new/outside of main method body 
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday, 
            Friday,
            Saturday,
            Sunday
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("PLease enter the day of the week");
            string userInput = Console.ReadLine();

            try
            {
                // Parsing the input to the enum
                WeekDays currentDay = (WeekDays)Enum.Parse(typeof(WeekDays), userInput, true);
                Console.WriteLine($"Current day is: {currentDay}");
            }
            catch (Exception)
            {
                // Error handling
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.Read(); 

        }
    }
}
