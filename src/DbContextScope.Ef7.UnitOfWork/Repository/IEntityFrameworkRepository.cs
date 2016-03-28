using DbContextScope.UnitOfWork.Core.Repository;
using Microsoft.Data.Entity;

namespace DbContextScope.UnitOfWork.Ef7.Repository
{
    /// <summary>
    /// Defines a generic Entity Framework repository.
    /// </summary>
    /// <typeparam name="TEntity">Type of the entities that the repository will manage.</typeparam>
    /// <typeparam name="TContext">Type of the Entity Framework context.</typeparam>
    public interface IEntityFrameworkRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext
    {
    }
}
