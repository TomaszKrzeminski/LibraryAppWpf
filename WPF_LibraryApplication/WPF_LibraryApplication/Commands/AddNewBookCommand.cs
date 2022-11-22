using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_LibraryApplication.Model;
using WPF_LibraryApplication.ViewModel;

namespace WPF_LibraryApplication.Commands
{
    class AddNewBookCommand : CommandBase
    {
        private AddBookViewModel model;
        private IRepository repository;
        public AddNewBookCommand() 
        {
        
        
        
        }
        public AddNewBookCommand(AddBookViewModel model)
        {
            repository = new Repository();
            this.model = model;
            model.PropertyChanged += Model_PropertyChanged;

        }

        private void Model_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName==nameof(model.BookTitle)) 
            {
                OnExecuteChanged();
            
            }
            else if(e.PropertyName==nameof(model.BookPages)) 
            {

                OnExecuteChanged();
            
            }
        }

        public override bool CanExecute(object? parameter)
        {
            return !String.IsNullOrEmpty(model.BookTitle) && !(model.BookPages <= 0);
        }

        //public override void CanExecuteChanged()
        //{
        //    return 
        //}

        public override void Execute(object? parameter)
        {

            repository.AddNewBook(model);

        }
    }
    class CancelAddNewBookCommand : CommandBase
    {
        private AddBookViewModel model;
       
        public CancelAddNewBookCommand()
        {



        }
        public CancelAddNewBookCommand(AddBookViewModel model)
        {

            this.model = model;

        }
        public override void Execute(object? parameter)
        {

            //nawigacja powrót

        }
    }
}
