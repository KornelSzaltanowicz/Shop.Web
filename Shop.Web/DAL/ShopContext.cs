using Shop.Web.Models;
using System.Data.Entity;

namespace Shop.Web.DAL
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("ShopContext") { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Cover> Covers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<PublicationDate> PublicationDate { get; set; }
        public DbSet<DataCarrier> DataCarrier { get; set; }

    }
}