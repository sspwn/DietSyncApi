using DietSync.Core.Entities;

namespace DietSync.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetById(int id);
    }
}
