using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethods_Assignment
{
    class MathOperation
    {
        //method 1
        public int perfromOperation(int number)
        {
            return number + 20;
        }

        //method 2
        public int perfromOperation(decimal number)
        {
            return (int)(number * 10);
        }

        //methods 3
        public int perfromOperation(string number)
        {
            
            return int.TryParse(number, out int parsedNumber) ? parsedNumber / 2 : throw new ArgumentException("Input must be a number.");
            

        }

    }
}
