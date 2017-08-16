using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatischeMitglieder
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass x = new MyClass();
            MyClass y = new MyClass();

            x.foo();
            y.foo();

            Console.WriteLine(MyClass.I);
            
        }
    }
}
