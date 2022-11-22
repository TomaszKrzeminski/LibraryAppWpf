using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_LibraryApplication.Model;
using WPF_LibraryApplication.Widok;

namespace WPF_LibraryApplication.ViewModel
{
    public class BookViewModel:ObserveObject
    {
        public int? BookID { get; set; }
        public string? BookTitle { get; set; }
        public int Pages { get; set; }
        public int Available { get; set; }
        public int Review { get; set; }
        public BookViewModel()
        {

        }
        public BookViewModel(Book book)
        {
            BookID = book.BookID;
            BookTitle = book.BookTitle;
            Pages = book.Pages;
            Available = 0; //From database
            Review = 0;//From database

        }

    }
}
