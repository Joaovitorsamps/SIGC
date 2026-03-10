using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;

namespace SIGC.Models
{
    [Table("Pacientes")]
    public class Pacientes : BaseModel
    {
        [PrimaryKey("CPF")]
        public string CPF { get; set; }

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