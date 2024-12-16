using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Domain.Common
{
    public interface IWriteBaseRepository<T,TKey> where T : EntityBase<TKey>
    {
        Task<TKey> InsertAsync(T entity);
        Task<bool> InsertManyAsync(List<T> entities);
        bool UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
    }
}
