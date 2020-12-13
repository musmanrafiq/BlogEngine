using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlogEngine.Data.Interfaces
{
    public interface IBlogEngineDbContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        Task ReloadEntitiesAsync();
    }
}
