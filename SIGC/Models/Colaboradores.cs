using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;

namespace SIGC.Models
{
    public class Colaboradores : BaseModel
    {
        [PrimaryKey("Matricula")]
        public int Matricula { get; set; }

        [Column("Nome_Colaborador")]
        public string Nome_Colaborador { get; set; }

        [Column("Funcao")]
        public string funcao { get; set; }
    }
}
