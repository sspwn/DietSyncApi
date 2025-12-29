using DietSync.Core.Entities.Filters;
using DietSync.Core.Entities;

namespace DietSync.Core.Repositories
{
    public interface IDietaRepository
    {
        Task<List<Dieta>> GetAll(DietaFilter filter);
        Task<Dieta?> GetById(long id);
        Task<long> Create(Dieta dieta);
        Task Update(Dieta dieta);
        Task Delete(Dieta dieta);
    }
}
