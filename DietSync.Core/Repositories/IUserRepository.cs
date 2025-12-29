using DietSync.Core.Entities;
using DietSync.Core.Entities.Filters;

namespace DietSync.Core.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll(UserFilter filter);
        Task<User?> GetById(long id);
        Task<long> Create(User user);
        Task Update(User user);
        Task Delete(User user);
    }
}
