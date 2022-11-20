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

namespace WPF_LibraryApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //private readonly ServiceProvider _serviceProvider;
        public App()
        {
            
        }

       

        protected override void OnStartup( StartupEventArgs e)
        {            
            SeedData seed = new SeedData();
            seed.Seed();
            base.OnStartup(e);
           
        }

    }
}
