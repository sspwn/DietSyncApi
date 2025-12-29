namespace DietSync.Core.Repositories
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync();
    }
}
