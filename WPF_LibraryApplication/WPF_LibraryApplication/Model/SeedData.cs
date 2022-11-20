using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LibraryApplication.Model
{
    public class SeedData
    {
        LibraryContext ctx1;

        public SeedData(LibraryContext ctx1)
        {
            this.ctx1 = ctx1;
        }
        public SeedData()
        {
            
        }

        public User AddUser(string UserName,string UserSurname,Adress adress)
        {
            try
            {

                using(var ctx=new  LibraryContext())
                {
                
                User user = new User(UserName, UserSurname);
                ctx.Users.Add(user);
                ctx.SaveChanges();

                user.UserAdress = adress;
                ctx.SaveChanges();
                return user;
                
                }

                

                //user.BorrowedBooks.AddRange(books);
                //ctx.SaveChanges();

                
            }
            catch(Exception ex)
            {
                return null;
            }
           
        }
        public Author AddAuthor(string Name,string Surname)
        {

            using (var ctx = new LibraryContext())
            {

 Author author = new Author() { Name = Name, Surname = Surname };
            ctx.Authors.Add(author);
            ctx.SaveChanges();
            return author;


            }

           
        }
        public Book AddBook(string Title,List<Author> authors,List<Review> rewievs)
        {
            try
            {
                using (var ctx = new LibraryContext())
                {

                Book book = new Book() { BookTitle = Title, Pages = 100 ,Borrowed=false};
                ctx.Books.Add(book);
                ctx.SaveChanges();

                book.BookAuthors.AddRange(authors);
                ctx.SaveChanges();
                book.BookReviews.AddRange(rewievs);
                ctx.SaveChanges();
                return book;


                }
               
            }
            catch (Exception ex)
            {
                return null;
            }          

           
        }
        public Review AddReview(int Rating,string Text)
        {
            using (var ctx = new LibraryContext())
            {

            Review rev = new Review() { Rating = Rating, Text = Text };
            ctx.Reviews.Add(rev);
            ctx.SaveChanges();
            return rev;


            }
            
        }
        public void Seed()
        {
            using (var ctx = new LibraryContext())
            {
                ctx.Database.EnsureCreated();

                Author a1 = AddAuthor("Adam", "Mickiewicz");
                Author a2 = AddAuthor("Bolesław", "Prus");
                Author a3 = AddAuthor("Jerzy", "Grębosz");
                Author a4 = AddAuthor("Homer", "Homer");
                Author a5 = AddAuthor("J.R.R", "Tolkien");

                Review rev = AddReview(2, "Moja testowa opinia");

                Book panTad = AddBook("Pan Tadeusz", new List<Author>() { a1 }, new List<Review>() { rev });
                Book lalka = AddBook("Lalka", new List<Author>() { a2 }, new List<Review>() { rev });
                Book symf = AddBook("Symfonia C++", new List<Author>() { a3 }, new List<Review>() { rev });
                Book iliada = AddBook("Iliada", new List<Author>() { a4 }, new List<Review>() { rev });
                Book wladca = AddBook("Władca Pierścieni", new List<Author>() { a5 }, new List<Review>() { rev });


                List<string> Names = new List<string>() { "Janusz", "Ewa", "Ada", "Tomasz", "Martyna", "Wojtek" };
                List<string> Surnames = new List<string>() { "Krzemiński", "Krzmińska", "Krzemińska", "Krzemiński", "Kawka", "Sarnecki" };
                Adress adress = new Adress() { BuildingNumber = "10", Street = "Aleja Jana Pawła II", Country = "Poland", Town = "Świecie", PostCode = "86-100" };

                for (int i = 0; i < Names.Count; i++)
                {
                    AddUser(Names[i], Surnames[i], adress);
                }



            }       
                     
               

        }


    }
}
