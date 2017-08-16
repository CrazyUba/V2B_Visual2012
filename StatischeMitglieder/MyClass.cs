using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatischeMitglieder
{
    class MyClass
    {
        static int i;
        int j;

        public static int I
        {
            get
            {
                return i;
            }

            set
            {
                i = value;
            }
        }

        public void foo(string s)
        {
            int x = 0;
                                // Schreibweise: (hilfreich für den Leser)
            MyClass.I++;        // Statische Felder:    Klassennamen voranstellen
            this.j++;           // Instanz-Felder:      'this' voranstellen 
            x++;                // Lokale Variable:     nichts voranstellen     (lokaler Kontext)
            s += x;             // Parameter:           nichts voranstellen     (lokaler Kontext)
        }
    }
}
