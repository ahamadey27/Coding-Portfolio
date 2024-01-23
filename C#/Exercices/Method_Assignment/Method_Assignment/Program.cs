using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            twoInts newTwoInts = new twoInts();
            Console.WriteLine("please enter a number");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter another number");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            int result = newTwoInts.mathOperation(numberOne, numberTwo);
            Console.WriteLine(result);
            Console.Read(); 
        }
    }
}
