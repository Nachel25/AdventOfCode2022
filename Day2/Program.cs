using System;
using System.IO;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Class Day1
            var day2 = new Day2(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\inputFiles\inputDay02.txt"));

            // Part 1
            Console.WriteLine("\nBeginning Day 2 Part 1");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"You will make {day2.Score} points.");

            // Part 2
            Console.WriteLine("\nBeginning Day 2 Part 2");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"The adjusted score is {day2.ScoreAdjusted} points.");
        }
    }
}