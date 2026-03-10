using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;

namespace SIGC.Models
{
    [Table("Preco_Hora")]
    public class Preco_Hora : BaseModel
    {
        [PrimaryKey("id")]
        public int id { get; set; }

        [Column("Meia_Hora")]
        public string Meia_Hora { get; set; }

        [Column("ID_Especialidade")]
        public string ID_Especialidade { get; set; }
    }
}
