using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SiteEmprego.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts)
            : base(opts) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vaga> Vagas { get; set; }
        public DbSet<Candidatura> Candidaturas { get; set; }
        public DbSet<Curriculo> Curriculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Vaga>().ToTable("Vaga");
            modelBuilder.Entity<Candidatura>().ToTable("Candidatura");
            modelBuilder.Entity<Curriculo>().ToTable("Curriculo");
        }
    }
}
