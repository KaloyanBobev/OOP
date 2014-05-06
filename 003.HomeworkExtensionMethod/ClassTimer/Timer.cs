using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassTimer
{
    public delegate void TimerDelegate();

    public static class Timer
    {

       public static void StartTimer(TimerDelegate method, int interval, long duration)
       {
           long start = 0;

           while (duration >= start)
           {
               method();
               Thread.Sleep(interval * 1000);
               start += interval;
           }
       }

    }
}
