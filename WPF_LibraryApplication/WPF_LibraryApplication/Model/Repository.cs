using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_LibraryApplication.View;
using WPF_LibraryApplication.ViewModel;

namespace WPF_LibraryApplication.Model
{   
    public interface IRepository
    {
        bool AddNewBook(AddBookViewModel model);

    }

    public class Repository : IRepository
    {
        public bool AddNewBook(AddBookViewModel model)
        {
            try
            { MessageBox.Show("Dodano książkę","",MessageBoxButton.OK,MessageBoxImage.Warning);
                return true;
               
            }
            catch (Exception)
            {
                MessageBox.Show("Nie udało się dodać książki", "", MessageBoxButton.OK, MessageBoxImage.Error);

                return false;

            }
        }
    }


}
