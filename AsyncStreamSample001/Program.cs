using System;
using System.Threading.Tasks;

namespace AsyncStreamSample001
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var path = "SourceFile.txt";
            var fileprocess = new AsyncFileProcess(path);
            await foreach (var line in fileprocess)
            {
                Console.WriteLine(line);
            }
        }
    }
}
