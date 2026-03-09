using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGC.Models
{
    [Table("Especialidade_Profissional")]
    public class Especialidade_Profissional
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Display(Name = "id")]
        [Column("id")]
        public int id { get; set; }

        [Display(Name = "Matricula_Especialidade")]
        [Column("Matricula")]
        public string Matricula { get; set; }

        [Display(Name = "ID_Especialidade")]
        [Column("ID_Especialidade")]
        public string ID_Especialidade { get; set; }
    }
}
