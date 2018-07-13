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
        public static Complex ToComplex(string input)
        {
            const string pattern = @"([-+]?(\d+\.?\d*|\d*\.?\d+)([Ee][-+]?[0-2]?\d{1,2})?[r]?|[-+]?((\d+\.?\d*|\d*\.?\d+)([Ee][-+]?[0-2]?\d{1,2})?)?[i]|[-+]?(\d+\.?\d*|\d*\.?\d+)([Ee][-+]?[0-2]?\d{1,2})?[r]?[-+]((\d+\.?\d*|\d*\.?\d+)([Ee][-+]?[0-2]?\d{1,2})?)?[i])";
            var regex = new Regex(pattern);
            // Matches complex number with BOTH real AND imaginary parts.  
            // Ex: -3-2.0i
            Regex patternA = new Regex("([-]?[0-9]+\\.?[0-9]?)([-|+]+[0-9]+\\.?[0-9]?)[i$]+");


            // Matches ONLY real number.
            // Ex: 3.145
            Regex patternB = new Regex("([-]?[0-9]+\\.?[0-9]?)$");

            // Matches ONLY imaginary number.
            // Ex: -10i
            Regex patternC = new Regex("([-]?[0-9]+\\.?[0-9]?)[i$]");

            var matcherA = patternA.Match(input);
            var matcherB = patternB.Match(input);
            var matcherC = patternC.Match(input);

            if (matcherA.Success)
            {

                var real = double.Parse(matcherA.Groups[1].Value);
                var imaginary = double.Parse(matcherA.Groups[2].Value);
                return new Complex(real, imaginary);
            }
            else if (matcherB.Success)
            {
                return new Number(real: double.Parse(matcherA.Groups[1].Value));
            }
            else if (matcherC.Success)
            {
                return new Complex(0, double.Parse(matcherA.Groups[2].Value));
            }
            //const string pattern = @"([-+]?(\d+\.?\d*|\d*\.?\d+)([Ee][-+]?[0-2]?\d{1,2})?[r]?|[-+]?((\d+\.?\d*|\d*\.?\d+)([Ee][-+]?[0-2]?\d{1,2})?)?[i]|[-+]?(\d+\.?\d*|\d*\.?\d+)([Ee][-+]?[0-2]?\d{1,2})?[r]?[-+]((\d+\.?\d*|\d*\.?\d+)([Ee][-+]?[0-2]?\d{1,2})?)?[i])";
            //var regex = new Regex(pattern);

            //var match = regex.Match(input);
            //return new Complex(double.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture), double.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture));
            return new Complex();
        }
    }
}
