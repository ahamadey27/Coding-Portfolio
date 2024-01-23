using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] testScores = { 98, 99, 85, 70, 82, 34, 54, 89, 79, 88 };

        //starts at index 0, length of for loop goes length of array, add one to i for each for loop
        for (int i = 0; i < testScores.Length; i++)
        {
            if (testScores[i] > 85)
            {
                Console.WriteLine("Passing test score: " + testScores[i]);
            }
        }

        string[] names = { "hammer", "Tom", "Bill", "Sam", "Ryan" };
        for (int n = 0; n < names.Length; ++n)
        {
            if (names[n] == "Sam")
            {
                Console.WriteLine(names[n]);
            }
        }

        List<int> testScores = new List<int>();
        testScores.Add(98);
        testScores.Add(99);
        testScores.Add(72);
        testScores.Add(90);
        testScores.Add(85);
        testScores.Add(80);

        foreach (int score in testScores) //how to iterate a list
        {
            if (score > 85)
            {
                Console.WriteLine("Passing test Score: " + score);
            }
        }

        //easier way to add elemtnts into a list
        List<string> names = new List<string>() { "hammer", "Tom", "Bill", "Sam", "Ryan" };

        foreach (string name /*this is a new variable*/ in names)
        {
            if (name == "Tom")
            {
                Console.WriteLine(name);
            }
        }

        //This shows number of scores in list passed 
        List<int> testScores = new List<int>() { 98, 99, 85, 70, 82, 34, 54, 89, 79, 88 };
        List<int> passingScores = new List<int>(); 
        
        foreach (int testInt in testScores)
        {
            if(testInt > 85)
            {
                passingScores.Add(testInt);
            }
        }
        Console.WriteLine(passingScores.Count); //scores is same as an Array's varable.Length but for lists
        Console.ReadLine(); 
    }
}

