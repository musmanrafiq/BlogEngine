using System.Threading.Tasks;

namespace BlogEngine.Data.Interfaces
{
    public interface IGenericRepository<TEntity, TKey>
    {
        Task<TEntity> GetAsync();
    }
}
