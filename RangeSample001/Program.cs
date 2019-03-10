using System;

namespace RangeSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            //Range r1 = Range.Create(1, ^1);
            //Range r2 = Range.FromStart(1);
            //Range r3 = Range.ToEnd(3);
            //Range all = Range.All(); 

            // after preview 3
            Range r1 = new Range(1, ^1);
            Range r2 = Range.StartAt(1);
            Range r3 = Range.EndAt(3);
            Range all = Range.All;

            Display(r1);
            Display(r2);
            Display(r3);
            Display(all);
            Console.ReadLine();
        }

        static void Display(Range range)
        {
            Console.WriteLine(range);
        }
    }
}
