using System;
using System.Windows;
using WPFCalculator.Model;

namespace WPFCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(Complex.ToComplex(number1.Text));
        }
    }
}
