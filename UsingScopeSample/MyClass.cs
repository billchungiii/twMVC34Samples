using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingScopeSample
{
    public class MyClass : IDisposable
    {
       public void DoSomething()
        {
            Thread.Sleep(100);
            Console.WriteLine("Do Something");
        }

        public void Dispose()
        {
            Console.WriteLine("Disposed!=============");
        }
    }
}
