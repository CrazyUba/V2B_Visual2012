using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Events
{
    class Manager
    {
        
        public void DoWork()
        {
            Mitarbeiter mitarbeiter = new Mitarbeiter();
            mitarbeiter.WorkDoneEvent += Mitarbeiter_WorkDoneEvent;
            Console.WriteLine("Manager: Hier hast Du was zu tun");
            Task t = new Task(mitarbeiter.DoWork);
            t.Start();
            Console.WriteLine("Manager: Ich gehe dann mal Golf spielen ...");
           
        }

        private void Mitarbeiter_WorkDoneEvent()
        {
            Console.WriteLine("Manager: Prima, dann mach Feierabend");
        }
    }
}
