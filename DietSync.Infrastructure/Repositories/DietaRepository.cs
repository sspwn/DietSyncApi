using DietSync.Core.Entities;
using DietSync.Core.Entities.Filters;
using DietSync.Core.Repositories;
using DietSync.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DietSync.Infrastructure.Repositories
{
    public class DietaRepository : IDietaRepository
    {
        private readonly DietSyncDbContext _dbContext;

        public DietaRepository(DietSyncDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<long> Create(Dieta dieta)
        {
            await _dbContext.Dietas.AddAsync(dieta);
            return dieta.Id;
        }

        public Task Delete(Dieta dieta)
        {
            _dbContext.Dietas.Remove(dieta);
            return Task.CompletedTask;
        }

        public async Task<List<Dieta>> GetAll(DietaFilter filter)
        {
            var Dietas = await _dbContext.Dietas.ToListAsync();
            return Dietas;
        }

        public async Task<Dieta?> GetById(long id)
        {
            var dieta = await _dbContext.Dietas.FirstOrDefaultAsync(d => d.Id == id);
            return dieta;
        }

        public Task Update(Dieta dieta)
        {
            _dbContext.Dietas.Update(dieta);
            return Task.CompletedTask;
        }
    }
}
