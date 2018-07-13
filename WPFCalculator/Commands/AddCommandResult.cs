using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFCalculator.ViewModels;

namespace WPFCalculator.Commands
{
    internal class AddCommandResult : ICommand
    {
        public AddCommandResult(ViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        private ViewModel viewModel;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            viewModel.Add();
        }
    }
}
