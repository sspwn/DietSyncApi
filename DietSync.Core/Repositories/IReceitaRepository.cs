using DietSync.Core.Entities.Filters;
using DietSync.Core.Entities;

namespace DietSync.Core.Repositories
{
    public interface IReceitaRepository
    {
        Task<List<Receita>> GetAll(ReceitaFilter filter);
        Task<Receita?> GetById(long id);
        Task<long> Create(Receita receita);
        Task Update(Receita receita);
        Task Delete(Receita receita);
    }
}
