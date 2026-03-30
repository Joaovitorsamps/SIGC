using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;

namespace SIGC.Models
{
    [Table("Pacientes")]
    public class Pacientes : BaseModel
    {
        [PrimaryKey("CPF_Paciente")]
        [Column("CPF_Paciente")]
        public string CPF_Paciente { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }

        [Column("DDD")]
        public string DDD { get; set; }

        [Column("Telefone")]
        public string Telefone { get; set; }

        [Column("CEP")]
        public string CEP { get; set; }

        [Column("Rua")]
        public string Rua { get; set; }
    }
}