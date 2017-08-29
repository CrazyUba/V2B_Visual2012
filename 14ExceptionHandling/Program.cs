using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            double d=0d;
            try
            {
                d = comp.Divide(4, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("");
                Console.WriteLine(e.Message);
                //Console.WriteLine();
                //Console.WriteLine(e.Message);
                //Console.WriteLine();
                //Console.WriteLine(e.GetType().FullName);

            }
            

            Console.WriteLine($"d={d}");
            Console.ReadKey();
        }
    }
}
