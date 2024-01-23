using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
namespace CallingMethods_Assignment
{
    public class MathClass //make this public 
    {
        public int Square(int number)
        {
            return number * number;
        }

        public int AddTen(int number)
        {
            return number + 10;
        }

        public int SubtractOne(int number)
        {
            return number - 1;
        }
    }
}
