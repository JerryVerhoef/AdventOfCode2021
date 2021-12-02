using System;
using System.IO;
using AdventCode2;

namespace AdventCode2
{
    class Program
    {
        const string InputFile = @"E:\\Development\\AdventOfCode\\ConsoleApp1\\Data\\adventcode2.txt";
        static void Main(string[] args)
        {
            
            var sub = new SubMarine(new DataFile(File.ReadAllLines(InputFile)).GetMoves());
            Console.WriteLine(sub.GetTravelDistance());
        }
    }
}