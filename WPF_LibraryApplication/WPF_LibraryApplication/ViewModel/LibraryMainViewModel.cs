using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_LibraryApplication.Commands;
using WPF_LibraryApplication.Model;
using WPF_LibraryApplication.Stores;
using WPF_LibraryApplication.Widok;

namespace WPF_LibraryApplication.ViewModel
{
    public class LibraryMainViewModel : ObserveObject
    {
        public ICommand? SortAscending { get; set; }
        public ICommand? SortDescending { get; set; }
        public ICommand? ShowDetails { get; set; }
        public ICommand? NavigationCommand { get; set; }
        private NavigationStore navigationStore { get; set; }

        ObservableCollection<BookViewModel> booksList;
        public IEnumerable<BookViewModel> BooksList => booksList;
       

        //public LibraryMainViewModel()
        //{


        //    booksList = new ObservableCollection<BookViewModel>();
        //    booksList.Add(new BookViewModel() { BookID = 1, BookTitle = "Jakis", Available = 10 });
        //    booksList.Add(new BookViewModel() { BookID = 2, BookTitle = "Jakis", Available = 10 });
        //    booksList.Add(new BookViewModel() { BookID = 3, BookTitle = "Jakis", Available = 10 });
        //    booksList.Add(new BookViewModel() { BookID = 4, BookTitle = "Jakis", Available = 10 });
        //    booksList.Add(new BookViewModel() { BookID = 5, BookTitle = "Jakis", Available = 10 });
        //    booksList.Add(new BookViewModel() { BookID = 6, BookTitle = "Jakis", Available = 10 });

        //}
      

        public LibraryMainViewModel(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
               
            NavigationCommand = new NavigateCommand(navigationStore);
            booksList = new ObservableCollection<BookViewModel>();
            booksList.Add(new BookViewModel() { BookID = 1, BookTitle = "Jakis", Available = 10 });
            booksList.Add(new BookViewModel() { BookID = 2, BookTitle = "Jakis", Available = 10 });
            booksList.Add(new BookViewModel() { BookID = 3, BookTitle = "Jakis", Available = 10 });
            booksList.Add(new BookViewModel() { BookID = 4, BookTitle = "Jakis", Available = 10 });
            booksList.Add(new BookViewModel() { BookID = 5, BookTitle = "Jakis", Available = 10 });
            booksList.Add(new BookViewModel() { BookID = 6, BookTitle = "Jakis", Available = 10 });

        }



    }
}
