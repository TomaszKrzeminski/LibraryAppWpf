using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WPF_LibraryApplication.Model
{
    public class User
    {

        public User(string UserName,string UserSurname)
        {
            this.UserName = UserName;
            this.UserSurname= UserSurname;            
            BorrowedBooks = new List<Book>();
        }


        public int UserID { get; set; }
        public string? UserName { get; set; }
        public string? UserSurname { get; set; }


        public List<Book> BorrowedBooks { get; set; }
        public virtual Adress? UserAdress { get; set; }

    }

    public class Adress
    {
        public int AdressID { get; set; }
        public string? PostCode { get; set; }
        public string? Country { get; set; }
        public string? Town { get; set; }
        public string? Street { get; set; }
        public string? BuildingNumber { get; set; }

        public int? UserId { get; set; }
        public virtual User? User { get; set; }

    }

    public class Book 
    {

        public Book()
        {
            BookAuthors = new List<Author>();
            BookReviews = new List<Review>();            
            BorrowedStart = null;
            BorrowedEnd = null;
            Edition = DateTime.Now;
        }

        public int? BookID { get; set; }
        public string? BookTitle { get; set; }

        public DateTime Edition { get; set; }
        public int Pages { get; set; }
        public bool Borrowed 
        {
            get;set;
        }
        public DateTime? BorrowedStart { get; set; }
        public DateTime? BorrowedEnd { get; set; }

        public int? UserId { get; set; }
        public virtual User? User { get; set; }

       public List<Author> BookAuthors { get; set; }
       public List<Review> BookReviews { get; set; }

       
    }

    public class Author
    {
        public int AuthorID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }

        public int? BookId { get; set; }
        public virtual Book? Book { get; set; }
    }

    public class Review
    {
        public int ReviewID { get; set; }
        public int Rating { get; set; }
        public string? Text { get; set; }

        public int? BookId { get; set; }
        public virtual Book? Book { get; set; }

    }


}
