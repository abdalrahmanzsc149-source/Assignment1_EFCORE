
using Assignment1_EFCORE.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment1_EFCORE.Data
{
    public class BookStoreDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.;Database=BookStoreDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
