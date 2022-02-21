using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_BookStore.Models
{
    public class BookStoreDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
           : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
