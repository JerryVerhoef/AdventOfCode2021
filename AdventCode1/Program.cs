using System;

namespace AdventCode1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SubMarine subMarine = new SubMarine();
            var d = subMarine.DepthFile("E:\\Development\\AdventOfCode\\ConsoleApp1\\AdventCode1\\adventcode1.txt");
            Console.WriteLine(d.GetAmountOfIncreases());
            Console.WriteLine("Hello World!");
        }
    }
}