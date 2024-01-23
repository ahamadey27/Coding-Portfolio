using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fav number?");
            int favNumber = Convert.ToInt32(Console.ReadLine());
            string result = favNumber == 12 ? "you have great number" : "you don't have nice number";
            Console.WriteLine(result); 



            //int roomTemp = 70;

            //Console.WriteLine("What is your name?"); 
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temp where you at?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine()); 

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("its exactly room temp");
            //}

            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("Its warmer than room temp"); 
            //}
            //else if(roomTemp > currentTemp)
            //{
            //    Console.WriteLine("Its colder than room temp");
            //}
            //else
            //{
            //    Console.WriteLine("no dice"); 
            //}


             
            //int currentTemp = 70;
            //int roomTemp = 70;
            ////left side of the colon assigned to result if true, right side of colon assigned if false
            //string compResult = currentTemp == roomTemp ? "It is room temp" : "its not room temp";
            //Console.WriteLine(compResult);


            //if(currentTemp == roomTemp)
            //{
            //    Console.WriteLine("Its room temp");
            //}
            //else if(currentTemp > roomTemp)
            //{
            //    Console.WriteLine("warmer than room temp"); 
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("room temp is warmer than current temp"); 
            //}
            //else
            //{
            //    Console.WriteLine("not room temp");
            //}
            Console.ReadLine(); 
        }
        

            
    }
}
