using FSP.PacienteAPI.Models.Enums;

namespace FSP.PacienteAPI.Models
{
    public class Paciente : BaseEntity
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public IList<Endereco> Enderecos { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public TipoPaciente TipoPaciente { get; set; }
    }
}
