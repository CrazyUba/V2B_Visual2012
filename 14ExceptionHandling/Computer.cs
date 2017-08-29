using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _14ExceptionHandling
{
    class Computer
    {
        public double Divide(int a, int b)
        {
            try
            {
                //throw new FileNotFoundException("File not found", "myfile.txt");
                File.ReadAllLines("myfile.txt");
                double c = a / b;
                return c;
            }
            catch (Exception e)
            {
                //throw new Exception("Mist", e);
                //Console.WriteLine(e);
                //Console.WriteLine();
                //Console.WriteLine();
                throw new Exception("My message", e);   // OK: Stack-Trace inklusive der Angabe der Zeilennummer
                //throw;                        // NOK: Stack-Trace, verliert aber die Zeilennummer
                //throw e;                      // NOK: Kein Stack-Trace

            }
            

        }
    }
}
