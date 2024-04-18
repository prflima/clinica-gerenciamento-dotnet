namespace FSP.PacienteAPI.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
