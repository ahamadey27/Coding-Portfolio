using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        ////arrays
        // ----------------------
        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 43;
        numArray[2] = 41;
        numArray[3] = 15;
        numArray[4] = 74;

        int[] numArray1 = new int[] { 4, 54, 26, 36, 53, 2342 };

        int[] numArray2 = { 4, 24, 4234, 34, 43 }; //easist way
        numArray2[0] = 1234; //how to change a slot in an array

        Console.WriteLine(numArray2[0]);

        //Lists -----------------
        //Must have using System.Collections.Generic;
        List<int> intList = new List<int>();
        intList.Add(12);
        intList.Add(15);
        intList.Add(234);

        List<string> stringList = new List<string>();
        stringList.Add("hllow");
        stringList.Add("fja");
        stringList.Add("alf");

        Console.WriteLine(stringList[2]);
        Console.Read(); 
    }
}

