using DietSync.Core.Entities;
using DietSync.Core.Entities.Filters;
using DietSync.Core.Repositories;
using DietSync.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DietSync.Infrastructure.Repositories
{
    public class EvolucaoRepository : IEvolucaoRepository
    {
        private readonly DietSyncDbContext _dbContext;

        public EvolucaoRepository(DietSyncDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<long> Create(Evolucao evolucao)
        {
            await _dbContext.Evolucoes.AddAsync(evolucao);
            return evolucao.Id;
        }

        public Task Delete(Evolucao evolucao)
        {
            _dbContext.Evolucoes.Remove(evolucao);
            return Task.CompletedTask;
        }

        public Task<List<Evolucao>> GetAll(EvolucaoFilter filter)
        {
            var evolucoes = _dbContext.Evolucoes.ToListAsync();
            return evolucoes;
        }

        public Task<Evolucao?> GetById(long id)
        {
            var evolucao = _dbContext.Evolucoes.FirstOrDefaultAsync(e => e.Id == id);
            return evolucao;
        }

        public Task Update(Evolucao evolucao)
        {
            _dbContext.Evolucoes.Update(evolucao);
            return Task.CompletedTask;
        }
    }
}
