using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapselung
{
    class Program
    {
        static void Main(string[] args)
        {
            var vec = new vector(7);

            Console.WriteLine(vec);
            vec.ScalarMultiply(5);
            Console.WriteLine(vec);
            vec.SetValue(1, 777);
            Console.WriteLine(vec);
            Debug.Print("Test");
        }
    }

    class vector
    {
        int length;
        int[] values;

        public vector(int length)
        {
            this.length = length;
            this.values = new int[length];

            for (int i = 0; i < this.length; i++)
            {
                values[i] = i;
            }
        }

        public int[] ScalarMultiply(int factor)
        {
            for (int i = 0; i < this.length; i++)
            {
                this.values[i] *= factor;
            }
            return values;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < this.length; i++)
            {
                s += values[i] + " / ";
            }

            return s;
        }

        public void SetValue(int index, int value)
        {
            this.values[index] = value;
        }
    }
}
