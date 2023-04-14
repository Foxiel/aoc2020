using System;
using System.IO;

namespace Day1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("./day1.txt");

            foreach (var t in input)
            {
                foreach (var t1 in input)
                {
                    foreach (var t2 in input)
                    {
                        if (int.Parse(t) + int.Parse(t1) + int.Parse(t2) != 2020) continue;
                        Console.WriteLine(int.Parse(t) * int.Parse(t1) * int.Parse(t2));
                        goto end;
                    }
                }
            }
            end:
            Console.WriteLine("Done");
        }
    }
}