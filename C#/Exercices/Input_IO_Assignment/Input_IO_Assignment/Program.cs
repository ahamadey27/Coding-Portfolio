using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace Input_IO_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //for a string
            Console.WriteLine("Please enter a number.");
            string userInput = Console.ReadLine();
            File.WriteAllText(@"C:\\Users\\hamad\\Documents\\\GitHub\\CSharpAndUnity\\Text_Logging_Examples\\log.txt", userInput);
            Console.WriteLine("Here is your number " + userInput);
            Console.Read();

            //for an int
            Console.WriteLine("Please enter a number.");
            int userInputInt = Convert.ToInt32(Console.ReadLine());
            File.WriteAllText(@"C:\\Users\\hamad\\Documents\\\GitHub\\CSharpAndUnity\\Text_Logging_Examples\\log.txt", userInputInt.ToString());
            Console.WriteLine("Here is your number " + userInputInt);
            Console.Read(); 

        }
    }
}
