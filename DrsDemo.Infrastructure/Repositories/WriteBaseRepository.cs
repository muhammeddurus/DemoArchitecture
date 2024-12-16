using DrsDemo.Domain.Common;
using DrsDemo.Domain.UnitOfWorks;
using DrsDemo.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Infrastructure.Repositories
{
    public class WriteBaseRepository<T,TKey> : IWriteBaseRepository<T,TKey> where T : EntityBase<TKey>
    {
        public readonly DrsDemoWriteDbContext _writeDbContext;
        public readonly IUnitOfWork _uOw;
        public readonly DbSet<T> _dbSet;

        public WriteBaseRepository(DrsDemoWriteDbContext writeDbContext, IUnitOfWork uOw)
        {
            _writeDbContext = writeDbContext;
            _uOw = uOw;
            _dbSet = _writeDbContext.Set<T>();
        }

        public Task<bool> DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            _uOw.Commit();
            return Task.FromResult(true);
        }

        public Task<TKey> InsertAsync(T entity)
        {
            var res = _dbSet.Add(entity);
            _uOw.Commit();
            return Task.FromResult(res.Entity.Id);
        }

        public async Task<bool> InsertManyAsync(List<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await _uOw.CommitAsync();
            return true;
        }

        public bool UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            _uOw.Commit();
            return true;
        }
        
    }
}
