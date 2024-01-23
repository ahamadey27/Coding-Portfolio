using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            intClass newIntClass = new intClass();
            Console.WriteLine("Enter a number");
         
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                newIntClass.MathMethod(userInput, out int result);

                Console.WriteLine("Half of " + userInput + " is " + result);
            }

            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid integer.");
            }

            Console.Read(); 
        }
    }
}
