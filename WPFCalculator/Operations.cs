using WPFCalculator.Model;

namespace WPFCalculator
{
   public static class Operations
    {
        public static Complex Add(Complex a, Complex b)
        {
            return a + b;
        }
        public static Complex Subtract(Complex a, Complex b)
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