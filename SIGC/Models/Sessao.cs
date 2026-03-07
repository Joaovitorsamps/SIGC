using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGC.Models
{
    [Table("Sessao")]
    public class Sessao
    {
        [Required]
        [Display(Name = "ID_Sessao")]
        [Column("id")]
        public int id { get; set; }

        [Display(Name = "ID_Agendamento")]
        [Column("ID_Agendamento")]
        public string ID_Agendamento { get; set; }

        [Display(Name = "ID_Paciente")]
        [Column("ID_Paciente")]
        public string ID_Paciente { get; set; }

        [Display(Name = "ID_Fisioterapeuta")]
        [Column("ID_Fisioterapeuta")]
        public string ID_Fisioterapeuta { get; set; }

        [Display(Name = "Preco_Sessao")]
        [Column("Preco_Sessao")]
        public string Preco_Sessao { get; set; }

        [Display(Name = "Status_Pagamento")]
        [Column("Status_Pagamento")]
        public bool Status_Pagamento { get; set; }
    }
}
