using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PublishingEvants
{
    public class Timer : EventArgs
    {
        private DateTime TimeNow;

        public DateTime Time
        {
            get
            {
                return this.TimeNow;
            }
            set
            {
                TimeNow = value;
            }
            
        }
    }
    public class StartTimer
    {
        public event TimerDelegate Tick;
        public delegate void TimerDelegate(StartTimer st, Timer e);

        public void Start()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                if (Tick != null)
                {
                    Timer t = new Timer();
                    t.Time = DateTime.Now;
                    Tick(this, t);
                }
            }
        }
    }
        public class Run
        {

            public void Subscribe(StartTimer st)
            {
                st.Tick += new StartTimer.TimerDelegate(Print);
            }

            private void Print(StartTimer st, Timer e)
            {
                Console.WriteLine("{0}",e.Time.Second);
            }

        }
                
    
}
