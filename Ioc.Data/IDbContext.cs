using System.Data.Entity;
using Ioc.Core;
namespace Ioc.Data
{
   public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
        int SaveChanges();
    }
}
