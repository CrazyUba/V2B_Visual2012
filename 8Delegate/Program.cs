using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Doit();
        }

        delegate bool StringPruefer(string s);

        private void Doit()
        {
            StringPruefer stringPruefer = new StringPruefer(hasDigits);
            Console.WriteLine(stringPruefer("Diest ist ein Test 7"));
        }

        bool hasDigits(string s)
        {
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }

        bool hasWhiteSpace(string s)
        {
            foreach (char c in s)
            {
                if (char.IsWhiteSpace(c))
                    return true;
            }
            return false;
        }
    }
}
