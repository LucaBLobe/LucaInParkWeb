using LucaInParkWeb.Models.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LucaInParkWeb.Models.Infrastructure.Contexts
{
    public class ControleEstacionamentoContext : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }
        public ControleEstacionamentoContext(DbContextOptions options) 
            : base(options)
        { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
