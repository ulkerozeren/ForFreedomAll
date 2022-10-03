using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistance
{
    public class BaseRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext
    {
        protected TContext _context { get; }

        public BaseRepository(TContext context)
        {
            _context = context;
        }


        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public IQueryable<TEntity> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }

        public async Task<IQueryable<TEntity>> GetWhere(Expression<Func<TEntity, bool>> method, bool tracking = true)
        {
            var query = Table.Where(method);
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }

        public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = Table.AsNoTracking();

            return await query.FirstOrDefaultAsync(method);
        }

        public async Task<TEntity> GetByIdAsync(string id, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(data => data.Id == id);
        }

        public async Task<bool> AddAsync(TEntity model)
        {
            EntityEntry<TEntity> entityEntry = await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<TEntity> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }

        public bool Remove(TEntity model)
        {
            EntityEntry<TEntity> entityEntry = Table.Remove(model);
            return  entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveRange(List<TEntity> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            TEntity model = await Table.FirstOrDefaultAsync(data => data.Id == id);
            return Remove(model);   
        }

        public async Task<bool> Update(TEntity model)
        {
            EntityEntry entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }

        public async Task<int> SaveAsync()
        {
           return await _context.SaveChangesAsync();
        }

 
    }
}

