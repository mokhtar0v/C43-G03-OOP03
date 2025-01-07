using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesstion3_OOP.Operator_Overload
{
    internal class Complex
    {
        public int real { get; set; }
        public int imaginary { get; set; }

        public static Complex operator + (Complex left, Complex right)
        {
            return new Complex
            {
                real = (left?.real ?? 0) + (right?.real ?? 0),
                imaginary = (left?.imaginary ?? 0) + (right?.imaginary ?? 0)
            };
        }
        public static Complex operator ++ (Complex c)
        {
            return new Complex
            {
                real = (c?.real ?? 0) + 1,
                imaginary = c?.imaginary ?? 0
            };
        }
        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }
    }
}
