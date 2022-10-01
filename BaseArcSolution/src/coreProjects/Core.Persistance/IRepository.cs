using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.Persistance
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll(bool tracking = true);
        Task<IQueryable<TEntity>> GetWhere(Expression<Func<TEntity, bool>> method, bool tracking = true);
        Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> method, bool tracking = true);
        Task<TEntity> GetByIdAsync(string id, bool tracking = true);
        Task<bool> AddAsync(TEntity model);
        Task<bool> AddRangeAsync(List<TEntity> datas);
        bool Remove(TEntity model);
        Task<bool> RemoveRange(List<TEntity> datas);
        Task<bool> RemoveAsync(string id);
        Task<bool> Update(TEntity model);
        Task<int> SaveAsync();
    }
}
