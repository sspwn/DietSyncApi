using DietSync.Core.Entities;
using DietSync.Core.Entities.Filters;
using DietSync.Core.Repositories;
using DietSync.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DietSync.Infrastructure.Repositories
{
    public class ReceitaRepository : IReceitaRepository
    {
        private readonly DietSyncDbContext _dbContext;

        public ReceitaRepository(DietSyncDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<long> Create(Receita receita)
        {
            await _dbContext.Receitas.AddAsync(receita);
            return receita.Id;
        }

        public Task Delete(Receita receita)
        {
            _dbContext.Receitas.Remove(receita);
            return Task.CompletedTask;
        }

        public Task<List<Receita>> GetAll(ReceitaFilter filter)
        {
            var receitas = _dbContext.Receitas.ToListAsync();
            return receitas;
        }

        public Task<Receita?> GetById(long id)
        {
            var receita = _dbContext.Receitas.FirstOrDefaultAsync(r => r.Id == id);
            return receita;
        }

        public Task Update(Receita receita)
        {
            _dbContext.Receitas.Update(receita);
            return Task.CompletedTask;
        }
    }
}
