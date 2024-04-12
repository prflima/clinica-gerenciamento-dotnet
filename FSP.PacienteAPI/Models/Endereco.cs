using FSP.PacienteAPI.Models.Enums;

namespace FSP.PacienteAPI.Models
{
    public class Endereco : BaseEntity
    {
        public string Rua { get; set; }
        public string Complemento{ get; set; }
        public int Numero { get; set; }
        public int CEP { get; set; }
        public string Cidade { get; set; }
        public TipoEndereco TipoEndereco { get; set; }
    }
}
