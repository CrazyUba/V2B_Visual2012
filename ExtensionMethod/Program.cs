using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "456789";

            Console.WriteLine(s.IsNumeric()); 
        }
    }
}
