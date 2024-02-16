using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var currentAssembly = typeof(DataContext).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(currentAssembly);
        }

    }
}
