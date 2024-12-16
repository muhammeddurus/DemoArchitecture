using DrsDemo.Domain.Common;
using DrsDemo.Infrastructure.Context;
using DrsDemo.Infrastructure.Helper.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Infrastructure.Repositories
{
    public class ReadBaseRepository<T,TKey> : IReadBaseRepository<T,TKey> where T : EntityBase<TKey> 
    {
        private readonly DrsDemoReadDbContext _readDbContext;
        private readonly DbSet<T> _dbSet;

        public ReadBaseRepository(DrsDemoReadDbContext readDbContext)
        {
            _readDbContext = readDbContext;
            _dbSet = readDbContext.Set<T>();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? expression = null)
        {
            var list = await _dbSet.WhereIf(expression is not null, expression).ToListAsync();
            return list;
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>>? expression = null)
        {
            var result = await _dbSet.WhereIf(expression is not null, expression).FirstOrDefaultAsync();
            return result;
        }

        public async Task<T> GetByIdAsync(TKey id)
        {
            var result = await _dbSet.AsQueryable().FirstOrDefaultAsync(x => x.Id.Equals(id));
            return result;
        }
    }
}
