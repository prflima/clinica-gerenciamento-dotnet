using FSP.PacienteAPI.Data;
using FSP.PacienteAPI.Models;
using FSP.PacienteAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FSP.PacienteAPI.Repositories
{
    public class PacienteRepository : RepositoryBase<Paciente>, IPacienteRepository
    {
        public PacienteRepository(PostgreeSQLContext context)
            : base (context){ }

        public bool Unactive(Guid id)
        {
            try
            {
                var paciente = GetById(id);
                if (paciente != null)
                {
                    paciente.Result.IsActive = false;
                    _context.Entry<Paciente>(paciente.Result).State = EntityState.Modified;
                    _dbSet.Update(paciente.Result);

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception($"Occurs error when unactive paciente with identifier: {id}");
            }
        }
    }
}
