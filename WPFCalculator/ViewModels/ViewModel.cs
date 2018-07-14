
using WPFCalculator.Model;

namespace WPFCalculator.ViewModel
{
    internal class ViewModel
    {
        
        public ViewModel()
        {

        }
        private string result;
        private string number1;
        private string number2;

        public string Result
        {
            get
            {
                if(result==null)
                {
                    return "empty";
                }
                else
                {
                    return result;
                }
            }
            set
            {
                result = value;
            }
        }
        public string Number1
        {
            get { return number1; }
            set { number1 = value; }
        }
        public string Number2
        {
            get { return number2; }
            set { number2 = value; }
        }


        public void Add()
        {
            Complex complexNumber1 = Complex.ToComplex(Number1);
            Complex complexNumber2 = Complex.ToComplex(Number2);
            Result = Operations.Add(complexNumber1, complexNumber2).ToString();
        }
        public void Subtract()
        {
            Complex complexNumber1 = Complex.ToComplex(Number1);
            Complex complexNumber2 = Complex.ToComplex(Number2);
            Result = Operations.Subtract(complexNumber1, complexNumber2).ToString();
        }
        public void Multiply()
        {
            Complex complexNumber1 = Complex.ToComplex(Number1);
            Complex complexNumber2 = Complex.ToComplex(Number2);
            Result = Operations.Multiply(complexNumber1, complexNumber2).ToString();
        }
        public void Divide()
        {
            Complex complexNumber1 = Complex.ToComplex(Number1);
            Complex complexNumber2 = Complex.ToComplex(Number2);
            Result = Operations.Divide(complexNumber1, complexNumber2).ToString();
        }
    }
}
