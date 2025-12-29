using DietSync.Core.Entities;
using DietSync.Core.Entities.Filters;
using DietSync.Core.Repositories;
using DietSync.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DietSync.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DietSyncDbContext _dbContext;

        public UserRepository(DietSyncDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<long> Create(User user)
        {
            await _dbContext.Users.AddAsync(user);
            return user.Id;
        }

        public Task Delete(User user)
        {
            _dbContext.Users.Remove(user);
            return Task.CompletedTask;
        }

        public Task<List<User>> GetAll(UserFilter filter)
        {
            var users = _dbContext.Users.ToListAsync();
            return users;
        }

        public async Task<User?> GetById(long id)
        {
            var user = await _dbContext.Users.
                Include(u => u.Treinos).
                Include(u => u.Dietas).
                Include(u => u.Evolucoes).
                Include(u => u.Receitas).
                FirstOrDefaultAsync(x => x.Id == id);

            return user;
        }

        public Task Update(User user)
        {
            _dbContext.Users.Update(user);
            return Task.CompletedTask;
        }
    }
}
