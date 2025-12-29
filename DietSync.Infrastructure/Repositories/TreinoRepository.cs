using DietSync.Core.Entities;
using DietSync.Core.Entities.Filters;
using DietSync.Core.Repositories;
using DietSync.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DietSync.Infrastructure.Repositories
{
    public class TreinoRepository : ITreinoRepository
    {
        private readonly DietSyncDbContext _dbContext;

        public TreinoRepository(DietSyncDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<long> Create(Treino treino)
        {
            var addtreino = await _dbContext.Treinos.AddAsync(treino);
            return treino.Id;
        }

        public Task Delete(Treino treino)
        {
            _dbContext.Remove(treino);
            return Task.CompletedTask;
        }

        public async Task<List<Treino>> GetAll(TreinoFilter filter)
        {
            var treinos = await _dbContext.Treinos.ToListAsync();
            return treinos;
        }

        public async Task<Treino?> GetById(long id)
        {
            var treino = await _dbContext.Treinos.FirstOrDefaultAsync(t => t.Id == id);
            return treino;
        }

        public Task Update(Treino treino)
        {
            _dbContext.Update(treino);
            return Task.CompletedTask;
        }
    }
}
