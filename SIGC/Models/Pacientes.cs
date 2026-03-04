using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGC.Models
{
    [Table("Pacientes")]
    public class Pacientes
    {
        [Display(Name = "PacienteCPF")]
        [Column("CPF")]
        public int CPF { get; set; }

        [Display(Name = "PacienteNome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "PacienteTelefone")]
        [Column("Telefone")]
        public string Telefone { get; set; }

        [Display(Name = "PacienteCEP")]
        [Column("CEP")]
        public string CEP { get; set; }

        [Display(Name = "PacienteRua")]
        [Column("Rua")]
        public string Rua { get; set; }
    }
}
