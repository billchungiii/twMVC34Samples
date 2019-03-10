using System;
using System.Threading.Tasks;

namespace AsyncStreamSample002
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var path = "SourceFile.txt";
            await foreach (var item in FileProcess.ReadLineAsync(path))
            {
                Console.WriteLine(item);
            };
        }
    }
}
