using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Pick a number");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            Console.Read();
        }
        catch (FormatException ex)
        {
           
            Console.WriteLine("Please type a whole number"); //custom message 
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("don't divide by zero"); 
        }
        
        
        catch (Exception ex) //this is for the general exception
        {
            Console.WriteLine(ex.Message);  //C#'s standard message 
        }
        finally
        {
            Console.ReadLine(); 
        }
        Console.ReadLine();
    }
}

