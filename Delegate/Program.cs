using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            //var x = comp.compute(delegate (decimal a, decimal b) { return a + b; }, 4, 5);
            var x = comp.compute((a, b) => { return a + b; }, 4, 5);

            Console.WriteLine(x);

            
        }
    }
}
