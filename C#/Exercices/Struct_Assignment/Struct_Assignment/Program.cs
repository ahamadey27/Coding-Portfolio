using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    class Program
    {
        struct Number
        {
            public decimal Amount;
        }

        static void Main(string[] args)
        {
            Number myNumber;
            myNumber.Amount = 124.34m;
            Console.WriteLine("The number is :" + myNumber.Amount);
            Console.Read(); 
        }

       


    }
}
