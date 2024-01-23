using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //This will output each array concatenated with the writeline
            string[] foodArray = { "chicken", "beef", "salami", "ham", "beer" };
            Console.WriteLine("what are you having for dinner?");
            string userInput = Console.ReadLine();
            for (int n = 0; n < foodArray.Length; ++n)
            {
                Console.WriteLine(foodArray[n] + " This is what I'm having for dinner");
            }


            an infinite loop(fixed)


                while (true)
                {
                    Console.WriteLine("enter text forever or exit");
                    string userText = Console.ReadLine();

                    if (userText == "exit")
                    {
                        break;
                    }

                    Console.WriteLine("we are done here");
                }


            //A loop where the comparison that’s used to determine whether to continue iterating the loop is a  “<” operator.
            Console.WriteLine("Guess a number");
            int userGuess = Convert.ToInt32(Console.ReadLine());
            bool correctNum = userGuess < 10;

            if (correctNum == true)
            {
                Console.WriteLine("corrrect!");
            }
            else
            {
                Console.WriteLine("keep guessing");
            }



            //Guessing a inex in a list
            List<string> baconOrder = new List<string>() { "oink", "chop", "sizzle", "grind" };
            bool matchFound = false;

            while (!matchFound)
            {
                Console.WriteLine("What's the four step process to shaking the bacon?");
                string userInput = Console.ReadLine();

                for (int i = 0; i < baconOrder.Count; i++)
                {
                    if (baconOrder[i] == userInput)
                    {
                        j
                        Console.WriteLine("This is step" + (i + 1) + " in the bacon order");
                        matchFound = true;
                        break;
                    }
                    if (!matchFound)
                    {
                        Console.WriteLine("Keep on sailing");
                    }

                }
            }
        }
    }
}
