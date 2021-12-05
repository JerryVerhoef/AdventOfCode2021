using System;
using System.IO;

namespace AdventCode3
{
    class Program
    {
        const string InputFile = @"..\\..\\..\\..\\Data\\adventcode3.txt";
        static void Main(string[] args)
        {
            Console
                .WriteLine("AdventCode3");
            var d = new DataFile(File.ReadAllLines(InputFile));
            
            Console.WriteLine($"Part1: {d.GetEpsilonResult() * d.GetGammaResult()}");
            Console.WriteLine($"Part2: {d.GetOxygen() * d.GetScrubber()}");
        }
    }
}