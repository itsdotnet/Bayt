using System.Linq.Expressions;
using Bayt.DataAccess.Contexts;
using Bayt.DataAccess.Contracts;
using Bayt.Domain.Commons;
using Microsoft.EntityFrameworkCore;

namespace Bayt.DataAccess.Repositories;

public class Repository<TEntity>:IRepository<TEntity> where TEntity:Auditable
{
    private readonly BaytDbContext _context;
    private readonly DbSet<TEntity> _dbSet;
    
    public Repository(BaytDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }
    
    public async ValueTask CreateAsync(TEntity entity) => await _dbSet.AddAsync(entity);

    public void Update(TEntity entity) => _context.Entry(entity).State = EntityState.Modified;
    
    public void Delete(TEntity entity) => entity.IsDeleted = true;
    
    public void Destroy(TEntity entity) => _dbSet.Remove(entity);
    
    public async ValueTask<TEntity> SelectAsync(Expression<Func<TEntity, bool>> expression, string[] includes = null)
    {
        IQueryable<TEntity> entities = _dbSet.Where(expression).AsQueryable();

        if(includes!=null)
            foreach (var include in includes)
                entities = entities.Include(include);

        return await entities.FirstOrDefaultAsync();
    }
    
    public IQueryable<TEntity> SelectAll(Expression<Func<TEntity, bool>> expression = null, string[] includes = null, bool isTracking = true)
    {
        IQueryable<TEntity> entities = expression == null 
            ? _dbSet.AsQueryable() 
                : _dbSet.Where(expression).AsQueryable();

        entities = isTracking ? entities.AsNoTracking() : entities;
        
        if(includes!=null)
            foreach (var include in includes)
                entities = entities.Include(include);

        return entities;
    }
}