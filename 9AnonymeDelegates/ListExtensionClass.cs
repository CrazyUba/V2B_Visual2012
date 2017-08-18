using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9AnonymeDelegates
{
    static class ListExtensionClass     // Zugriffsmodifizierer ist per default 'internal' => Zugriff innerhalb des Assemblies möglich
    {
        static public void Print<T>(this List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
