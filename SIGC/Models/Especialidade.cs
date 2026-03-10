using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;

namespace SIGC.Models
{
    [Table("Especialidade")]
    public class Especialidade : BaseModel
    {
        [PrimaryKey("id")]
        public int id { get; set; }

        [Column("Especialidade")]
        public string Especialidade_Nome { get; set; }
    }
}
