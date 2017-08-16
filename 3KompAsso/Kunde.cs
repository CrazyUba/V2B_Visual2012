using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3KompAsso
{
    class Kunde
    {
        List<Bestellung> bestellungen = new List<Bestellung>();

        public Bestellung NewBestellung()   // "Factory pattern"
        {
            Bestellung b = new Bestellung(this);
            bestellungen.Add(b);
            return b;
        }
    }
}
