using Microsoft.EntityFrameworkCore;
using WebSaleApplication.Models;

namespace WebSaleApplication.Data
{
    public class IntegrationDbContext : DbContext
    {
        public IntegrationDbContext (DbContextOptions<IntegrationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; } = default!;
        public DbSet<SalesRecord> SalesRecord { get; set; } = default!;
    }
}
