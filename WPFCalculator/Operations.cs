using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WPFCalculator
{
    class Operations
    {
        public static Complex Add (Complex a,Complex b)
        {
            return a + b;
        }
        public static Complex Substract(Complex a, Complex b)
        {
            return a - b;
        }
        public static Complex Multiply(Complex a, Complex b)
        {
            return a * b;
        }
        public static Complex Divide(Complex a, Complex b)
        {
            return a / b;
        }
    }
}
