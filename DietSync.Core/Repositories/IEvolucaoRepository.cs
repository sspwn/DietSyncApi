using DietSync.Core.Entities.Filters;
using DietSync.Core.Entities;

namespace DietSync.Core.Repositories
{
    public interface IEvolucaoRepository
    {
        Task<List<Evolucao>> GetAll(EvolucaoFilter filter);
        Task<Evolucao?> GetById(long id);
        Task<long> Create(Evolucao evolucao);
        Task Update(Evolucao evolucao);
        Task Delete(Evolucao evolucao);
    }
}
