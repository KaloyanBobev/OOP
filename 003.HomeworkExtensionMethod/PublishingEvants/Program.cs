// * Read in MSDN about the keyword event in C# and how to publish events. Re-implement the above using .NET events and following the best practices.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishingEvants
{
    class Program
    {
        static void Main(string[] args)
        {
            StartTimer t = new StartTimer();
            Run l = new Run();
            l.Subscribe(t);
            t.Start();

            Console.WriteLine("If the counting is below this message that means counting does not break the process...");
        }

       
    }
}
