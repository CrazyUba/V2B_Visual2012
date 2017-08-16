using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class MyExtensions
    {
        public static bool IsNumeric(this string s)
        {
            foreach(char c in s)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
