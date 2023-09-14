using BIManage.Models;
using BIManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BIManager.Data
{
    public class BIManagerDataContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<BaseDeDados> BasesDeDados { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        // public DbSet<ConsultaBaseDeDados> ConsultasBaseDeDados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer(@"Server=localhost,1433;Database=BIManager;User ID=sa;Password=password123@;Encrypt=True;TrustServerCertificate=True");

    }
}