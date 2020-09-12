using BetaECommerce.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BetaECommerce.DataAccess.Abstract
{
    public interface IRepository<T>
        where T : class, IEntity, new()
    {
        Task<T> Get(Expression<Func<T, bool>> expression);
        Task<T> GetList(Expression<Func<T, bool>> expression);
        Task<T> Insert(T model);
        Task<T> Update(T model);

        Task<bool> Delete(T model);
        Task<bool> InsertRange(IList<T> models);
        Task<bool> UpdateRange(IList<T> models);
        Task<bool> DeleteRange(IList<T> models);

    }
}
