
namespace WPFCalculator.Model
{
    class Number : Complex
    {
        public Number(double real) : base(real, 0)
        {
        }

        public override string ToString()
        {
            return "" + Real;
        }
    }
}
