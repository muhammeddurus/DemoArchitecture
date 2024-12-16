using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Domain.Common
{
    public interface IReadBaseRepository<T,TKey> where T : EntityBase<TKey>
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? expression=null);
        Task<T> GetAsync(Expression<Func<T, bool>>? expression = null);
        Task<T> GetByIdAsync(TKey id);
    }
}
