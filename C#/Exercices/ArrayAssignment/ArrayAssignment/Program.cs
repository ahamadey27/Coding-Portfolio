using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pizzaArray = { "nothing", "cheese", "olives", "ham", "onion" };
            Console.WriteLine("please choose 1 - 4 for pizza topping");
            int pizzaChoise = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pizzaArray[pizzaChoise]);
            Console.Read();

            //Add in a message that displays when the user selects an index that doesn’t exist.
            int[] boxSize = { 0, 20, 30, 40, 50, 60, 70 };
            Console.WriteLine("please choose 1-6 for box size");
            int boxChoice = Convert.ToInt32(Console.ReadLine());
            if (boxChoice <= 6)
                Console.WriteLine("This is you box size: " + boxSize[boxChoice]);
            else
                Console.WriteLine("Youre box is too big");
            Console.Read();
        }
    }
}
