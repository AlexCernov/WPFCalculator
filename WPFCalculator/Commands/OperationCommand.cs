using System;
using System.Diagnostics;
using System.Windows.Input;

namespace WPFCalculator.Commands
{
    internal class OperationCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Predicate<object> canExecute;

        public OperationCommand(Action<object> execute)
        : this(execute, null)
        {
        }

        public OperationCommand(Action<object> execute, Predicate<object> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }


        #region ICommand Members

        [DebuggerStepThrough]
        public bool CanExecute(object parameters)
        {
            return canExecute == null ? true : canExecute(parameters);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameters)
        {
            execute(parameters);
        }

        #endregion // ICommand Members
    }
}

