using System.Data;
using DbContextScope.UnitOfWork.Core.Interfaces;
using Microsoft.Data.Entity.Storage;

namespace DbContextScope.UnitOfWork.Ef7
{
    public interface IEntityFrameworkUnitOfWork<TContext> : IUnitOfWork where TContext : class
    {
        IRelationalTransaction BeginTransaction();

        IRelationalTransaction BeginTransaction(IsolationLevel isolationLevel);
    }
}
