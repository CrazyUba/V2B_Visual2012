using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Vererbung
{
    class Tagespauschale : Kostenpunkt
    {
        int anzahlTage;

        public Tagespauschale(int anzahlTage)
        {
            this.AnzahlTage = anzahlTage;
        }

        public int AnzahlTage
        {
            get
            {
                return anzahlTage;
            }

            set
            {
                anzahlTage = value;
                base.Text = "Tagespauschale";
                base.Betrag = 42m * anzahlTage;
            }
        }
    }
}
