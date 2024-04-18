using FSP.PacienteAPI.Models;

namespace FSP.PacienteAPI.Repositories.Interfaces
{
    public interface IPacienteRepository : IRepositoryBase<Paciente>
    {
        bool Unactive(Guid id);
    }
}
