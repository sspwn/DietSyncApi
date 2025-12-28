using DietSync.Core.Entities;
using DietSync.Core.Repositories;
using DietSync.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DietSync.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DietSyncDbContext _dbContext;

        public UserRepository(DietSyncDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User?> GetById(int id)
        {
            
           return   await _dbContext.Users.SingleOrDefaultAsync(u => u.Id == id);
        }
    }
}
