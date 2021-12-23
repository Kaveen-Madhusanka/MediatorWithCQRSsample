using MediatRWithCQRSSample2.Model;
using Microsoft.EntityFrameworkCore;

namespace MediatRWithCQRSSample2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Product> products { get; set; }
    }
}
