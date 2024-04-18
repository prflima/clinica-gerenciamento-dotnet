namespace FSP.PacienteAPI.Repositories.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<IEnumerable<T>> All();
        Task<T> GetById(Guid id);
        Task<bool> Create(T entity);
        Task<bool> Update(T entity);    }
}
