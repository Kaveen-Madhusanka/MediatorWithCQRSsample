using MediatorWithCQRSsample.Model;
using Microsoft.EntityFrameworkCore;

namespace MediatorWithCQRSsample.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Employee> Employee { get; set; }  
    }
}
