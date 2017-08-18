using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9AnonymeDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().DoIt();
        }

        private void DoIt()
        {

            List<int> list = new List<int> { 45, 3, 6, 778, 5, 4, 99, 5 };
            list.Print<int>();

            list.Sort(new Comparison<int>(Ascending));              // Delegate
            list.Sort(Ascending);                                   // Delegate, kürzere Schreibweise
            list.Sort(delegate (int i, int j) { return i - j; });   // Anonymer Delegate (Vorteil: Hat Zugriff auf lokale (umgebende) Variablen)
            list.Sort((i, j) => { return i - j; });                 // Lambda Expression, kürzere Schreibweise des anonymen Delegates

            Console.WriteLine();

            list.Print<int>();
        }

        private void printList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private int Ascending(int i, int j)
        {
            return i - j;
        }

        private int Descending(int i, int j)
        {
            return j - i;
        }
    }
}
