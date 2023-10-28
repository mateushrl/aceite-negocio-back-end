using AceiteNegocio.Mappings;
using AceiteNegocio.Models;
using Microsoft.EntityFrameworkCore;

namespace AceiteNegocio.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LancamentoMap());
        }

        public DbSet<Lancamento> Lancamentos { get; set;}
    }
}
