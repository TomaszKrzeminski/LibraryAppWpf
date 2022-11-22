using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_LibraryApplication.Commands;
using WPF_LibraryApplication.Stores;
using WPF_LibraryApplication.Widok;

namespace WPF_LibraryApplication.ViewModel
{
    public class AddBookViewModel: ObserveObject
    {
        private string bookTitle;

        public string BookTitle
        {
            get { return bookTitle; }
            set 
            { bookTitle = value;
              OnPropertyChanged("BookTitle");   
            }
        }
        private DateTime bookEdition;

        public DateTime BookEdition
        {
            get { return bookEdition; }
            set
            {
                bookEdition = value;
                OnPropertyChanged("BookEdition");
            }
        }

        private int bookPages;

        public int BookPages
        {
            get { return bookPages; }
            set
            {
                bookPages = value;
                OnPropertyChanged("BookPages");
            }
        }

        private string bookAuthors;

        public string BookAuthors
        {
            get { return bookAuthors; }
            set
            {
                bookAuthors = value;
                OnPropertyChanged("BookTitle");
            }
        }

        private string bookReview;

        public string BookReview
        {
            get { return bookReview; }
            set
            {
                bookReview = value;
                OnPropertyChanged("BookReview");
            }
        }

       public ICommand Submit { get; set; }
       public ICommand Cancel { get; set; }

        private NavigationStore navigationStore;

        public AddBookViewModel(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
            Submit = new AddNewBookCommand(this);
            Cancel = new NavigateCommand(navigationStore);
            bookEdition = DateTime.Now;
            BookPages = 0;
            bookTitle = "Podaj Tytuł";
            bookAuthors = "Podaj Autorów";
            bookReview = "Podaj opis książki";
        }

        public AddBookViewModel()
        {
           
            Submit = new AddNewBookCommand(this);
            Cancel = new NavigateCommand(navigationStore);
            bookEdition = DateTime.Now;
            BookPages = 0;
            bookTitle = "Podaj Tytuł";
            bookAuthors = "Podaj Autorów";
            bookReview = "Podaj opis książki";
        }



    }

    public class AddUserViewModel : ObserveObject
    {

    }

    public class BookOptionsViewModel : ObserveObject
    {

    }


}
