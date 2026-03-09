using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGC.Models
{
    public class Colaboradores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Display(Name = "Matricula")]
        [Column("Matricula")]
        public int Matricula { get; set; }

        [Display(Name = "Nome_Colaborador")]
        [Column("Nome_Colaborador")]
        public string Nome_Colaborador { get; set; }

        [Display(Name = "Funcao")]
        [Column("Funcao")]
        public string funcao { get; set; }
    }
}
