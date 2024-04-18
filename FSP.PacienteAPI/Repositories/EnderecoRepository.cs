using FSP.PacienteAPI.Data;
using FSP.PacienteAPI.Models;
using FSP.PacienteAPI.Repositories.Interfaces;

namespace FSP.PacienteAPI.Repositories
{
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(PostgreeSQLContext context)
            : base(context){ }
    }
}
