using System.Linq.Expressions;
using ticketEccommerce.Models;

namespace ticketEccommerce.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includePropieteis);
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}

