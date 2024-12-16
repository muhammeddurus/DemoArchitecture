using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Infrastructure.Helper.Extensions
{
    public static class LinqExtensions
    {
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> query, bool IsInQuery, Expression<Func<T, bool>> predicate)
        {
            if (IsInQuery)
                query = query.Where(predicate);
            return query;
        }
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> query, bool IsInQuery, Func<T, bool> predicate)
        {
            if (IsInQuery)
                query = query.Where(predicate);
            return query;
        }
    }
}
