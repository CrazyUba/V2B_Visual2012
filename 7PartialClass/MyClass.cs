using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7PartialClass
{
    partial class MyClass
    {
        public void foo_myClass()
        {
            Console.WriteLine(this.GetType() + "_Part1");
        }
    }
}
