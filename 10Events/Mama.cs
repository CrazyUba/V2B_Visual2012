using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Events
{
    class Mama
    {
        Mitarbeiter sohn;

        public Mitarbeiter Sohn
        {
            set
            {
                sohn = value;
                sohn.WorkDoneEvent += Sohn_WorkDoneEvent;
            }
        }

        private void Sohn_WorkDoneEvent()
        {
            Console.WriteLine("Mama: Prima, dann geh ins Bett");
        }
    }
}
