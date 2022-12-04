using System;
using System.IO;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            var day3 = new Day3(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\inputFiles\input.txt"));

            // Part 1
            Console.WriteLine($"\nBeginning {nameof(Day3)} Part 1");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Priority sum part 1: {day3.PrioritySumPart1}.");

            // Part 2
            Console.WriteLine($"\nBeginning {nameof(Day3)} Part 2");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Priority sum part 2: {day3.PrioritySumPart2}.");
        }
    }
}