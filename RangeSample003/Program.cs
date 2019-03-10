using System;
using System.Collections.Generic;
using System.Linq;

namespace RangeSample003
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new string[] { "A", "B", "C", "D", "E", "F", "G" };
            var ranges = new List<ValueTuple<int, int>>
            {
               (0, array.Length),
               (0, array.Length),
               (1, 2),
               (1, array.Length -2),
               (1, array.Length -1),
               (0, array.Length -2)

            };

            foreach (var range in ranges)
            {
                foreach (var s in array.Skip(range.Item1).Take(range.Item2))
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
