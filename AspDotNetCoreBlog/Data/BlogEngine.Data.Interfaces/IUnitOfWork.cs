using System.Threading.Tasks;

namespace BlogEngine.Data.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
        Task ReloadEntites();
    }
}
