using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_LibraryApplication.Model;
using WPF_LibraryApplication.Stores;
using WPF_LibraryApplication.ViewModel;

namespace WPF_LibraryApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore navigationStore;
        public App()
        {
            navigationStore= new NavigationStore();
        }

       

        protected override void OnStartup( StartupEventArgs e)
        {            
            SeedData seed = new SeedData();
            seed.Seed();

            navigationStore.CurrentView = new LibraryMainViewModel(navigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
           
        }

    }
}
