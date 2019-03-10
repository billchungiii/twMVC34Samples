using System;
using System.Collections.Generic;

namespace RangeSample002
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new string[] { "A", "B", "C", "D", "E", "F", "G" };
            var ranges = new List<Range>
            {
                {..},
                {0..^0},
                {1..3 },
                {1..^1},
                {1.. },
                {..^2},
            };

            foreach (var range in ranges)
            {
                foreach (var s in array[range])
                {
                    Console.Write(s);
                }
                Console.WriteLine(); 
            }
            Console.ReadLine(); 
        }
    }

   
}
