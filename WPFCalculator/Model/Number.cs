using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCalculator.Model
{
    class Number : Complex
    {
        public Number(double real) : base(real, 0)
        {
        }
    }
}
