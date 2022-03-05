using FreelanceStudent.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceStudent.EntityFramework.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> 
        where TEntity : class
    {
        protected readonly DbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public RepositoryBase(DbContext dbContext, DbSet<TEntity> dbSet)
        {
            _dbContext = dbContext;
            _dbSet = dbSet;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbContext.Entry(entity).State = EntityState.Detached;
            }

            return entity;
        }

        public void Remove(TEntity entity)
        {
           _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _dbSet.SingleOrDefaultAsync(filter);
        }

        public void Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.Where(filter);
        }
    }
}
