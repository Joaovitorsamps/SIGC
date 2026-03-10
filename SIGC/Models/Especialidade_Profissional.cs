using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;

namespace SIGC.Models
{
    [Table("Especialidade_Profissional")]
    public class Especialidade_Profissional : BaseModel
    {
        [PrimaryKey("id")]
        public int id { get; set; }

        [Column("Matricula")]
        public string Matricula { get; set; }

        [Column("ID_Especialidade")]
        public string ID_Especialidade { get; set; }
    }
}
