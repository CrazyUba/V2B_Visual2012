using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3KompAsso
{
    class Kategorie
    {
        List<Produkt> produktListe = new List<Produkt>();

        public void AddProduct(Produkt p)
        {
            produktListe.Add(p);
        }
    }
}
