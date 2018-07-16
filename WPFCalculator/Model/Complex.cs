using System.Text.RegularExpressions;


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
            var real = c1.Real + c2.Real;
            var img = c1.Img + c2.Img;
            if (img==0)
                return new Number(real);
            return new Complex(real,img);
        }
        public static Complex operator-(Complex c1, Complex c2)
        {
            var real = c1.Real - c2.Real;
            var img = c1.Img - c2.Img;
            if (img == 0)
                return new Number(real);
            return new Complex(real, img);
        }
        public static Complex operator*(Complex c1, Complex c2)
        {
            var real = c1.Real * c2.Real - c1.Img * c2.Img;
            var img = c1.Real * c2.Img + c2.Real * c1.Img;
            if (img == 0)
                return new Number(real);
            return new Complex(real, img);
        }
        public static Complex operator/(Complex c1, Complex c2)
        {
            var real = (c1.Real * c2.Real + c1.Img * c2.Img) / (c2.Real * c2.Real + c2.Img * c2.Img);
            var img = (c2.Real * c1.Img - c1.Real * c2.Img) / (c2.Real * c2.Real + c2.Img * c2.Img);
            if (img == 0)
                return new Number(real);
            return new Complex(real, img);
        }
        public static Complex ToComplex(string input)
        {
            const string pattern = @"([-+]?(\d+\.?\d*|\d*\.?\d+)([Ee][-+]?[0-2]?\d{1,2})?[r]?|[-+]?((\d+\.?\d*|\d*\.?\d+)([Ee][-+]?[0-2]?\d{1,2})?)?[i]|[-+]?(\d+\.?\d*|\d*\.?\d+)([Ee][-+]?[0-2]?\d{1,2})?[r]?[-+]((\d+\.?\d*|\d*\.?\d+)([Ee][-+]?[0-2]?\d{1,2})?)?[i])";
            var regex = new Regex(pattern);
            // Matches complex number with BOTH real AND imaginary parts.  
            // Ex: -3-2.0i
            Regex patternA = new Regex("([-]?[0-9]+\\.?[0-9]?)([-|+]+[0-9]?\\.?[0-9]?)[i$]+");

            // Matches ONLY real number.
            // Ex: 3.145
            Regex patternB = new Regex("([-]?[0-9]+\\.?[0-9]?)$");

            // Matches ONLY imaginary number.
            // Ex: -10i
            Regex patternC = new Regex("([-]?[0-9]?\\.?[0-9]?)[i$]");

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
                return new Number(real: double.Parse(matcherB.Groups[1].Value));
            }
            else if (matcherC.Success)
            {
                return new Complex(0, double.Parse(matcherC.Groups[1].Value));
            }
            //it would be better to throw an exception or something
            return new Complex();
        }

        public override string ToString()
        {
            string number;
            string realStr = Real.ToString();
            string imgStr = Img.ToString();
            if (realStr.Length>6)
                realStr = Real.ToString().Substring(0, 5);
            if (imgStr.Length > 6)
                 imgStr = Img.ToString().Substring(0, 5);
            if (Real == 0)
            {
                number = "";
            }
            else
            {
                number = "" + realStr;
            }

            if (Img == -1)
            {
                number += "-i";
            }
            else if (Img == 1)
            {
                number += "i";
            }
            else
            {
                if(Img>0)
                {
                    if(Real!=0)
                    {
                        number += "+" + imgStr + "i";
                    }
                    else
                    {
                        number += "" + imgStr + "i";
                    }
                }
                else
                {
                    number += "" + imgStr + "i";
                }
            }
            return number;
        }
    }
}
