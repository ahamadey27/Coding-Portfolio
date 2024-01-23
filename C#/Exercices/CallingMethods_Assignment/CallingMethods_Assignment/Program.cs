using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a class. In that class, create three methods,
//each of which will take one integer parameter in and return an integer.
//The methods should do some math operation on the received parameter.
//Put this class in a separate .cs file in the application.

//2. In the Main() program, ask the user what number they want to do the math operations on.

//3. Call each method in turn, passing the user input to the method. Display the returned integer to the screen.

namespace CallingMethods_Assignment
{
    class Program
    {
        static void Main()
        {
            MathClass mathOperations = new MathClass(); //must create a new instance of MathClass from the oter .cs class


            Console.WriteLine("What number would you like to do a math opeaton on?");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"First method of {userInput} is {mathOperations.Square(userInput)}");
            Console.WriteLine($"Second method of {userInput} is {mathOperations.AddTen(userInput)}");
            Console.WriteLine($"Third method of {userInput} is {mathOperations.SubtractOne(userInput)}");

            Console.Read(); 
        }
    }
}
