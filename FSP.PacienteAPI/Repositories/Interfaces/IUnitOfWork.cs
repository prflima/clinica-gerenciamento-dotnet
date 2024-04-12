namespace FSP.PacienteAPI.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task CompleteAsync();
    }
}
