using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_LibraryApplication.Widok;

namespace WPF_LibraryApplication.Stores
{
    public class NavigationStore
    {
        private ObserveObject _currentViewModel;

        public ObserveObject CurrentView
        {
            get { return _currentViewModel; }
            set 
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            
            
            }
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?. Invoke();
        }

        public event Action CurrentViewModelChanged;
       
    }
}
