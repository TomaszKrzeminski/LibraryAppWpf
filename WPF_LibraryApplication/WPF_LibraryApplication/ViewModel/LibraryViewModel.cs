using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_LibraryApplication.Model;
using WPF_LibraryApplication.Widok;

namespace WPF_LibraryApplication.ViewModel
{
    internal class LibraryViewModel : ObserveObject
    {
        LibraryContext context;
        List<Book> bookList;
        public Command Wyczysc { get; set; }
        public List<Book> BookList
        {
            get { return bookList; }
            set
            { if (BookList != null)
                {
                    bookList = value;
                    OnPropertyChanged("bookList");                
                }



            }
        }

        public LibraryViewModel(LibraryContext context)
        {
            this.context = context;
            BookList = context.Books.ToList();
        }


        
    }
}
