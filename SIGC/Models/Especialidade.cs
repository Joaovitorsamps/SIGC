using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGC.Models
{
    [Table("Especialidade")]
    public class Especialidade
    {
        [Required]
        [Display(Name = "Especialidade_ID")]
        [Column("id")]
        public int id { get; set; }

        [Display(Name = "Nome_Especialidade")]
        [Column("Especialidade")]
        public string Especialidade_Nome { get; set; }
    }
}
