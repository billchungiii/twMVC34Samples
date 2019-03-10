using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncStreamSample000
{
    class Program
    {
        async static Task Main(string[] args)
        {
            await foreach (var item in GetData())
            {
                Console.WriteLine(item);
            }
        }

        async static public IAsyncEnumerable<string> GetData()
        {
            var list = new List<string> { "A", "B", "C", "D", "E" };
            foreach (var item in list)
            {
                await Task.Delay(100);
                yield return item;
            }
        }
    }
}
