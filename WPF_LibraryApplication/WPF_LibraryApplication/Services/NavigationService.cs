using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_LibraryApplication.Stores;
using WPF_LibraryApplication.ViewModel;
using WPF_LibraryApplication.Widok;

namespace WPF_LibraryApplication.Services
{
   public class NavigationService
    {
        private NavigationStore navigationStore;
        private Func<ObserveObject> currentView;
        public NavigationService(NavigationStore navigationStore,Func<ObserveObject> currentView)
        {
            this.currentView=currentView; ;
            this.navigationStore = navigationStore;
        }
        

        public void Navigate()
        {
            navigationStore.CurrentView = currentView();
        }


    }
}
