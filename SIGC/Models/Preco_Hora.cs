using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGC.Models
{
    [Table("Preco_Hora")]
    public class Preco_Hora
    {
        [Required]
        [Display(Name = "ID_Preco_Hora")]
        [Column("id")]
        public int id { get; set; }

        [Display(Name = "Meia_Hora")]
        [Column("Meia_Hora")]
        public string Meia_Hora { get; set; }

        [Display(Name = "ID_Especialidade")]
        [Column("ID_Especialidade")]
        public string ID_Especialidade { get; set; }
    }
}
