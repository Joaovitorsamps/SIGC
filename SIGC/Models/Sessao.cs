using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;

namespace SIGC.Models
{
    [Table("Sessao")]
    public class Sessao : BaseModel
    {
        [PrimaryKey("id")]
        public int id { get; set; }

        [Column("ID_Agendamento")]
        public string ID_Agendamento { get; set; }

        [Column("ID_Paciente")]
        public string ID_Paciente { get; set; }

        [Column("ID_Fisioterapeuta")]
        public string ID_Fisioterapeuta { get; set; }

        [Column("Preco_Sessao")]
        public string Preco_Sessao { get; set; }

        [Column("Status_Pagamento")]
        public bool Status_Pagamento { get; set; }
    }
}
