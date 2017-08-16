using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    internal delegate decimal Computation(decimal x, decimal y);
    internal class Computer
    {
        public decimal compute(Computation x, decimal a, decimal b)
        {

            var result = x(a, b);
            return result;

        }
    }
}
