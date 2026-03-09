using Microsoft.EntityFrameworkCore;
using SIGC.Models;
namespace SIGC.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> Options) 
        :   base(Options) 
        { }

        public DbSet<Pacientes> Pacientes { get; set; }
        public DbSet<Colaboradores> Colaboradores { get; set; }
        public DbSet<Sessao> sessaos { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }
        public DbSet<Especialidade_Profissional> Especialidade_profissional { get; set; }
        public DbSet<Preco_Hora> Preco_Hora { get; set; }
        public DbSet<ErrorViewModel> ErrorViewModel { get; set; }
    }
}
