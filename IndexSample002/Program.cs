using System;

namespace IndexSample002
{
    class Program
    {
        private static string[] _array;
        static void Main(string[] args)
        {
            _array = new string[] { "A", "B", "C", "D", "E" };
            Console.WriteLine(GetString(^0)); // this will cause IndexOutOfRangeException
            Console.ReadLine();
        }
        static string GetString(Index index)
        {
            return _array[index];
        }
    }
}
