using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_Boolean_while_doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ////must be an exact number
            //Console.WriteLine("Let's see if it's freezing!\nWhat's the temperature where you are in centigrade?");
            int currentTemp = Convert.ToInt32(Console.ReadLine());
            bool isFreezing = currentTemp <= 0;

            do
            {
                switch (currentTemp)
                {     
                    case -1:
                        Console.WriteLine("It's freezing out!");
                        isFreezing = true;
                        break;

                    default:
                        Console.WriteLine("Not freezing");
                        Console.WriteLine("what is the temp?");
                        currentTemp = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isFreezing);                
            Console.Read(); 

        //Ths is for anything 0 or below
        Console.WriteLine("Let's see if it's freezing!\nWhat's the temperature where you are in centigrade?");
        int currentTemp = Convert.ToInt32(Console.ReadLine());
        bool isFreezing = currentTemp <= 0;

            do
            {
                if (currentTemp <= 0)
                {
                    Console.WriteLine("It's freezing out!");
                    isFreezing = true;
                }

                else
                {
                    Console.WriteLine("Not freezing");
                    Console.WriteLine("what is the temp?");
                    currentTemp = Convert.ToInt32(Console.ReadLine());
                    isFreezing = currentTemp <= 0;
                }
            }

            while (!isFreezing);
            Console.Read();



        }
    }
}
