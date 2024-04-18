using FSP.PacienteAPI.Data;
using FSP.PacienteAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FSP.PacienteAPI.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected PostgreeSQLContext _context;
        protected DbSet<T> _dbSet;

        public RepositoryBase(PostgreeSQLContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> All()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Occurs error in get all {nameof(T)} repository: {ex.Message}");
            }
        }

        public virtual async Task<T> GetById(Guid id)
        {
            try
            {
                var entity = await _dbSet.FindAsync(id);
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"Occurs error in get by identifier {nameof(T)} repository: {ex.Message}");
            }
        }

        public virtual async Task<bool> Create(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Occurs error when create {nameof(T)}: {ex.Message}");
            }
        }

        public virtual async Task<bool> Update(T entity)
        {
            try
            {
                _context.Entry<T>(entity).State = EntityState.Modified;
                _dbSet.Update(entity);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Occurs error when update {nameof(T)}: {ex.Message}");
            }
        }
    }
}
