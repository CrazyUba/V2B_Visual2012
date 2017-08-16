using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Vererbung
{
    class Kostenpunkt
    {
        string text;
        DateTime datum;
        decimal betrag;

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }

        public DateTime Datum
        {
            get
            {
                return datum;
            }

            set
            {
                datum = value;
            }
        }

        public decimal Betrag
        {
            get
            {
                return betrag;
            }

            set
            {
                betrag = value;
            }
        }

        public Kostenpunkt()
        {
            datum = DateTime.Now;
        }
    }
}
