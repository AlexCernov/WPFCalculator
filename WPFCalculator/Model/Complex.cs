using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCalculator.Model
{
     public  class Complex
    {
        public double Real { get; set; }
        public double Img { get; set; }

        public Complex(double real, double img)
        {
            Real = real;
            Img = img;
        }

        public static Complex operator+(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Img + c2.Img);
        }
        public static Complex operator-(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Img - c2.Img);
        }
        public static Complex operator*(Complex c1, Complex c2)
        {
            return new Complex(c1.Real * c2.Real - c1.Img * c2.Img, c1.Real * c2.Img +  c2.Real * c1.Img);
        }
        public static Complex operator/(Complex c1, Complex c2)
        {
            return new Complex((c1.Real * c2.Real + c1.Img * c2.Img)/(c2.Real*c2.Real + c2.Img*c2.Img),(c2.Real*c1.Img - c1.Real*c2.Img)/(c2.Real * c2.Real + c2.Img * c2.Img));
        }
    }
}
