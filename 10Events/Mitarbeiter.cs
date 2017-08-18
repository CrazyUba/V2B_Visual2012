using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10Events
{
    class Mitarbeiter
    {
        public delegate void WorkDone();
        public event WorkDone WorkDoneEvent;

        public Mitarbeiter()
        {
            Mama mama = new Mama();
            mama.Sohn = this;
        }

        public void DoWork()
        {
            Console.WriteLine("Mitarbeiter: Ich arbeite ja schon");
            Thread.Sleep(3 * 1000);
            Console.WriteLine("Mitarbeiter: Fertig");

            if (WorkDoneEvent != null)
                WorkDoneEvent();
        }
    }
}
