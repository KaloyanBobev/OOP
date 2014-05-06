// Using delegates write a class Timer that has can execute certain method at each t seconds.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer.StartTimer(Print, 3, 10);
        }

        private static void Print()
        {
           
                Console.WriteLine(DateTime.Now.Second); 
            
        }
    }
}
