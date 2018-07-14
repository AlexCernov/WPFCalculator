
using System;
using System.ComponentModel;
using System.Windows.Input;
using WPFCalculator.Commands;
using WPFCalculator.Model;

namespace WPFCalculator.ViewModels
{
    internal class ViewModel : INotifyPropertyChanged
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
                return result;
            }
            set
            {
                result = value;
                OnPropertyChanged("Result");
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
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

        private ICommand addCommand;
        private ICommand subtractCommand;
        private ICommand multiplyCommand;
        private ICommand divideCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new OperationCommand(
                        param => this.Add(),
                        param => this.CanAdd()
                    );
                }
                return addCommand;
            }
        }


        public ICommand SubtractCommand
        {
            get
            {
                if (subtractCommand == null)
                {
                    subtractCommand = new OperationCommand(
                        param => this.Subtract(),
                        param => this.CanMultiply()
                    );
                }
                return subtractCommand;
            }
        }

        public ICommand MultiplyCommand
        {
            get
            {
                if (multiplyCommand == null)
                {
                    multiplyCommand = new OperationCommand(
                        param => this.Multiply(),
                        param => this.CanDivide()
                    );
                }
                return multiplyCommand;
            }
        }

        public ICommand DivideCommand
        {
            get
            {
                if (divideCommand == null)
                {
                    divideCommand = new OperationCommand(
                        param => this.Divide(),
                        param => this.CanDivide()
                    );
                }
                return divideCommand;
            }
        }

        private bool CanAdd()
        {
            return true;
        }

        private bool CanSubtract()
        {
            return true;
        }
        private bool CanMultiply()
        {
            return true;
        }
        private bool CanDivide()
        {
            return true;
        }

        private void Add()
        {
            
            Complex complexNumber1 = Complex.ToComplex(Number1);
            Complex complexNumber2 = Complex.ToComplex(Number2);
            Result = Operations.Add(complexNumber1, complexNumber2).ToString();
        }
        private void Subtract()
        {
            Complex complexNumber1 = Complex.ToComplex(Number1);
            Complex complexNumber2 = Complex.ToComplex(Number2);
            Result = Operations.Subtract(complexNumber1, complexNumber2).ToString();
        }
        private void Multiply()
        {
            Complex complexNumber1 = Complex.ToComplex(Number1);
            Complex complexNumber2 = Complex.ToComplex(Number2);
            Result = Operations.Multiply(complexNumber1, complexNumber2).ToString();
        }
        private void Divide()
        {
            Complex complexNumber1 = Complex.ToComplex(Number1);
            Complex complexNumber2 = Complex.ToComplex(Number2);
            Result = Operations.Divide(complexNumber1, complexNumber2).ToString();
        }


    }
}
