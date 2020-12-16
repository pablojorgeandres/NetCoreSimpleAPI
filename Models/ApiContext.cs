using Microsoft.EntityFrameworkCore;

namespace NetCoreSimpleAPI.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Seed();

        public DbSet<User> Users { get; set; }
    }
}
