using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_LibraryApplication.Services;
using WPF_LibraryApplication.Stores;
using WPF_LibraryApplication.ViewModel;
using WPF_LibraryApplication.Widok;

namespace WPF_LibraryApplication.Commands
{
    public class NavigateCommand : CommandBase
    {
        private NavigationStore navigationStore;
       
        public NavigateCommand(NavigationStore navigationStore )
        {             
            this.navigationStore = navigationStore; 
        }
        public override void Execute(object? parameter)
        {

            navigationStore.CurrentView = new AddBookViewModel();
            
        }
    }

    public class NavigateCommand2 : CommandBase
    {
        private NavigationService service;

        public NavigateCommand2(NavigationService service)
        {
            this.service = service;
        }
        public override void Execute(object? parameter)
        {

            service.Navigate();

        }
    }


}
