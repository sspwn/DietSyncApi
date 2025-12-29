using DietSync.Core.Repositories;
using DietSync.Infrastructure.Persistence;

namespace DietSync.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DietSyncDbContext _context;

        public UnitOfWork(DietSyncDbContext context)
        {
            _context = context;
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
