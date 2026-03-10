using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;
namespace SIGC.Models
{
    [Table("Agendamento")]
    public class Agendamento : BaseModel
    {
        [PrimaryKey("AgendamentoId")]
        public int Id { get; set; }

        [Column("PacienteCPF")]
        public string PacienteCPF { get; set; }

        [Column("Especialidade")]
        public string Especialidade { get; set; }

        [Column("Data")]
        public string Data { get; set; }

        [Column("Hora_Inicio")]
        public string Hora_Inicio { get; set; }

        [Column("Hora_Fim")]
        public string Hora_Fim { get; set; }
    }
}
