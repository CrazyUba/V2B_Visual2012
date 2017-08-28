using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Operatorueberladung
{
    class Complex
    {
        double real;
        double img; // imaginär

        public Complex(double real, double img)
        {
            this.real = real;
            this.img = img;
        }

        public override string ToString()
        {
            return $"{this.real}, i{this.img}";
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.real + c2.real, c1.img + c2.img);
        }
    }
}
