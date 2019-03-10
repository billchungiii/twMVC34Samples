using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace UsingScopeSample
{
    class Program
    {
        static void Main(string[] args)
        {

            Exec();
            Console.WriteLine("========= Main Completed!");

        }

        static void Exec()
        {
            using var obj = new MyClass();
            for (int i = 0; i < 10; i++)
            {
                obj.DoSomething();
            }

            int p = 9;
            int j = 9;
            int k = p + j;
            Console.WriteLine(k);

          
        }

        static void Save(IEnumerable<string> lines)
        {
            using ( var file = new System.IO.StreamWriter("file1.txt"))
            foreach (string line in lines)
            {              
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
            }
            // 在方法結束前將會呼叫 file.Dispose();
        }
    }
}
