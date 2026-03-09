using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SIGC.Models
{
    [Table("Agendamento")]
    public class Agendamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Display(Name = "AgendamentoId")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "AgendamentoCPF")]
        [Column("PacienteCPF")]
        public string PacienteCPF { get; set; }

        [Display(Name = "EspecialidadeAgend")]
        [Column("Especialidade")]
        public string Especialidade { get; set; }

        [Display(Name = "AgendamentoData")]
        [Column("Data")]
        public string Data { get; set; }

        [Display(Name = "AgendamentoHoraI")]
        [Column("Hora_Inicio")]
        public string Hora_Inicio { get; set; }

        [Display(Name = "AgendamentoHoraF")]
        [Column("Hora_Fim")]
        public string Hora_Fim { get; set; }
    }
}
