using book_api.Entities;
using electronic_api.Entities;
using fashion_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace shared.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Fashion> Fashions { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Phone> Phones { get; set; }
    }
}