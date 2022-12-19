using lubrary_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace lubrary_mvc.DBContext
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}
