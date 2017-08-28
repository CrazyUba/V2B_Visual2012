using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Operatorueberladung
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(1, 3);
            Complex b = new Complex(2, 4);
            Complex c = a + b;

            Console.WriteLine(c);   

        }
    }
}
