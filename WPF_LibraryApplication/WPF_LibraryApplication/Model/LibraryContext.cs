using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WPF_LibraryApplication.Model
{

    public class LibraryDbContextFactory : IDesignTimeDbContextFactory<LibraryContext>
    {
        public LibraryContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder options = new DbContextOptionsBuilder();
           DbContextOptions opt=   options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=WPFLibraryApp;Trusted_Connection=True;").Options;
            return new LibraryContext(opt);
        }
    }



    public class LibraryContext : DbContext
    {


       public LibraryContext(DbContextOptions options) : base(options) { }


        //protected override void OnConfiguring(
        //     DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=WPFLibraryApp;Trusted_Connection=True;");
        //}

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Author> Authors { get; set; }


        
    }
    
}
