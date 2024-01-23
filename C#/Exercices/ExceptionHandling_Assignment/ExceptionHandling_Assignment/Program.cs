using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<int> numberList = new List<int>() { 20, 7, 50, 80, 2, 6, 10, 12 };
            Console.WriteLine("Enter a number that we will divide a list by");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            foreach (int numberCycle in numberList) //how to cycle through a list
            {
                Console.WriteLine(numberCycle / userNumber);
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Do not enter a zero");
            return;
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        finally
        {
            Console.ReadLine(); 
        }


        Console.Read();
    }
    
}

