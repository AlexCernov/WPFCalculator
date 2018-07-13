
using System.Windows;


namespace WPFCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel.ViewModel model=new ViewModel.ViewModel();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            model.Number1 = number1.Text;
            model.Number2 = number2.Text;
            model.Add();
            output.Text = model.Result;
        }

        private void subtract_Click(object sender, RoutedEventArgs e)
        {
            model.Number1 = number1.Text;
            model.Number2 = number2.Text;
            model.Subtract();
            output.Text = model.Result;
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            model.Number1 = number1.Text;
            model.Number2 = number2.Text;
            model.Divide();
            output.Text = model.Result;
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            model.Number1 = number1.Text;
            model.Number2 = number2.Text;
            model.Multiply();
            output.Text = model.Result;
        }
    }
}
