using Microsoft.EntityFrameworkCore;

namespace BackEnd.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Sach> Saches { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options) { }
    }
}