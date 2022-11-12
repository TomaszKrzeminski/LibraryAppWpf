using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WPF_LibraryApplication.Model
{
    public class User
    {

        public User()
        {
            BorrowedBooks = new List<Book>();
        }


        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }


        public List<Book> BorrowedBooks { get; set; }
        public Adress UserAdress { get; set; }

    }

    public class Adress
    {
        public int AdressID { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }

        public int? UserID { get; set; }
        public User? User { get; set; }

    }

    public class Book
    {

        public Book()
        {
            BookAuthors = new List<Author>();
            BookReviews = new List<Review>();
        }

        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public bool Borrowed { get; set; }
        public DateTime BorrowedStart { get; set; }
        public DateTime BorrowedEnd { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        List<Author> BookAuthors { get; set; }
        List<Review> BookReviews { get; set; }
    }

    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public int BookID { get; set; }
        public Book Book { get; set; }
    }

    public class Review
    {
        public int ReviewID { get; set; }
        public int Rating { get; set; }
        public string Text { get; set; }

        public int BookID { get; set; }
        public Book Book { get; set; }

    }


}
