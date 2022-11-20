using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WPF_LibraryApplication.Model
{
    public class LibraryContext : DbContext
    {


       


        protected override void OnConfiguring(
             DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=WPFLibraryApp;Trusted_Connection=True;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Author> Authors { get; set; }


        
    }
    
}
