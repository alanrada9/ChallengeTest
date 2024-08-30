using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Linq.Expressions;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly IApplicationDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public Repository(IApplicationDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _dbSet.FindAsync(new object[] { id }, cancellationToken);
    }

    public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
    {
        return await _dbSet.FirstOrDefaultAsync(predicate, cancellationToken);
    }

    public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IQueryable<T>> include = null, CancellationToken cancellationToken = default)
    {
        var query = _dbSet.AsQueryable();

        if (include != null)
        {
            query = include(query);
        }

        return await query.FirstOrDefaultAsync(predicate, cancellationToken);
    }

    public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _dbSet.ToListAsync(cancellationToken);
    }

    public async Task AddAsync(T entity, CancellationToken cancellationToken)
    {
        await _dbSet.AddAsync(entity, cancellationToken);
    }

    public async Task UpdateAsync(T entity, CancellationToken cancellationToken)
    {
        _dbSet.Update(entity);
        await SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteAsync(T entity, CancellationToken cancellationToken)
    {
        _dbSet.Remove(entity);
        await SaveChangesAsync(cancellationToken);
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }
}
