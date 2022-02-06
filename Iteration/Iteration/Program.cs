using System;
using System.Collections.Generic;

class Program
{
   static void Main(string[] args)
    {
        ///* we make an array of test scores and then iterate through them to print out any score higher than 85 to the console*/
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++) // this is how we iterate through the array using a for loop
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();

        //string[] names = { "Spencer", "Terran", "Erik", "Kristel", "Skyler" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    Console.WriteLine(names[j]);
        //}
        //Console.ReadLine();

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + score);
        //    }
        //}
        //Console.ReadLine();

        List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.ReadLine();

        // here we make a list of test scores and a blank list and then iterate through the testscores list to find the passing scores and then
        // save them in to the new passingScores list and then we count how many passing scores there were
        List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };

        List<int> passingScores = new List<int>();

        foreach (int score in testScores) // this is another, easier way to do for loops in C#
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }
        Console.WriteLine(passingScores.Count);
        Console.ReadLine();
    }
}

