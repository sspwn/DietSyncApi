using DietSync.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DietSync.Infrastructure.Persistence
{
    public class DietSyncDbContext : DbContext
    {
        public DietSyncDbContext(DbContextOptions<DietSyncDbContext> options)
         : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Treino> Treinos { get; set; }
        public DbSet<Dieta> Dietas { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Evolucao> Evolucoes { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(DietSyncDbContext).Assembly);
            base.OnModelCreating(builder);
        }

    }
}
