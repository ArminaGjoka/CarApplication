using CarApplication_Mudblazor.Models;
using Microsoft.EntityFrameworkCore;

namespace CarApplication_Mudblazor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
