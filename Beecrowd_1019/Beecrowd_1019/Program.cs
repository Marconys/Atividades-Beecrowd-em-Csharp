using System;

namespace Beecrowd_1019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seg = int.Parse(Console.ReadLine());

            Console.WriteLine($"{seg /3600}:{(seg%3600)/60}:{seg%60}");

            Console.ReadKey();
        }
    }
}
