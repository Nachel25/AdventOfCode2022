using System;
using System.IO;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            var day4 = new Day4(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\inputFiles\input.txt"));

            // Part 1
            Console.WriteLine($"\nBeginning {nameof(day4)} Part 1");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"{nameof(day4)} part 1: {day4.Day4Part1}.");

            // Part 2
            Console.WriteLine($"\nBeginning {nameof(day4)} Part 2");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"{nameof(day4)} part 2: {day4.Day4Part2}.");
        }
    }
}