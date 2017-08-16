using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kostenpunkt> listeKostenpunkte = new List<Kostenpunkt>{ 
                new Kostenpunkt {Text = "Allgemeiner Kostenpunkt", Datum = DateTime.Now, Betrag=50m },
                new Kilometerpauschale(kilometer: 60),
                new Tagespauschale(anzahlTage: 5)
            };

            var tp = new Tagespauschale(2);
            tp.AnzahlTage = 10;

            listeKostenpunkte.Add(tp);

            foreach (var kostenpunkt in listeKostenpunkte)
            {
                Console.WriteLine($"Text: {kostenpunkt.Text}, \tDatum: {kostenpunkt.Datum}, \tBetrag: {kostenpunkt.Betrag}");
            }


        }
    }
}
