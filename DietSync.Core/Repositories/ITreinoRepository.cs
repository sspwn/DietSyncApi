using DietSync.Core.Entities.Filters;
using DietSync.Core.Entities;

namespace DietSync.Core.Repositories
{
    public interface ITreinoRepository
    {
        Task<List<Treino>> GetAll(TreinoFilter filter);
        Task<Treino?> GetById(long id);
        Task<long> Create(Treino treino);
        Task Update(Treino treino);
        Task Delete(Treino treino);
    }
}
