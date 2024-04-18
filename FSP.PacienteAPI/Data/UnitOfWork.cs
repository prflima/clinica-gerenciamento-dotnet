using FSP.PacienteAPI.Repositories;
using FSP.PacienteAPI.Repositories.Interfaces;

namespace FSP.PacienteAPI.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly PostgreeSQLContext _context;
        public IPacienteRepository Paciente { get; private set; }
        public IEnderecoRepository Endereco { get; private set; }

        public UnitOfWork(PostgreeSQLContext context)
        {
            _context = context;

            Paciente = new PacienteRepository(context);
            Endereco = new EnderecoRepository(context);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
