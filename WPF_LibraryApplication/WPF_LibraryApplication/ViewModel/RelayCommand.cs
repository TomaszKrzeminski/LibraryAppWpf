﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_LibraryApplication.ViewModel
{
    public class RelayCommand : ICommand
    {
       
        public Action<object> execute;
        public Func<object, bool> canExecute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute=null)
        {
            if (execute == null)
            {
                throw new ArgumentNullException(nameof(Execute));
            }
            else
            {
                this.execute = execute;
            }
            
            this.canExecute = canExecute;
        }

        
         public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
   
        public bool CanExecute(object parameter)
        {
            if(canExecute==null)
            {
                return true;
            }
            else
            {
                return canExecute(parameter);
            }
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
