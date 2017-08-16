using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3KompAsso
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assoziation: Zwei Objekte existieren unabhängig voneinander, stehen aber in Bezug zueinander
            Kategorie kat = new Kategorie();
            Produkt p = new Produkt();
            kat.AddProduct(p);

            // Komposition: Bestellung existiert nur in Verbindung mit Kunden
            Kunde k = new Kunde();
            k.NewBestellung();


        }
    }
}
