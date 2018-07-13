using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WPFCalculator.Model
{
     public  class Complex
    {
        public double Real { get; set; }
        public double Img { get; set; }

        public Complex()
        {

        }

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

        public void ToComplex(string input)
        {
            const string pattern = @"([-+]?(\d+\.?\d*|\d*\.?\d+)([Ee][-+]?[0-2]?\d{1,2})?[r]?|[-+]?((\d+\.?\d*|\d*\.?\d+)([Ee][-+]?[0-2]?\d{1,2})?)?[i]|[-+]?(\d+\.?\d*|\d*\.?\d+)([Ee][-+]?[0-2]?\d{1,2})?[r]?[-+]((\d+\.?\d*|\d*\.?\d+)([Ee][-+]?[0-2]?\d{1,2})?)?[i])";
            var regex = new Regex(pattern);

            var match = regex.Match(input);

            this.Real = double.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture);
            this.Img = double.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
        }
    }
}
