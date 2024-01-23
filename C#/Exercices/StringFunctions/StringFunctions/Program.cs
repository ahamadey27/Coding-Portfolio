using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name= "Jesse";
            //string fileName = "c:\\user\\hammer\\files";
            //string fileName2 = @"c:\user\hammer\files"; //@ applies espace sequence to whole string
            //string quote = "The man said \"Hello, Jesse\"";

            //bool trueOrFalse = name.Contains("s");
            //bool trueOrFalse2 = name.EndsWith("s");

            //name = name.ToUpper(); 

            //int length = name.Length;

            //StringBuilder sb = new StringBuilder();
            //sb.Append("My name is hammer");

            StringBuilder sb = new StringBuilder();
            string s1 = "what is going on ";
            string s2 = "my name is hammer.";
            string s3 = " Would you want to chill?";
            s3 = s3.ToUpper();
            //string mainConcat = s1 + s2 + s3;
            sb.Append(s1);
            sb.Append(s2);
            sb.Append(s3);


            Console.WriteLine(sb);
            Console.Read();
        }
    }
}
