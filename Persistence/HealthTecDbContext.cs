using Health_Tec.Models;
using Microsoft.EntityFrameworkCore;

namespace Health_Tec.Persistence
{
    public class HealthTecDbContext : DbContext
    {
        public HealthTecDbContext(DbContextOptions<HealthTecDbContext> options) : base (options)
        {
            
        }
        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Estado> Estados { get; set; }

    }
}