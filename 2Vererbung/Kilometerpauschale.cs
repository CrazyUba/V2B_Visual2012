using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Vererbung
{
    class Kilometerpauschale : Kostenpunkt
    {
        int kilometer;

        public Kilometerpauschale(int kilometer)
        {
            this.Kilometer = kilometer;
        }

        public int Kilometer
        {
            get
            {
                return kilometer;
            }

            set
            {
                kilometer = value;
                base.Betrag = .30m * kilometer;
                base.Text = "Kilometerpauschale";
            }
        }
    }
}
