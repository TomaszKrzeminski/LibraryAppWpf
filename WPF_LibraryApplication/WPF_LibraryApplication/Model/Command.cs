using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_LibraryApplication.Model
{
    public class Command : ICommand
    {
        Action _execute;
        public Command(Action executeMethod)
        {
            _execute = executeMethod;
        }
        public void Execute(object parameter)
        {
            if (_execute != null)
            {
                _execute();
            }
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged;
    }
}
