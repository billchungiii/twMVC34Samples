using System;
using System.Collections;
using System.Collections.Generic;

namespace IndexSample001
{
    class Program
    {
        private static string[] _array;       
        static void Main(string[] args)
        {
            _array = new string[] { "A", "B", "C", "D", "E" };          
            Index index1 = new Index(1, false);
            Index index2 = new Index(1, true);
            Index index3 = 2;
            Index index4 = ^2;

            Console.WriteLine(GetString(index1));
            Console.WriteLine(GetString(index2));
            Console.WriteLine(GetString(index3));
            Console.WriteLine(GetString(index4));

            Console.ReadLine();
        }
        static string GetString(Index index)
        {
            return _array[index];
        }        
    }
}
