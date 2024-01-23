using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation newMathOperation = new MathOperation();

            //method 1
            int result1 = newMathOperation.perfromOperation(20);
            Console.WriteLine(result1);

            //method 2
            int result2 = newMathOperation.perfromOperation(30.5m);
            Console.WriteLine(result2);

            //method 3
            int result3 = newMathOperation.perfromOperation("50");
            Console.WriteLine(result3);

            Console.Read(); 
        }
    }
}
