using System;

namespace IndexSample003
{
    class Program
    {
        private static string[] _array;
        static void Main(string[] args)
        {
            _array = new string[] { "門", "安", "天", "四", "六", "念", "紀" };
            var s1 = GetString(_array.Length - 1);
            var s2 = GetString(^1);  // same as (_array.length -1)
            Console.WriteLine($"{s1} : {s2}");
            Console.ReadLine();
        }
        static string GetString(Index index)
        {
            return _array[index];
        }
    }
}
