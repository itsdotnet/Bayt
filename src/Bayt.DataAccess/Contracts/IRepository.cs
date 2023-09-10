using System.Linq.Expressions;
using Bayt.Domain.Commons;

namespace Bayt.DataAccess.Contracts;

public interface IRepository<TEntity> where TEntity : Auditable
{
    Task CreateAsync(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    void Destroy(TEntity entity);
    Task<TEntity> SelectAsync(Expression<Func<TEntity, bool>> expression = null,string[] includes = null);
    IQueryable<TEntity> SelectAll(Expression<Func<TEntity, bool>> expression = null,string[] includes = null,
        bool isTracking = true);
}