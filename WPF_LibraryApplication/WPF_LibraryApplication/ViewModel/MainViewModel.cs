using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_LibraryApplication.Stores;
using WPF_LibraryApplication.Widok;

namespace WPF_LibraryApplication.ViewModel
{
    class MainViewModel:ObserveObject
    {
        public ObserveObject currentViewModel =>navigationStore.CurrentView; 
        NavigationStore navigationStore;
        public MainViewModel(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
            navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
                  
        }

        public void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(currentViewModel));
        }
    }
}
