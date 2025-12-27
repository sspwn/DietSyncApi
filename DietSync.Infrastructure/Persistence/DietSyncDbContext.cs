using Microsoft.EntityFrameworkCore;

namespace DietSync.Infrastructure.Persistence
{
    public class DietSyncDbContext : DbContext
    {
        public DietSyncDbContext(DbContextOptions<DietSyncDbContext> options)
         : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(DietSyncDbContext).Assembly);
            base.OnModelCreating(builder);
        }

    }
}
