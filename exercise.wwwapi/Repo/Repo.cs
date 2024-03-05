using exercise.wwwapi.Data;
using Microsoft.EntityFrameworkCore;

namespace exercise.wwwapi.Repo
{
    public class Repo<T> : IRepo<T> where T : class
    {
        private DataContext _db;
        private DbSet<T> _table;

        public Repo(DataContext dataContext)
        {
            _db = dataContext;
            _table = _db.Set<T>();
        }

        public virtual async Task<T> Delete(object id)
        {
            var entity = await _table.FindAsync(id);
            if (entity != null)
            {
                _table.Remove(entity);
                await _db.SaveChangesAsync();
            }
            return entity;
        }

        public virtual Task<T> Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> Delete(object id_1, object id_2)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<IEnumerable<T>> Get()
        {
            return await _table.ToListAsync();
        }


        public virtual async Task<T> GetById(object id)
        {
            return await _table.FindAsync(id);
        }

        public virtual Task<T> GetById(object id_1, object id_2)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> Insert(T entity)
        {
            await _table.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }


        public virtual async Task<T> Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
