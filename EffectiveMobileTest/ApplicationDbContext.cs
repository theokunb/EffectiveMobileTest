using EffectiveMobileTest.Entity;
using Microsoft.EntityFrameworkCore;

namespace EffectiveMobileTest
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<FiltersAndOrders> FiltersAndOrders { get;set; }
        public DbSet<FilteredOrders> FilteredOrders { get; set; }
    }
}
