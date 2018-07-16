
namespace WPFCalculator.Model
{
    class Number : Complex
    {
        public Number(double real) : base(real, 0)
        {
        }

        public override string ToString()
        {
            string realStr = Real.ToString();          
            if (realStr.Length > 6)
                realStr = Real.ToString().Substring(0, 5);

            return "" + realStr;
        }
    }
}
